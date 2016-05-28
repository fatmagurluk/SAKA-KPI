using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using SAKA.Service.Contract;
using SAKA.DTO;
using System.Drawing;

namespace SAKA.Web.UI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ABC (Adres Binding Contract)

            var adress = new EndpointAddress("http://localhost:52695/KPIService.svc"); // service bağlantısı kuruyorum (Contract)
            var binding = new BasicHttpBinding();//Bağlantı binding yapıyorum
            var channel = ChannelFactory<IKPIService>.CreateChannel(binding, adress); // channel elimde kodlar olduğu için kullanıyorum. proxy elimde kodlar olmasaydı kullanırdım

            var list = channel.GetScoreCard();
            this.SCORECARD.DataSource = list.Select(c => new
            {
                c.NAME,
                VALUE = c.VALUE + " " + c.UNIT,
                PERIOD = TarihFormat(c.DATE, c.PERIOD),
                STATU = GetImage(c.STATU)
            });
            SCORECARD.DataBind();

            var genislik = 400;
            var yukseklik = 30;
            var genislikOrani = 0.2;
            foreach (var item in channel.GetGauge())
            {
                var max = Math.Max(item.TARGET_MAX, item.VALUE) * ((decimal)(1 + genislikOrani));
                var genislikLeft = Math.Round(genislik * item.TARGET_MIN / max, 0);
                var genislikNotr = Math.Round(genislik * (item.TARGET_MAX - item.TARGET_MIN) / max, 0);
                var genislikRight = genislik - genislikLeft - genislikNotr;
                var genislikValue = Math.Round(genislik * item.VALUE / max, 0);

                Table table = new Table();
                TableRow row1 = new TableRow();
                TableCell row1cell1 = new TableCell();

                row1cell1.Style.Add(HtmlTextWriterStyle.PaddingLeft, genislikValue + "px");
                row1.Cells.Add(row1cell1);
                table.Rows.Add(row1);

                TableRow row2 = new TableRow();
                TableCell row2cell1 = new TableCell();

                row2cell1.Width = Unit.Pixel((int)genislikLeft);
                row2cell1.Height = Unit.Pixel(yukseklik);
                row2cell1.BackColor = item.DIRECTION == Direction.positive ? Color.Green : Color.Red;
                row2.Cells.Add(row2cell1);

                TableCell row2cell2 = new TableCell();

                row2cell2.Width = Unit.Pixel((int)genislikNotr);
                //row2cell2.Height = Unit.Pixel(yukseklik);
                row2cell2.BackColor = Color.Yellow;
                row2.Cells.Add(row2cell2);


                TableCell row2cell3 = new TableCell();

                row2cell3.Width = Unit.Pixel((int)genislikRight);
                //row2cell2.Height = Unit.Pixel(yukseklik);
                row2cell3.BackColor = row2cell1.BackColor == Color.Red ? Color.Green : Color.Red;
                row2.Cells.Add(row2cell3);

                table.Rows.Add(row2);
                TableRow row3 = new TableRow();
                TableCell row3cell1 = new TableCell();
                row3cell1.HorizontalAlign = HorizontalAlign.Center;
                row3cell1.Text = item.NAME;
                row2.Cells.Add(row3cell1);
                table.Rows.Add(row3);
            }
        }

        private string TarihFormat(DateTime date, Period period)
        {
            if (period == Period.Year)
            {
                return date.Year.ToString();
            }
            if (period == Period.Month)
            {
                return date.Month + "/" + date.Year;
            }

            return date.Day + "/" + date.Month + "/" + date.Year;

        }

        protected string GetImage(Statu statu)
        {
            if (statu == Statu.Bad) return "~/image/kirmizi.gif";
            if (statu == Statu.Good) return "~/image/yesil.gif";
            return "~/image/sari.gif";
        }
    }
}
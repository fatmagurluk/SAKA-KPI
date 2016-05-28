using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using SAKA.Service.Contract;
using SAKA.DTO;

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
                STATU= c.STATU
            });
            SCORECARD.DataBind();


            //Response.Write(list);
            //bunları yazdıktan sonra kodları kullanabilirim

            //var count = channel.count();

            //var sum = channel.sum();

            //Response.Write(count);

            //Response.Write(" "+sum);

            //var kpiName = channel.AppKpi();

            //Response.Write(kpiName);
        }

        private string TarihFormat(DateTime date, Period period)
        {
            // periodda gün mü ay mı yıl mı
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
    }
}
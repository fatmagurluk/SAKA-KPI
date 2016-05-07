using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using SAKA.Service.Contract;

namespace SAKA.Web.UI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ABC (Adres Binding Contract)

            var adress = new EndpointAddress("http://localhost:52695/KPIService.svc"); // service bağlantısı kuruyorum (Contract)
            var binding = new BasicHttpBinding();//Bağlantı binding yapıyorum
            var channel = ChannelFactory<IKPIService>.CreateChannel(binding, adress); // channel elimde kodlar olduğu iiçn kullanıyorum. proxy elimde kodlar olmasaydı kullanırdım

            //bunları yazdıktan sonra kodları kullanabilirim

            var count = channel.count();

            Response.Write(count);
        }
    }
}
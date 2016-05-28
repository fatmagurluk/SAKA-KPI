using SAKA.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;

namespace SAKA.WEBUIMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var adress = new EndpointAddress("http://localhost:52695/KPIService.svc"); // service bağlantısı kuruyorum (Contract)
            var binding = new BasicHttpBinding();//Bağlantı binding yapıyorum
            var channel = ChannelFactory<IKPIService>.CreateChannel(binding, adress); // channel elimde kodlar olduğu için kullanıyorum. proxy elimde kodlar olmasaydı kullanırdım

            var list = channel.GetScoreCard();

            ViewBag.ScoreList = channel.GetScoreCard();
           
            return View();
        }
    }
}
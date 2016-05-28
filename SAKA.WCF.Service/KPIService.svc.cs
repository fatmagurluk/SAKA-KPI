﻿using SAKA.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SAKA.Bussiness;
using SAKA.DTO;

namespace SAKA.WCF.Service // IKPIServices 'ı burada kullanıyoruz
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "KPIService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select KPIService.svc or KPIService.svc.cs at the Solution Explorer and start debugging.
    public class KPIService : IKPIService
    {

        public DTO_ScoreCard[] GetScoreCard()
        {
            return Kpi.GetScoreCard();
        }
        public DTO_Gauge[] GetGauge()
        {
            return Kpi.GetGauge();
        }       
    }
}

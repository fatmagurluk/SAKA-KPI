using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using SAKA.DTO;

namespace SAKA.Service.Contract
{
    [ServiceContract] // anlaşma kağıdım
    public interface IKPIService // Business ' i imzalamak zorundayım
    {
        [OperationContract]
       DTO_ScoreCard[] GetScoreCard();
        [OperationContract]
        DTO_Gauge[] GetGauge();
    //{
    //    [OperationContract] // 
    //    int count();

    //    [OperationContract]
    //    int sum();

    //    [OperationContract]
    //    string AppKpi();
    }
}

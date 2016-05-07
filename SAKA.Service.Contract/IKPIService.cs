using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace SAKA.Service.Contract
{
    [ServiceContract] // anlaşma kağıdım
    public interface IKPIService // Business ' i imzalamak zorundayım
    {
        [OperationContract] // 
        int count();
    }
}

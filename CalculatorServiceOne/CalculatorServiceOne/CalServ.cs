using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CalculatorServiceOne
{
    [ServiceContract]
    public interface CalServ
    {
        [OperationContract]
        int add(Int32 a, Int32 b);
        [OperationContract]
        int sub(Int32 a, Int32 b);
        [OperationContract]
        int mul(Int32 a, Int32 b);
        [OperationContract]
        int div(Int32 a, Int32 b);
    }

}

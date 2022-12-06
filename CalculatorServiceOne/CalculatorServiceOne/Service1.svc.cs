using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CalculatorServiceOne;

namespace CalculatorServiceOne
{
    public class Service1 : CalServ
    {
        public int add(Int32 a, Int32 b)
        {
            return a + b;
        }
        public int sub(Int32 a, Int32 b)
        {
            return a - b;
        }
        public int mul(Int32 a, Int32 b)
        {
            return a * b;
        }
        public int div(Int32 a, Int32 b)
        {
            return a / b;
        }
    }
}

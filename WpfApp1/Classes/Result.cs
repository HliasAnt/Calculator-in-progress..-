using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Result
    {
        //store the result
        double StoreTheResult;
        public double ResultOfCalculations(double lastResult)
        {
            StoreTheResult = lastResult;
            return StoreTheResult;
        }


    }
}

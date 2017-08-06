using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class DoMaths
    {
        Result myResult = new Result();
        double lastResult;

        
        
        public double DoCalculations(string mySymbol,double currentNumber)

        {
            switch (mySymbol) 
            {
                case "+":
                    lastResult = myResult.ResultOfCalculations(lastResult);
                    lastResult += currentNumber;
                    return myResult.ResultOfCalculations(lastResult);

                case "-":
                    lastResult = myResult.ResultOfCalculations(lastResult);
                    lastResult -= currentNumber;
                    return myResult.ResultOfCalculations(lastResult);

                case "*":
                    lastResult = lastResult * currentNumber;
                    return lastResult;
                
                case "/":
                    lastResult = lastResult / currentNumber;
                    return lastResult;
                default:

                    return currentNumber;
            }
        }

        //reset the result value to 0
        public void ResetResult()
        {
            lastResult = 0;
            myResult.ResultOfCalculations(lastResult);
        }




    }
}

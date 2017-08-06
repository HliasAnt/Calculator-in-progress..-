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

        
        
        public double DoCalculations(string mySymbol,double currentNumber,bool newEntry)

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
                    if (newEntry)
                    {
                        lastResult = Math.Abs(lastResult);
                    }
                        return myResult.ResultOfCalculations(lastResult);
                    
                    

                case "*":
                    lastResult = myResult.ResultOfCalculations(lastResult);
                    if (newEntry)
                    {
                        lastResult = currentNumber;
                    }
                    else
                    {
                        lastResult = lastResult * currentNumber;
                    }
                    
                    return myResult.ResultOfCalculations(lastResult);

                case "/":
                    lastResult = myResult.ResultOfCalculations(lastResult);
                    if (newEntry)
                    {
                        lastResult = currentNumber;
                    }
                    else
                    {
                        lastResult = lastResult / currentNumber;
                    }
                    return myResult.ResultOfCalculations(lastResult);

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

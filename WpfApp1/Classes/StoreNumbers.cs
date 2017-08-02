using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class StoreNumbers
    {
        //add every number we press on textbox1
        public double GetTheNumber(double buttonNumber)
        {
            return buttonNumber;
        }

        //save every time we press a number all the textbox1 to keep track of the total number before the calculation
       public double StoreTheNumber(string TextBoxNumber)
        {
            double convertTheString = double.Parse(TextBoxNumber);
            return convertTheString;
        }

        public char StoreTheSymbol(char previousSymbol)
        {
            return previousSymbol;
        }

        //saves the last result number before the next math
        public double StoreThe2ndNumber(double StoreBoxNumber)
        {
            double keepTheResult = StoreBoxNumber;
            return keepTheResult;
        }


        
    }
}

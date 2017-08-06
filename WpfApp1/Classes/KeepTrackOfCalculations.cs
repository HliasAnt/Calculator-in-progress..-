using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class KeepTrackOfCalculations
    {
        //every time we press a sumbol for calculatation it saves all the maths that we have made in textbox2
        public string AddCalculationsToStoreBox(string keepTrack)
        {
            return keepTrack;
        }

        //check if the last char that we press is a symbol (we do that to clear the textblock after we press a math symbol)
        bool checkText;
        public bool CheckLastChar(string keepTrack)
        {
            string[] mySymbols = {"+","-","*","/"};
            

            foreach (string item in mySymbols)
            {
                if (keepTrack == item)
                {
                    checkText = true;
                    break;
                }
                else
                {
                    checkText = false;
                    
                }
            }

            return checkText;
        }


    }
}

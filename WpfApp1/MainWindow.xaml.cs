using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        StoreNumbers storeNumbers = new StoreNumbers();
        KeepTrackOfCalculations keeptrackofCalculations = new KeepTrackOfCalculations();
        DoMaths doMaths = new DoMaths();
        string keyPress;
        double currentNumber;
        string lastPressedSymbol;
        string lastPressedValue;
        bool newEntry = true; // its true only at the start of the program until we do our first calculation
        
        //run the checklastchar method to see if its true or false, to clear or not the textblock.
        private void CheckLastChar()
        {
            if (keeptrackofCalculations.CheckLastChar(lastPressedValue))
            {
                DisplayBox.Text = null;
            }
        }

        //reset all values to defaults
        private void ClearEverything()
        {
            DisplayBox.Text = null;
            currentNumber = 0;
            lastPressedSymbol = null;
            DisplayBox2.Text = null;
            doMaths.ResetResult();
            newEntry = true;
        }
        //it loads all values,writing the textblocks, call the domaths
        private void LoadAllValuesAndCalculatate()
        {
            DisplayBox2.Text += keeptrackofCalculations.AddCalculationsToStoreBox(DisplayBox.Text);
            DisplayBox2.Text += " " + keyPress + " ";
            if (newEntry)
            {
                DisplayBox.Text = doMaths.DoCalculations(keyPress, currentNumber,newEntry).ToString();
                newEntry = false;
            }
            else
            {
                DisplayBox.Text = doMaths.DoCalculations(lastPressedSymbol, currentNumber,newEntry).ToString();
            }
            lastPressedSymbol = keyPress;
            lastPressedValue = keyPress;
        }

        //checks and display the button that we clicked
        private void buttonNumber_Click(object sender, RoutedEventArgs e)
        {
            Button numbersButton = (Button)sender;
            string buttonValue = numbersButton.Content.ToString();
            CheckLastChar();
            lastPressedValue = buttonValue;
            DisplayBox.Text += storeNumbers.GetTheNumber(buttonValue);
            currentNumber = storeNumbers.StoreTheNumber(DisplayBox.Text);
            
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            ClearEverything();
        }

        private void buttonDel_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayBox.Text.Length>1)
            {
                DisplayBox.Text = DisplayBox.Text.Substring(0, DisplayBox.Text.Length - 1);
                currentNumber = storeNumbers.StoreTheNumber(DisplayBox.Text);
            }
            else
            {
                DisplayBox.Text = null;
            }
        }


        private void buttonSub_Click(object sender, RoutedEventArgs e)
        {
            keyPress = "-";
            LoadAllValuesAndCalculatate();
        }

        private void buttonPlus_Click_1(object sender, RoutedEventArgs e)
        {
            keyPress = "+";
            LoadAllValuesAndCalculatate();
           
        }

        private void buttonDiv_Click(object sender, RoutedEventArgs e)
        {
            keyPress = "/";
            LoadAllValuesAndCalculatate();

        }

        private void buttonMulti_Click(object sender, RoutedEventArgs e)
        {
            keyPress = "*";
            LoadAllValuesAndCalculatate();
        }

        private void buttonResult_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox2.Text = "";
            DisplayBox.Text = doMaths.DoCalculations(lastPressedSymbol, currentNumber,newEntry).ToString();
            currentNumber = storeNumbers.StoreTheNumber(DisplayBox.Text);
            lastPressedSymbol = "=";
        }

      
    }
}

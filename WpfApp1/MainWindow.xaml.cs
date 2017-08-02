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

        StoreNumbers myStoreNumbers = new StoreNumbers();
        KeepTrackOfCalculations myCalculations = new KeepTrackOfCalculations();
        DoMaths letsCalculate = new DoMaths();
        double lastResult;


        private void button1_Click(object sender, RoutedEventArgs e)
        {

            DisplayBox.Text += myStoreNumbers.GetTheNumber(1).ToString();
            myStoreNumbers.StoreTheNumber(DisplayBox.Text);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text += myStoreNumbers.GetTheNumber(2).ToString();
            myStoreNumbers.StoreTheNumber(DisplayBox.Text);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text += myStoreNumbers.GetTheNumber(3).ToString();
            myStoreNumbers.StoreTheNumber(DisplayBox.Text);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text += myStoreNumbers.GetTheNumber(4).ToString();
            myStoreNumbers.StoreTheNumber(DisplayBox.Text);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text += myStoreNumbers.GetTheNumber(5).ToString();
            myStoreNumbers.StoreTheNumber(DisplayBox.Text);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text += myStoreNumbers.GetTheNumber(6).ToString();
            myStoreNumbers.StoreTheNumber(DisplayBox.Text);
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text += myStoreNumbers.GetTheNumber(7).ToString();
            myStoreNumbers.StoreTheNumber(DisplayBox.Text);
        }

        private void button18_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text += myStoreNumbers.GetTheNumber(8).ToString();
            myStoreNumbers.StoreTheNumber(DisplayBox.Text);
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text += myStoreNumbers.GetTheNumber(9).ToString();
            myStoreNumbers.StoreTheNumber(DisplayBox.Text);
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text += myStoreNumbers.GetTheNumber(0).ToString();
            myStoreNumbers.StoreTheNumber(DisplayBox.Text);
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            DisplayBox.Text = null;
            myStoreNumbers.StoreTheNumber(DisplayBox.Text);
        }

        private void buttonDel_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayBox.Text.Length>1)
            {
                DisplayBox.Text = DisplayBox.Text.Substring(0, DisplayBox.Text.Length - 1);
                myStoreNumbers.StoreTheNumber(DisplayBox.Text);
            }
            else
            {
                DisplayBox.Text = null;
            }
        }

       /* private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
          
        }*/

        private void buttonDiv_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("dasdsa");
        }

        private void buttonPlus_Click_1(object sender, RoutedEventArgs e)
        {

           lastResult = myStoreNumbers.StoreThe2ndNumber(myStoreNumbers.StoreTheNumber(DisplayBox.Text));
           DisplayBox2.Text += myCalculations.AddCalculationsToStoreBox(DisplayBox.Text) + " +";
           letsCalculate.DoCalculations('+',lastResult,DisplayBox.Text);
            
        }
    }
}

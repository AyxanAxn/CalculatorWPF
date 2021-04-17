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
using static CalculatorWPF.Operation;

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        bool b = false;
        string operand = "";
        int countOfOperant = 0;
        double result = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickOnNumbers(object sender, RoutedEventArgs e)
        {


        }

        private void ClickOnOperations(object sender, RoutedEventArgs e)
        {
            b = true;
            Button button = (Button)sender;
            string newOperand = button.Content.ToString();
            ResultTxtblck.Text = ResultTxtblck.Text + " " + newOperand + " ";
           operand =button.Content.ToString();
            switch (operand)
            {
                case "+":
                    ResultTxtb.Text = (result + Double.Parse(ResultTxtb.Text)).ToString();
                    break;
                case "-":
                    ResultTxtb.Text = (result - Double.Parse(ResultTxtb.Text)).ToString();
                    break;
                case "*":
                    ResultTxtb.Text = (result * Double.Parse(ResultTxtb.Text)).ToString();
                    break;
                case "/":
                    ResultTxtb.Text = (result / Double.Parse(ResultTxtb.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(ResultTxtb.Text);
            operand = newOperand;
        }


        private void ClickOnClearBtn(object sender, RoutedEventArgs e)
        {
            ResultTxtb.Clear();
            ResultTxtblck.Text = "";
            result = 0;
            operand = "";
        }

        private void ClickOnDeleteBtn(object sender, RoutedEventArgs e)
        {
            string sTxtb = ResultTxtb.Text;
            string sTxtblck = ResultTxtblck.Text;

            if (sTxtb.Length > 1 && sTxtblck.Length > 1)
            {
                sTxtb = sTxtb.Substring(0, sTxtb.Length - 1);
                sTxtblck = sTxtblck.Substring(0, sTxtblck.Length - 1);

            }
            else
            {
                sTxtb = "0";
                sTxtblck = "0";
            }
            ResultTxtb.Text = sTxtb;
            ResultTxtblck.Text = sTxtblck;
        }

        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultTxtblck.Text = "";
            b = true;
            switch (operand)
            {
                case "+":
                    ResultTxtb.Text = (result + Double.Parse(ResultTxtb.Text)).ToString();
                    break;
                case "-":
                    ResultTxtb.Text = (result - Double.Parse(ResultTxtb.Text)).ToString();
                    break;
                case "*":
                    ResultTxtb.Text = (result * Double.Parse(ResultTxtb.Text)).ToString();
                    break;
                case "/":
                    ResultTxtb.Text = (result / Double.Parse(ResultTxtb.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(ResultTxtb.Text);
            ResultTxtb.Text = result.ToString();
            result = 0;
            operand = "";
        }

        private void sqrtBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deleteallBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultTxtb.Clear();
            ResultTxtblck.Text = "";
            result = 0;
            operand = "";
        }

        private void deleteOneBtn_Click(object sender, RoutedEventArgs e)
        {
            string sTxtb = ResultTxtb.Text;
            string sTxtblck = ResultTxtblck.Text;

            if (sTxtb.Length > 1 && sTxtblck.Length > 1)
            {
                sTxtb = sTxtb.Substring(0, sTxtb.Length - 1);
                sTxtblck = sTxtblck.Substring(0, sTxtblck.Length - 1);

            }
            else
            {
                sTxtb = "0";
                sTxtblck = "0";
            }
            ResultTxtb.Text = sTxtb;
            ResultTxtblck.Text = sTxtblck;
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void percentBtn_Click(object sender, RoutedEventArgs e)
        {

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ResultTxtblck.Text.StartsWith("0"))
            {
                ResultTxtblck.Clear();
            }
            
            Button button = (Button)sender;
            string newOperand = button.Content.ToString();
            ResultTxtblck.Text = ResultTxtblck.Text + " " + newOperand + " ";

            if (countOfOperant == 0)
            {

                switch (operand)
                {
                    case "+":
                        countOfOperant++;
                        ResultTxtb.Text = (result + Double.Parse(ResultTxtb.Text)).ToString();
                        break;
                    case "-":
                        countOfOperant++;
                        ResultTxtb.Text = (result - Double.Parse(ResultTxtb.Text)).ToString();
                        break;
                    case "*":
                        countOfOperant++;
                        ResultTxtb.Text = (result * Double.Parse(ResultTxtb.Text)).ToString();
                        break;
                    case "/":
                        countOfOperant++;
                        ResultTxtb.Text = (result / Double.Parse(ResultTxtb.Text)).ToString();
                        break;
                    default:
                        break;
                }
                result = Double.Parse(ResultTxtb.Text);
                ResultTxtb.Text = "";
                operand = newOperand;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (ResultTxtb.Text == "0" || b) { ResultTxtb.Clear(); }
            if (ResultTxtblck.Text.StartsWith("0")) { ResultTxtblck.Clear(); }
            Button button = (Button)sender;
            ResultTxtb.Text += button.Content;
            ResultTxtblck.Text += button.Content;

            b = false;
        }

    }
}

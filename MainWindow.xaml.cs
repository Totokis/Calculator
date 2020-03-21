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
using System.Globalization;
using System.Threading;

namespace Calculator
{
    /// <summary>flo
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
   //TODOMetody szablonowe, oraz Strategia by uporządkować
    public partial class MainWindow : Window
    {
       

        private double wynik = 0;
        private double number1 = 0.0f;
        private double number2 = 0.0f;
        private string entry = "";
        private string operation = "";
        private int value; //content
        private bool is_coma1 = false;
        private bool is_coma2 = false;
        private string str_number1 = "";
        private string str_number2 = "";
        private string coma_or_dot = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToString();



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            str_number1 = "";
            str_number2 = "";
            number1 = 0;
            number2 = 0;
            operation = "";
            textBox.Text = 0.ToString();
            Update();
        }
        private void Update()
        {

            if (operation == "")
            {
                textBox.Text = str_number1;
            }
            else
            {
                textBox.Text = str_number2;
            }

            texBoxDev_1.Text = str_number1;
            texBoxDev_2.Text = str_number2; 
        }

        private void Which(string value)
        {
            if (operation == "")
            {
                if (is_coma1)
                {
                    str_number1 = str_number1 + value;

                }
                else
                    str_number1 = str_number1 + value;
            }
            else
            {
                str_number2 = str_number2 + value;
            }
                
        }
        private void Check()
        {
            if (operation == "")
            {
                if (double.Parse(str_number1) > double.MaxValue || double.Parse(str_number1) < double.MinValue)
                {
                    textBox.Text = "Out of range";
                }
            }
            else
            {
                if (double.Parse(str_number2) > double.MaxValue || double.Parse(str_number2) < double.MinValue)
                {
                    textBox.Text = "Out of range";
                }
            }
        }
        private void button_action(string str)
        {
            Which(str);
            Update();
            Check();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            button_action(btn1.Content.ToString());
        }
    

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            button_action(btn2.Content.ToString());
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            button_action(btn3.Content.ToString());
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            button_action(btn4.Content.ToString());
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            button_action(btn5.Content.ToString());
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            button_action(btn6.Content.ToString());
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            button_action(btn7.Content.ToString());
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            button_action(btn8.Content.ToString());
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            button_action(btn9.Content.ToString());
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            button_action(btn0.Content.ToString());
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if(str_number1 != "")
            {
                operation = "+";
                textBox.Text = "0".ToString();
            }
      
        }
        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (str_number1 != "")
            {
                operation = "-";
                textBox.Text = "0".ToString();
            }

        }

        
        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (str_number1 != "")
            {
                operation = "*";
                textBox.Text = "0".ToString();
            }

        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (str_number1 != "")
            {
                operation = "/";
                textBox.Text = "0".ToString();
            }

        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)//nieczytelne i głupieTODOpoprawić
        {
            if(operation == "+")
            {
                if (str_number1 == "" || str_number1 == coma_or_dot)
                {
                    str_number1 = "0";
                }
                else
                {
                    if (str_number1[str_number1.Length - 1].ToString() == coma_or_dot)
                        number1 = double.Parse(str_number1.Remove(str_number1.Length - 1, 1));
                    else
                        number1 = double.Parse(str_number1);
                }
                if (str_number2 == "" || str_number2 == coma_or_dot)
                {
                    str_number2 = "0";

                }
                else
                {
                    if (str_number2[str_number2.Length - 1].ToString() == coma_or_dot)
                        number2 = double.Parse(str_number2.Remove(str_number2.Length - 1, 1));
                    else
                        number2 = double.Parse(str_number2);

                }



                double wynik = number1 + number2;

                int precision = 0;
                if (wynik.ToString().Contains(coma_or_dot))
                {
                    string str = (wynik - Math.Truncate(wynik)).ToString();
                    precision = str.Length - 2;
                    if (precision > 10)
                        precision = 10;
                }

                textBox.Text = wynik.ToString($"N{precision}");
                str_number1 = wynik.ToString($"N{precision}");
                if(str_number1.Contains(coma_or_dot))
                {
                    str_number2 = "";
                    number2 = 0;
                    operation = "";
                    is_coma2 = false;
                }
                else
                {
                    str_number2 = "";
                    number2 = 0;
                    operation = "";
                    is_coma1 = false;
                    is_coma2 = false;
                }
               
            }
            else if (operation == "-")
            {
                if (str_number1 == "" || str_number1 == coma_or_dot)
                {
                    str_number1 = "0";
                }
                else
                {
                    if (str_number1[str_number1.Length - 1].ToString() == coma_or_dot)
                        number1 = double.Parse(str_number1.Remove(str_number1.Length - 1, 1));
                    else
                        number1 = double.Parse(str_number1);
                }
                if (str_number2 == "" || str_number2 == coma_or_dot)
                {
                    str_number2 = "0";

                }
                else
                {
                    if (str_number2[str_number2.Length - 1].ToString() == coma_or_dot)
                        number2 = double.Parse(str_number2.Remove(str_number2.Length - 1, 1));
                    else
                        number2 = double.Parse(str_number2);

                }

                double wynik = number1 - number2;
                int precision = 0;
                if (wynik.ToString().Contains(coma_or_dot))
                {
                    string str = (wynik - Math.Truncate(wynik)).ToString();
                    precision = str.Length -2;
                    if (precision > 10)
                        precision = 10;
                }
                textBox.Text = wynik.ToString($"N{precision}");
                str_number1 = wynik.ToString($"N{precision}");
                if (str_number1.Contains(coma_or_dot))
                {
                    str_number2 = "";
                    number2 = 0;
                    operation = "";
                    is_coma2 = false;
                }
                else
                {
                    str_number2 = "";
                    number2 = 0;
                    operation = "";
                    is_coma1 = false;
                    is_coma2 = false;
                }

            }
            else if (operation == "/")
            {
                if (str_number1 == "" || str_number1 == coma_or_dot)
                {
                    str_number1 = "0";
                }
                else
                {
                    if (str_number1[str_number1.Length - 1].ToString() == coma_or_dot)
                        number1 = double.Parse(str_number1.Remove(str_number1.Length - 1, 1));
                    else
                        number1 = double.Parse(str_number1);
                }
                if (str_number2 == "" || str_number2 == coma_or_dot)
                {
                    str_number2 = "0";

                }
                else
                {
                    if (str_number2[str_number2.Length - 1].ToString() == coma_or_dot)
                        number2 = double.Parse(str_number2.Remove(str_number2.Length - 1, 1));
                    else
                        number2 = double.Parse(str_number2);

                }

                if (number2 == 0)
                {
                    textBox.Text = "Dzielenie przez zero";
                    str_number2 = "";
                    number2 = 0;
                    operation = "";
                    is_coma2 = false;
                }
                else
                {
                    double wynik = number1 / number2;
                    int precision = 0;
                    if (wynik.ToString().Contains(coma_or_dot))
                    {
                        string str = (wynik - Math.Truncate(wynik)).ToString();
                        precision = str.Length - 2;
                        if (precision > 10)
                            precision = 10;
                    }
                    textBox.Text = wynik.ToString($"N{precision}");
                    str_number1 = wynik.ToString($"N{precision}");
                    if (str_number1.Contains(coma_or_dot))
                    {
                        str_number2 = "";
                        number2 = 0;
                        operation = "";
                        is_coma2 = false;
                    }
                    else
                    {
                        str_number2 = "";
                        number2 = 0;
                        operation = "";
                        is_coma1 = false;
                        is_coma2 = false;
                    }
                }

            }
            else if (operation == "*")
            {
                if (str_number1 == "" || str_number1 == coma_or_dot)
                {
                    str_number1 = "0";
                }
                else
                {
                    if (str_number1[str_number1.Length - 1].ToString() == coma_or_dot)
                        number1 = double.Parse(str_number1.Remove(str_number1.Length - 1, 1));
                    else
                        number1 = double.Parse(str_number1);
                }
                if (str_number2 == "" || str_number2 == coma_or_dot)
                {
                    str_number2 = "0";

                }
                else
                {
                    if (str_number2[str_number2.Length - 1].ToString() == coma_or_dot)
                        number2 = double.Parse(str_number2.Remove(str_number2.Length - 1, 1));
                    else
                        number2 = double.Parse(str_number2);

                }

                double wynik = number1 * number2;
                int precision = 0;
                if (wynik.ToString().Contains(coma_or_dot))
                {
                    string str = (wynik - Math.Truncate(wynik)).ToString();
                    precision = str.Length -2;
                    if (precision > 10)
                        precision = 10;
                }
                textBox.Text = wynik.ToString($"N{precision}");
                str_number1 = wynik.ToString($"N{precision}");
                if (str_number1.Contains(coma_or_dot))
                {
                    str_number2 = "";
                    number2 = 0;
                    operation = "";
                    is_coma2 = false;
                }
                else
                {
                    str_number2 = "";
                    number2 = 0;
                    operation = "";
                    is_coma1 = false;
                    is_coma2 = false;
                }
            }
           
        }

        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                str_number1 = "";
                number1 = 0;
                is_coma1 = false;
            }
            else
            { 
                str_number2 = "";
                number2 = 0;
                is_coma2 = false;
            }
            textBox.Text = 0.ToString();
            Update();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            str_number1 = "";
            str_number2 = "";
            is_coma1 = false;
            is_coma2 = false;
            number1 = 0;
            number2 = 0;
            operation =  "";
            textBox.Text = 0.ToString();
            Update();
        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            
            if (operation == "")
            {
                if(str_number1=="")
                    textBox.Text = str_number1;
                else
                {
                    if (str_number1[str_number1.Length - 1].ToString() == coma_or_dot)
                    {
                        str_number1 = str_number1.Remove(str_number1.Length - 1, 1);
                        textBox.Text = str_number1;
                        is_coma1 = false;
                    }
                    else
                    {
                        str_number1 = str_number1.Remove(str_number1.Length - 1, 1);
                        textBox.Text = str_number1;
                    }
                }
            }
            else
            {
                if(str_number2=="")
                    textBox.Text = str_number2;
                else
                {

                    if (str_number2[str_number2.Length - 2].ToString() == coma_or_dot)
                    {
                        str_number2 = str_number2.Remove(str_number2.Length - 1, 1);
                        textBox.Text = str_number2;
                        is_coma2 = false;
                    }
                    else
                    {
                        str_number2 = str_number2.Remove(str_number2.Length - 1, 1);
                        textBox.Text = str_number2;
                    }
                }
            }
            Update();
        }

        private void btnReverse_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = double.Parse(str_number1);
                number1 = number1 * -1;
                str_number1 = number1.ToString();
                textBox.Text = str_number1;
            }
            else
            {
                number2 = double.Parse(str_number1);
                number2 = number2 * -1;
                str_number2 = number2.ToString();
                textBox.Text = str_number2;
            }
        }

        private void btnComa_Click(object sender, RoutedEventArgs e)
        {
            if (str_number1.Contains(coma_or_dot)&&!str_number2.Contains(coma_or_dot))
            {
                if (operation == "")
                {
                    textBox.Text = str_number1;
                }
                else
                {
                    is_coma2 = true;
                    str_number2 += coma_or_dot;
                    textBox.Text = str_number2;
                }
            }
            else if(str_number2.Contains(coma_or_dot))
            {
                if (operation == "")
                {
                    str_number1 += coma_or_dot;
                    textBox.Text = str_number1;
                }
                else
                {
                    textBox.Text = str_number2;
                }
            }
            else
            {
                if (operation == "")
                {
                    is_coma1 = true;
                    str_number1 += coma_or_dot;
                    textBox.Text = str_number1;
                }
                else
                {
                    is_coma2 = true;
                    str_number2 += coma_or_dot;
                    textBox.Text = str_number2;
                }
            }
            Update();
        }
    }
}

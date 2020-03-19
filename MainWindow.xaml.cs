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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private long number1 = 0;
        private long number2 = 0;
        private string operation = "";
        private int value; //content
        private bool is_coma1 = false;
        private bool is_coma2 = false;
        private string str_number1 = "";
        private string str_number2 = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Update()
        {
            texBoxDev_1.Text = str_number1 + "_" + number1.ToString();
            texBoxDev_2.Text = str_number2 + "_" + number2.ToString();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if(number1> (long.MaxValue/10) || number2 > (long.MaxValue/10))
            {
                textBox.Text = "Out of range".ToString();
            }
            else if(operation == "")
            {
                if(!is_coma1)
                {
                    number1 = (number1 * 10) + 1;
                    textBox.Text = number1.ToString();
                }
                else
                {
                    number1 = (number1 * 10) + 1;
                    textBox.Text = str_number1 + number1.ToString();
                }
            }
            else
            {
                if (!is_coma2)
                {
                    number2 = (number2 * 10) + 1;
                    textBox.Text = number2.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 1;
                    textBox.Text = str_number2 + number2.ToString();
                }
            }
            Update();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (number1 > (long.MaxValue / 10) || number2 > (long.MaxValue / 10))
            {
                textBox.Text = "Out of range".ToString();
            }
            else if (operation == "")
            {
                if (!is_coma1)
                {
                    number1 = (number1 * 10) + 2;
                    textBox.Text = number1.ToString();
                }
                else
                {
                    number1 = (number1 * 10) + 2;
                    textBox.Text = str_number1 + number1.ToString();
                }
            }
            else
            {
                if (!is_coma2)
                {
                    number2 = (number2 * 10) + 2;
                    textBox.Text = number2.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 2;
                    textBox.Text = str_number2 + number2.ToString();
                }
            }
            Update();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (number1 > (long.MaxValue / 10) || number2 > (long.MaxValue / 10))
            {
                textBox.Text = "Out of range".ToString();
            }
            else if (operation == "")
            {
                if (!is_coma1)
                {
                    number1 = (number1 * 10) + 3;
                    textBox.Text = number1.ToString();
                }
                else
                {
                    number1 = (number1 * 10) + 3;
                    textBox.Text = str_number1 + number1.ToString();
                }
            }
            else
            {
                if (!is_coma2)
                {
                    number2 = (number2 * 10) + 3;
                    textBox.Text = number2.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 3;
                    textBox.Text = str_number2 + number2.ToString();
                }
            }
            Update();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (number1 > (long.MaxValue / 10) || number2 > (long.MaxValue / 10))
            {
                textBox.Text = "Out of range".ToString();
            }
            else if (operation == "")
            {
                if (!is_coma1)
                {
                    number1 = (number1 * 10) + 4;
                    textBox.Text = number1.ToString();
                }
                else
                {
                    number1 = (number1 * 10) + 4;
                    textBox.Text = str_number1 + number1.ToString();
                }
            }
            else
            {
                if (!is_coma2)
                {
                    number2 = (number2 * 10) + 4;
                    textBox.Text = number2.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 4;
                    textBox.Text = str_number2 + number2.ToString();
                }
            }
            Update();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (number1 > (long.MaxValue / 10) || number2 > (long.MaxValue / 10))
            {
                textBox.Text = "Out of range".ToString();
            }
            else if (operation == "")
            {
                if (!is_coma1)
                {
                    number1 = (number1 * 10) + 5;
                    textBox.Text = number1.ToString();
                }
                else
                {
                    number1 = (number1 * 10) + 5;
                    textBox.Text = str_number1 + number1.ToString();
                }
            }
            else
            {
                if (!is_coma2)
                {
                    number2 = (number2 * 10) + 5;
                    textBox.Text = number2.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 5;
                    textBox.Text = str_number2 + number2.ToString();
                }
            }
            Update();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (number1 > (long.MaxValue / 10) || number2 > (long.MaxValue / 10))
            {
                textBox.Text = "Out of range".ToString();
            }
            else if (operation == "")
            {
                if (!is_coma1)
                {
                    number1 = (number1 * 10) + 6;
                    textBox.Text = number1.ToString();
                }
                else
                {
                    number1 = (number1 * 10) + 6;
                    textBox.Text = str_number1 + number1.ToString();
                }
            }
            else
            {
                if (!is_coma2)
                {
                    number2 = (number2 * 10) + 6;
                    textBox.Text = number2.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 6;
                    textBox.Text = str_number2 + number2.ToString();
                }
            }
            Update();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (number1 > (long.MaxValue / 10) || number2 > (long.MaxValue / 10))
            {
                textBox.Text = "Out of range".ToString();
            }
            else if (operation == "")
            {
                if (!is_coma1)
                {
                    number1 = (number1 * 10) + 7;
                    textBox.Text = number1.ToString();
                }
                else
                {
                    number1 = (number1 * 10) + 7;
                    textBox.Text = str_number1 + number1.ToString();
                }
            }
            else
            {
                if (!is_coma2)
                {
                    number2 = (number2 * 10) + 7;
                    textBox.Text = number2.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 7;
                    textBox.Text = str_number2 + number2.ToString();
                }
            }
            Update();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (number1 > (long.MaxValue / 10) || number2 > (long.MaxValue / 10))
            {
                textBox.Text = "Out of range".ToString();
            }
            else if (operation == "")
            {
                if (!is_coma1)
                {
                    number1 = (number1 * 10) + 8;
                    textBox.Text = number1.ToString();
                }
                else
                {
                    number1 = (number1 * 10) + 8;
                    textBox.Text = str_number1 + number1.ToString();
                }
            }
            else
            {
                if (!is_coma2)
                {
                    number2 = (number2 * 10) + 8;
                    textBox.Text = number2.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 8;
                    textBox.Text = str_number2 + number2.ToString();
                }
            }
            Update();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (number1 > (long.MaxValue / 10) || number2 > (long.MaxValue / 10))
            {
                textBox.Text = "Out of range".ToString();
            }
            else if (operation == "")
            {
                if (!is_coma1)
                {
                    number1 = (number1 * 10) + 9;
                    textBox.Text = number1.ToString();
                }
                else
                {
                    number1 = (number1 * 10) + 9;
                    textBox.Text = str_number1 + number1.ToString();
                }
            }
            else
            {
                if (!is_coma2)
                {
                    number2 = (number2 * 10) + 9;
                    textBox.Text = number2.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 9;
                    textBox.Text = str_number2 + number2.ToString();
                }
            }
            Update();
        }


        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (number1 > (long.MaxValue / 10) || number2 > (long.MaxValue / 10))
            {
                textBox.Text = "Out of range".ToString();
            }
            else if (operation == "")
            {
                if (!is_coma1)
                {
                    number1 = (number1 * 10);
                    textBox.Text = number1.ToString();
                }
                else
                {
                    number1 = (number1 * 10);
                    textBox.Text = str_number1 + number1.ToString();
                }
            }
            else
            {
                if (!is_coma2)
                {
                    number2 = (number2 * 10);
                    textBox.Text = number2.ToString();
                }
                else
                {
                    number2 = (number2 * 10);
                    textBox.Text = str_number2 + number2.ToString();
                }
            }
            Update();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            textBox.Text = "0".ToString();
            Update();
        }
        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            textBox.Text = "0".ToString();
            Update();
        }

        
        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            textBox.Text = "0".ToString();
            Update();
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            textBox.Text = "0".ToString();
            Update();
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "+")
            {
                if (!is_coma1 && !is_coma2)
                {
                    textBox.Text = (number1 + number2).ToString();
                }
                else if(is_coma1&&is_coma2)
                    textBox.Text = (float.Parse((str_number1 + number1.ToString())) + float.Parse(str_number2 + number2.ToString())).ToString();
                else if(is_coma1)
                    textBox.Text = (float.Parse((str_number1 + number1.ToString())) + (float)number2).ToString();
                else if(is_coma2)
                    textBox.Text = ((float)number1 + float.Parse(str_number2 + number2.ToString())).ToString();
            }
            else if (operation == "-")
            {
                if (!is_coma1 && !is_coma2)
                {
                    textBox.Text = (number1 - number2).ToString();
                }
                else if (is_coma1 && is_coma2)
                    textBox.Text = (float.Parse((str_number1 + number1.ToString())) - float.Parse(str_number2 + number2.ToString())).ToString();
                else if (is_coma1)
                    textBox.Text = (float.Parse((str_number1 + number1.ToString())) - (float)number2).ToString();
                else if (is_coma2)
                    textBox.Text = ((float)number1 - float.Parse(str_number2 + number2.ToString())).ToString();
            }
            else if (operation == "/")
            {
                if (!is_coma1 && !is_coma2)
                {
                    if (number2 == 0)
                        textBox.Text = "Nie dziel przez zero";
                    else
                        textBox.Text = ((float)number1 / (float)number2).ToString();
                }
                else if (is_coma1 && is_coma2)
                {
                    if (float.Parse(str_number2 + number2.ToString()) == 0)
                        textBox.Text = "Nie dziel prze zero";
                    else
                        textBox.Text = (float.Parse((str_number1 + number1.ToString())) / float.Parse(str_number2 + number2.ToString())).ToString();
                }
                else if (is_coma1)
                {
                    if (float.Parse(str_number2 + number2.ToString()) == 0)
                        textBox.Text = "Nie dziel prze zero";
                    else
                        textBox.Text = (float.Parse((str_number1 + number1.ToString())) / (float)number2).ToString();
                }
                else if (is_coma2)
                {
                    if (float.Parse(str_number2 + number2.ToString()) == 0)
                        textBox.Text = "Nie dziel prze zero";
                    else
                        textBox.Text = ((float)number1 / float.Parse(str_number2 + number2.ToString())).ToString();
                }
            }
            else if (operation == "*")
            {
                if (!is_coma1 && !is_coma2)
                {
                    textBox.Text = (number1 * number2).ToString();
                }
                else if (is_coma1 && is_coma2)
                    textBox.Text = (float.Parse((str_number1 + number1.ToString())) * float.Parse(str_number2 + number2.ToString())).ToString();
                else if (is_coma1)
                    textBox.Text = (float.Parse((str_number1 + number1.ToString())) * (float)number2).ToString();
                else if (is_coma2)
                    textBox.Text = ((float)number1 * float.Parse(str_number2 + number2.ToString())).ToString();
            }
            Update();
        }

        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
                str_number1 = "";
            }
            else
            {
                number2 = 0;
                str_number2 = "";
            }
            textBox.Text = 0.ToString();
            Update();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            str_number1 = "";
            str_number2 = "";
            textBox.Text = 0.ToString();
            Update();
        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1/10);
                textBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2/10);
                textBox.Text = number2.ToString();
            }
            Update();
        }

        private void btnReverse_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (!is_coma1)
                {
                    number1 = -1 * number1;
                    textBox.Text = number1.ToString();
                }
                else
                {
                    str_number1 = (-1 * int.Parse(str_number1)).ToString();
                    textBox.Text = str_number1 + number1.ToString();
                }
            }
            else
            {
                if (!is_coma2)
                {
                    number2 = -1 * number2;
                    textBox.Text = number2.ToString();
                }
                else
                {
                    str_number2 = (-1 * int.Parse(str_number2)).ToString();
                    textBox.Text = str_number2 + number2.ToString();
                }
            }
            Update();
        }

        private void btnComa_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if(!is_coma1)
                {
                    is_coma1 = true;
                    str_number1 = number1.ToString() + ",";
                    textBox.Text = str_number1;
                    number1 = 0;
                }
                else
                {
                    textBox.Text = str_number1 + number1.ToString();
                }
            }
            else
            {
                if (!is_coma2)
                {
                    is_coma2 = true;
                    str_number2 = number2.ToString() + ",";
                    textBox.Text = str_number2;
                    number2 = 0;
                }
                else
                {
                    textBox.Text = str_number2 + number2.ToString();
                }    
            }
            Update();
        }
    }
}

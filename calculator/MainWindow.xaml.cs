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

namespace calculator
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        CalcTreeGenerator G = new CalcTreeGenerator();
        MathRenderer renderer = new MathRenderer();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Input_TextChanged(object sender, RoutedEventArgs e)
        {
            Calc_node node = null;
            try
            {
                node = G.Generate(raw_input.Text);
            }
            catch (Exception)
            {

                return;
            }
            
            Canvas drawing = renderer.RenderElement(node);
            vbox.Child=drawing;
        }

        private void Input_Button_Click(object sender, RoutedEventArgs e)
        {
            int index;
            string prefix = raw_input.Text.Substring(0, index = raw_input.SelectionStart);
            string suffix = raw_input.Text.Substring(raw_input.SelectionStart);
            switch ((sender as Button).GetValue(FrameworkElement.NameProperty) as string)
            {
                
                case "input_lparen":
                    if((e as MouseButtonEventArgs).ChangedButton==MouseButton.Right)
                    {
                        raw_input.Text = prefix + (sender as Button).Content + suffix;
                    }
                    else
                    {
                        raw_input.Text = prefix + (sender as Button).Content + ")"+suffix;
                    }
                    raw_input.SelectionStart = index + (sender as Button).Content.ToString().Length;
                    break;
                case "input_0":
                case "input_1":
                case "input_2":
                case "input_3":
                case "input_4":
                case "input_5":
                case "input_6":
                case "input_7":
                case "input_8":
                case "input_9":
                case "input_div":
                case "input_add":
                case "input_minus":
                case "input_mul":
                case "input_rparen":
                case "input_dot":
                case "input_e":
                case "input_π":
                case "input_comma":
                case "input_pow":
                    raw_input.Text = prefix + (sender as Button).Content + suffix;
                    raw_input.SelectionStart = index+ (sender as Button).Content.ToString().Length;
                    break;
                case "input_sin":
                case "input_cos":
                case "input_tan":
                    raw_input.Text = prefix + (sender as Button).Content + "()" + suffix;
                    raw_input.SelectionStart = index + (sender as Button).Content.ToString().Length+1;
                    break;
                case "input_log":
                    raw_input.Text = prefix + (sender as Button).Content + "(,)" + suffix;
                    raw_input.SelectionStart = index + (sender as Button).Content.ToString().Length + 1;
                    break;
                default:
                    break;
                    
            }
            raw_input.Focus();
        }

        private void Calculate_Button_Click(object sender, RoutedEventArgs e)
        {
            
            Calc_node node = G.Generate(raw_input.Text);
            node.Calculate();
            if (node.isint)
                result_box.Text = node.result.ToString();
            else result_box.Text = node.fresult.ToString();
        }

        private void Control_Button_Click(object sender, RoutedEventArgs e)
        {
            int index;
            switch ((sender as Button).GetValue(FrameworkElement.NameProperty) as string)
            {
                case "control_left":
                    if (raw_input.SelectionStart > 0)
                    {
                        raw_input.SelectionStart -= 1;
                    }
                    break;
                case "control_right":
                    raw_input.SelectionStart += 1;
                    break;
                case "control_back":
                    index = raw_input.SelectionStart - 1;
                    if (index >= 0)
                    {
                        raw_input.Text =
                            raw_input.Text.Substring(0, index)
                            + raw_input.Text.Substring(index + 1);
                        raw_input.SelectionStart = index;
                    }
                    break;
                case "control_AC":
                    raw_input.Text = "";
                    result_box.Text = "";
                    vbox.Child = new Canvas(); // clear canvas
                    break;
                default:
                    break;

            }
            raw_input.Focus();
        }
    }
}

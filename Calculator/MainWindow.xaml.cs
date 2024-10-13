using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator;

// Handle multipleo operators
// Handle divide with 0
// Handle Keyboard input
// Optimize code layout
// Create a method for the calculator
// write xunit test.

public partial class MainWindow : Window
{
    private string _input = string.Empty;
    public MainWindow()
    {
        InitializeComponent();
        
    }
    private void MyButton_Click(object sender, RoutedEventArgs e) // needs to have the same name as the button in the XAML
    {
        Button clickedButton = sender as Button;

        if (clickedButton != null)
        {
            string buttoncontent = clickedButton.Content.ToString();

            if (buttoncontent == "CE")
            {
                _input = string.Empty;
            }
            else if(buttoncontent == "x\u00b2")
            {
                var calc = int.Parse(_input) * int.Parse(_input);
                _input = calc.ToString();
                Screen.Content = _input;
            }
            else if (buttoncontent == "=")
            {
                if (_input.Contains(","))
                {
                    var float_result = 0.0;
                    
                    if (_input.Contains("*"))
                    {
                        var numbers = _input.Split('*');
                        float_result = double.Parse(numbers[0]) * double.Parse(numbers[1]);
                    }
                    
                    else if (_input.Contains("/"))
                    {
                        var numbers = _input.Split('/');
                        float_result = double.Parse(numbers[0]) / double.Parse(numbers[1]);
                    }
                    else if (_input.Contains("+"))
                    {
                        var numbers = _input.Split('+');
                        foreach (var number in numbers)
                        {
                            float_result += double.Parse(number);
                        }
                    }
                    else if (_input.Contains("-"))
                    {
                        var numbers = _input.Split('-');
                        float_result = double.Parse(numbers[0]) - double.Parse(numbers[1]);
                    }
                    _input = float_result.ToString();
                    Screen.Content = float_result;
                    return;
                }
                else
                {
                    var result = 0;
                    if (_input.Contains("*"))
                    {
                        var numbers = _input.Split('*');
                        result = int.Parse(numbers[0]) * int.Parse(numbers[1]);
                    }
                    else if (_input.Contains("/"))
                    {
                        var numbers = _input.Split('/');
                        result = int.Parse(numbers[0]) / int.Parse(numbers[1]);
                    }
                    else if (_input.Contains("+"))
                    {
                        var numbers = _input.Split('+');
                        foreach (var number in numbers)
                        {
                            result += int.Parse(number);
                        }
                    }
                    else if (_input.Contains("-"))
                    {
                        var numbers = _input.Split('-');
                        result = int.Parse(numbers[0]) - int.Parse(numbers[1]);
                    }
                    _input = result.ToString();
                    Screen.Content = result;
                    return;
                    
                }
              
            }
            else
            {
              _input += buttoncontent;
            }

            Screen.Content = _input;
        }
        
        
    }
    private void Calculate(object sender, RoutedEventArgs e)
    {
        
        
    }
    
}
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
using System;
using System.Data;


namespace Calculator;

// Handle multiple ,,, 
// Handle Keyboard input
// Optimize code layout
// write xunit test.
// Handle that if number gets to big it will be displayed in scientific notation

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
            else if(buttoncontent == "x\u00b2") // need to fix if want to use this input is not a  number but a symbol
            {
                if (_input.Length > 0)
                {
                    try
                    {
                        var number = int.Parse(_input);
                        var calc = checked(number * number);
                        _input = calc.ToString();
                        Screen.Content = _input;
                    }
                    catch (OverflowException)
                    {
                        _input = string.Empty;
                        Screen.Content = "Error - Overflow";
                    }
                }
                else
                {
                    _input = string.Empty;
                    Screen.Content = "Error - Invalid input";
                }
            }
            else if (buttoncontent == "=")
            {
                if (_input.Contains(",,") || _input.Contains("**") || _input.Contains("//"))
                {
                    _input = string.Empty;
                    Screen.Content = "Error - Invalid input";
                    return;
                }
                try
                {
                    _input.Replace(",", ".");
                    var result = Calculate(_input);
                    _input = result.ToString();
                    Screen.Content = result;
                }
                catch (Exception)
                {
                    Screen.Content = "Error";
                }
              
            }
            else
            {
              _input += buttoncontent;
            }

            Screen.Content = _input;
        }
    }
    private object Calculate(string assigment)
    {
        var table = new DataTable();
        var result = table.Compute(assigment, "");
        // handles incase division by 0
        if (result.ToString() == "∞" || result.ToString() == "NaN")
        {
            return "Error invalid input";
        }
        return result;   
    }
}
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

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private string _input = string.Empty;
    public MainWindow()
    {
        InitializeComponent();
        
    }
    private void MyButton1_Click(object sender, RoutedEventArgs e) // needs to have the same name as the button in the XAML
    {
        _input += "1";
        Screen.Content = _input;
    }

    private void MyButton2_Click(object sender, RoutedEventArgs e) // +
    {
        _input += "2";
        Screen.Content = _input;
    }
    private void MyButton3_Click(object sender, RoutedEventArgs e)
    {
        _input += "3";
        Screen.Content = _input;
    }
    
    private void MyButton4_Click(object sender, RoutedEventArgs e)
    {
        _input += "4";
        Screen.Content = _input;
    }
    private void MyButton5_Click(object sender, RoutedEventArgs e)
    {
        _input += "5";
        Screen.Content = _input;
    }
    private void MyButton6_Click(object sender, RoutedEventArgs e)
    {
        _input += "6";
        Screen.Content = _input;
    }
    private void MyButton7_Click(object sender, RoutedEventArgs e)
    {
        _input += "7";
        Screen.Content = _input;
    }
    private void MyButton8_Click(object sender, RoutedEventArgs e)
    {
        _input += "8";
        Screen.Content = _input;
    }
    private void MyButton9_Click(object sender, RoutedEventArgs e)
    {
        _input += "9";
        Screen.Content = _input;
    }
    private void MyButtonCE_Click(object sender, RoutedEventArgs e)
    {
        _input = "";
        Screen.Content = _input;
    }
    private void MyButton0_Click(object sender, RoutedEventArgs e)
    {
        _input += "0";
        Screen.Content = _input;
    }
    private void MyButtonequal_Click(object sender, RoutedEventArgs e)
    {
        // split the string according to the operator
    }
}
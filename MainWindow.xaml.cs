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

namespace Linear_equation_in_two_unknowns;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        string inputTexta1 = inputBoxa1.Text;
        string inputTexta2 = inputBoxa2.Text;

        outputBoxa.Content = inputTexta1 + inputTexta2;
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
        About a = new About();
        a.Show();
    }
}

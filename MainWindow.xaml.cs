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
        string firstA;
        string firstB;
        string firstC;
        string firstD;

        int m;
        int n;
        int i;
        int k;
        int a;
        int b;

        string? preA;
        string? preB;
        try
        {
            firstA = (inputBoxa1.Text.Split('x'))[0]; // 第一个方程的第一项，以下三个变量如此
            firstB = (inputBoxa2.Text.Split('y'))[0];
            firstC = (inputBoxb1.Text.Split('x'))[0];
            firstD = (inputBoxb2.Text.Split('y'))[0];

            // variable[0]为数字 [1]为字母

            //debug code(one line) successful
            //DebugTest.Debug1(firstA);

            // 'a1n'：第一个方程(a)第一个项(1)的数字(n)
            m = Convert.ToInt32(firstA); //m
            n = Convert.ToInt32(firstB); //n
            i = Convert.ToInt32(firstC); //k
            k = Convert.ToInt32(firstD); //i

           preA = inputBoxa3.Text;
           preB = inputBoxb3.Text;

            a = Convert.ToInt32(preA);
            b = Convert.ToInt32(preB);

        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}\n Please input rightly");
            return;
        }

        
        int c = i - ((k * n) / m);
        int d = (k / m) * a;
        //cy+d=b -> cy=b-d -> cy=f -> y=f/c
        int f = b - d;

        int resultX = f / c;
        Result.Content = $"结果：x={resultX}, y的话……一元一次方程自己算吧（bushi";
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
        About a = new About();
        a.Show();
    }
}

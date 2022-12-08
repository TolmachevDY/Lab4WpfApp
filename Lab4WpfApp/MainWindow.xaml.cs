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

namespace Lab4WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text=resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEvro = Convert.ToDouble(rateEv.Text);
            double sumEvro = Convert.ToDouble(sumEv.Text);
            double resDouble = rateEvro * sumEvro;
            resSumEv.Text = resDouble.ToString();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGriv = Convert.ToDouble(rateGr.Text);
            double sumGriv = Convert.ToDouble(sumGr.Text);
            double resDouble = rateGriv * sumGriv;
            resSumGr.Text = resDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDrama = Convert.ToDouble(rateDr.Text);
            double sumDrama = Convert.ToDouble(sumDr.Text);
            double resDouble = rateDrama * sumDrama;
            resSumDr.Text = resDouble.ToString();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rateIn = Convert.ToDouble(rateInch.Text);
            double resDouble = rateIn * 39.37;
            resSumInch.Text = resDouble.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rateFoot = Convert.ToDouble(rateFt.Text);
            double resDouble = rateFoot * 3.28;
            resSumFt.Text = resDouble.ToString();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rateMile = Convert.ToDouble(rateMl.Text);
            double resDouble = rateMile * 0.000621;
            resSumMl.Text = resDouble.ToString();

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rateVerst = Convert.ToDouble(rateVr.Text);
            double resDouble = rateVerst * 0.000937;
            resSumVr.Text = resDouble.ToString();

        }
    }
}

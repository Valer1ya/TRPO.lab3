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
using lib2;

namespace TRPO_lab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }


        private void Result_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txt_Result.Text = (Math.Round(Math_2.Formula(Convert.ToDouble(txt_Radius.Text), Convert.ToDouble(txt_Radius1.Text), Convert.ToDouble(txt_Length.Text)), 2).ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("Число не может быть отрицательным");
            }
        }
    }
}

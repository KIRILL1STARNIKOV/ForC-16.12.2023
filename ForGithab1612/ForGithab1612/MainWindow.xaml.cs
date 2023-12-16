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

namespace ForGithab1612
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
        int check =0;
        private void Button_Click (object sender, RoutedEventArgs e)
        {
            check++;
            string ss = $"NEW element{check} ";
           listb.Items.Insert(0, ss);
                
        }
        private void Butsum_Click(object sender, RoutedEventArgs e)
        {
            int firstnumeber = Convert.ToInt32(tbfirstnumber.Text);
            int secondnumber = Convert.ToInt32(tbsecondnumber.Text);
            int result = firstnumeber + secondnumber;
            MessageBox.Show("result sum "+ result,"Messange");
        }
    }
}

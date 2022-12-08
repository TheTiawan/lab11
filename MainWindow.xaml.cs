using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace lab11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("11. Дана строка '23 2+3 2++3 2+++3 445 677'.\nНапишите регулярное выражение, которое найдет строки 23, 2+3, 2++3, 2+++3, не захватив остальные.\nДана строка '*+ *q+ *qq+ *qqq+ *qqq qqq+'.\nНапишите регулярное выражение, которое найдет строки *q+, *qq+, *qqq+, не захватив остальные");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Find_Click(object sender, RoutedEventArgs e)
        {
            //Regex regex = new("23|2[+]3|2[++]3|2[+++]3");
            Regex regex = new("23|2\\W3|2\\W\\W3|2\\W\\W\\W3");
            string s = FTextBox.Text;
            MatchCollection matches = regex.Matches(s);
            for (int i = 0; i < matches.Count; i++)
            {
                //                Match match = matches[i];
                RFTextBox.Text += matches[i].ToString() + " ";
            }
            Regex regex2 = new("[*]q[+]|[*]qq[+]|[*]qqq[+]");
            string s2 = STextBox.Text;
            MatchCollection matches2 = regex2.Matches(s2);
            for (int i = 0; i < matches2.Count; i++)
            {
                //                Match match = matches[i];
                RSTextBox.Text += matches2[i].ToString() + " ";
            }

        }
    }
}

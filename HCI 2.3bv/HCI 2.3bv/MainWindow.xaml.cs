using System;
using System.Collections.Generic;
using System.Linq;
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

namespace HCI_2._3bv
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

        

        private void kreiraj_spomenik(object sender, RoutedEventArgs e)
        {
           Window1 win1 = new Window1();
            win1.Show();
            
        }


        private void dodaj_etiketu(object sender, RoutedEventArgs e)
        {
            Window3 win3 = new Window3();
            win3.Show();
            

        }

        private void kreiraj_tip(object sender, RoutedEventArgs e)
        {
            Window2 win3 = new Window2();
            win3.Show();
            
        }
    }
}

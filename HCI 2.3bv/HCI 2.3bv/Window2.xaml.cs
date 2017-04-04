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
using System.Windows.Shapes;

namespace HCI_2._3bv
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void ponisti_tip(object sender, RoutedEventArgs e)
        {
           
            
            this.Close();
        }

       
        private void sacuvaj_tip(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sačuvan tip");
            this.Close();
        }


    }
}

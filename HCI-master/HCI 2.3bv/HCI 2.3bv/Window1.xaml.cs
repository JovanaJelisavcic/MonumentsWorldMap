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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public int id { get; set; }

        public Window1()
        {
            InitializeComponent();
            DataContext = this;
        }

       
        private void etiketa_iz_spomenika(object sender, RoutedEventArgs e)
        {
            Window3 win1 = new Window3();
            win1.Show();
            
        }

        private void ponisti_spomenik(object sender, RoutedEventArgs e)
        {
          
            this.Close();
        }

        private void sacuvaj_spomenik(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sačuvan spomenik");
            this.Close();
        }

       


        
    }
}

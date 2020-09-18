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
using System.Windows.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AnalizadorProyecto1
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private delegate void Run__();
        public Window1()
        {
            InitializeComponent();
           }
        private void Window1_load(object sender, EventArgs e)
        {
            loading();
        }
        private void loading()
        {

            new System.Threading.Thread(delegate ()
            {
                Random rand = new Random();
                System.Threading.Thread.Sleep(rand.Next(1500, 3000));
                Run__ des = new Run__(Running);
               this.Dispatcher.Invoke(des);

            }).Start();
        }


        private void Running()
        {
            MainWindow desk = new MainWindow();
            desk.Show();
            this.Hide();
        }
        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}

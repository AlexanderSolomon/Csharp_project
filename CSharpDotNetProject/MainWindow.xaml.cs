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
namespace CSharpDotNetProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            clickMe.FontSize = 50;
         
        }

      
        private void Openwindow1(object sender, RoutedEventArgs e)
        {
            Window1 sW=new Window1();
            sW.Show();
            this.Close();

        }
        private void Openwindow2ListSearch(object sender, RoutedEventArgs e)
        {
            datagrid sW = new datagrid();
            sW.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 sW = new Window2();
            sW.Show();
            this.Close();
        }
    }
}

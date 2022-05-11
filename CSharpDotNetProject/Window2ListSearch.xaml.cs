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

namespace CSharpDotNetProject
{
    /// <summary>
    /// Interaction logic for Window2ListSearch.xaml
    /// </summary>
    public partial class Window2ListSearch : Window
    {
        List<CertificateElement> elements = new List<CertificateElement>();

        public Window2ListSearch()
        {
            InitializeComponent();
            elements.Add(new CertificateElement() { serialNumber = "2520020", workShop = "Din mors auto", date = DateTime.Now });
            elements.Add(new CertificateElement() { serialNumber = "2552520", workShop = "Dekra", date = DateTime.Now });
            elements.Add(new CertificateElement() { serialNumber = "2534599", workShop = "Dekra", date = DateTime.Now });
            certificateDGrid.ItemsSource = elements;
        }
        private void searchBox_KeyUp(object sender, System.Windows.Input.KeyboardEventArgs e)
        {
            List<CertificateElement> filtered = new List<CertificateElement>(elements.Where(certificate => certificate.serialNumber.StartsWith(searchBox.Text)));
            certificateDGrid.ItemsSource = filtered;
        }
    }
    public class CertificateElement
    {
        public string serialNumber{ get; set; }
        public string workShop{ get; set; } 
        public DateTime date { get; set; }
    }
    // create database connection to get current list. 
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
using MySql.Data.MySqlClient;


namespace CSharpDotNetProject
{
    /// <summary>
    /// Interaction logic for Window2ListSearch.xaml
    /// </summary>
    public partial class Window2ListSearch : Window
    {
        string connectionstring = "server=localhost; port=3306;database=kloningsattest;uid=root;password=Oliven13";

        List<CertificateElement> elements = new List<CertificateElement>();
        public Window2ListSearch()
        {
            InitializeComponent();

            MySqlConnection connection = new MySqlConnection(connectionstring);
            MySqlCommand cmd = new MySqlCommand("select Attest_ID, Registreringsnummer, Dato FROM kloningsattest.attest_information;", connection);
            connection.Open();
            MySqlDataReader dt; 
            dt = cmd.ExecuteReader();
            connection.Close();
            if (dt.HasRows)
            {
                while (dt.Read())
                {

                }
            }
            connection.Close();
        }
        private void searchBox_KeyUp(object sender, System.Windows.Input.KeyboardEventArgs e)
        {
            ///List<CertificateElement> filtered = new List<CertificateElement>(elements.Where(certificate => certificate.serialNumber.StartsWith(searchBox.Text)));
            ///certificateDGrid.ItemsSource = filtered;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow sW = new MainWindow();
            sW.Show();
            this.Close();
        }
    }
    public class CertificateElement
    {
        public int id{ get; set; }
        public string workShop{ get; set; } 
        public DateTime date { get; set; }
    }
    // create database connection to get current list. 
}

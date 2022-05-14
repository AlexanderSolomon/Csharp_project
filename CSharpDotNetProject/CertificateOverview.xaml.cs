using MySql.Data.MySqlClient;
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
    /// Interaction logic for CertificateOverview.xaml
    /// </summary>
    public partial class CertificateOverview : Window
    {
        string connectionstring = "server=localhost; port=3306;database=kloningsattest;uid=root;password=Oliven13";
        public CertificateOverview()
        {
            InitializeComponent();
            string id = id_received.Text; 
            MySqlConnection connection = new MySqlConnection(connectionstring);
            MySqlCommand cmd = new MySqlCommand("select * FROM kloningsattest.attest_information where Attest_ID = 1;   ", connection);
            connection.Open();
            MySqlDataReader dt;
            dt = cmd.ExecuteReader();
        }
    }
}

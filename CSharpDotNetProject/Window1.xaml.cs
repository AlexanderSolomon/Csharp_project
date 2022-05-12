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
using MySql.Data.MySqlClient;
namespace CSharpDotNetProject
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        string connectionstring = "server=localhost;database=Kloningsattest;uid=root;password=gamechen0045";

        public Window1()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            string query = "INSERT INTO `bil_information` (`Registreringsnummer`,`Stelnummer`,`Mærke`,`Model`,`Version`,`Første_registrering`,`Antal_nøgler`,`Gearkassenummer`) " +
                      "VALUES(" +registreringsnummer.Text + ",'" + stelnummer.Text + "','" + mærke.Text + "','" + model.Text + "','" + version.Text + "','" + første_registrering.Text + "','" + antal_nøgler.Text + "','" + gearkassenummer.Text + "')"; 
            string query2 = "INSERT INTO `attest_information` (`DEKRA_Bilsyn`,`Rapport_udførst_af`) " +
            "VALUES(" + dekra_bilsyn.Text + ",'" + rapport_udført_af.Text + "')";

            MySqlCommand cmd = new MySqlCommand(query, connection); 
            MySqlCommand mySqlCommand = new MySqlCommand(query2,connection); 
            int value = cmd.ExecuteNonQuery();
            int value2 = mySqlCommand.ExecuteNonQuery();
            
            MessageBox.Show("Saved");
            connection.Close();
        }
    }
}

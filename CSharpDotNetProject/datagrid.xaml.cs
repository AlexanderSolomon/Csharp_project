using System.Data;
using System.Windows;
using MySql.Data.MySqlClient;


namespace CSharpDotNetProject;

public partial class datagrid : Window
{
    string connectionstring = "server=localhost;database=Kloningsattest;uid=root;password=gamechen0045";

    public datagrid()
    {
        InitializeComponent();

            MySqlConnection connection = new MySqlConnection(connectionstring);
            MySqlCommand cmd = new MySqlCommand("select * from bil_information", connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();
            dtGrid.DataContext = dt;

    }

    private void save_button_Click(object sender, RoutedEventArgs e)
    {
        MySqlConnection connection = new MySqlConnection(connectionstring);
        connection.Open();
        string query = "INSERT INTO `bil_information` (`Registreringsnummer`,`Stelnummer`) VALUES(" + Text1.Text + ",'" + Text2.Text + "')";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        int value = cmd.ExecuteNonQuery();
        MessageBox.Show(value.ToString());
        connection.Close();
    }
}
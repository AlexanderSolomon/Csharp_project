using System.Data;
using System.Windows;
using MySql.Data.MySqlClient;


namespace CSharpDotNetProject;

public partial class datagrid : Window
{
    public datagrid()
    {
        InitializeComponent();

            string connectionstring = "server=localhost;database=Kloningsattest;uid=root;password=gamechen0045";
            MySqlConnection connection = new MySqlConnection(connectionstring);
            MySqlCommand cmd = new MySqlCommand("select * from bil_information", connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();

            dtGrid.DataContext = dt;

    }
}
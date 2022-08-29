using MySql.Data.MySqlClient;
using System;
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

namespace RibbonWin
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class margin : Window
    {
        string cntstring;
        string server = "localhost";
        string database = "inventoryapp";
        string uid = "root";
        string password = "";
        MySql.Data.MySqlClient.MySqlConnection connection;

        public margin()
        {
            InitializeComponent();
            FillPlantName();
        }

        private void FillPlantName()
        {
            cntstring = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            connection = new MySql.Data.MySqlClient.MySqlConnection(cntstring);
            connection.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select Name From Plant", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("myTable");
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    Plant.Items.Add(row.ItemArray[i].ToString());
                    Plant1.Items.Add(row.ItemArray[i].ToString());
                    Plant2.Items.Add(row.ItemArray[i].ToString());
                    Plant3.Items.Add(row.ItemArray[i].ToString());
                    Plant4.Items.Add(row.ItemArray[i].ToString());

                }
            }
            Plant.SelectedIndex = -1;
            connection.Close();
        }

        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            string query2 = "INSERT INTO `partner` (`Name`, `Email`, `Id`, `Phone`,`FM`,`DS`,`MS`,`GS`,`SS`,`Hamali`,`BankComm`) VALUES ('" + ptrnametxt.Text + "', '" + ptremailrtxt.Text + "', NULL, '" + prtnumbertxt.Text + "')";
            //open connection
            cntstring = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            connection = new MySql.Data.MySqlClient.MySqlConnection(cntstring);
            connection.Open();

            //create command and assign the query and connection from the constructor
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query2, connection);


            //Execute command
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Entry Saved Sucessfully");
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

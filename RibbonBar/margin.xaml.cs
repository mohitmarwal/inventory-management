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
                    plantfm.Items.Add(row.ItemArray[i].ToString());
                    plantdm.Items.Add(row.ItemArray[i].ToString());
                    plantss.Items.Add(row.ItemArray[i].ToString());
                    plantgs.Items.Add(row.ItemArray[i].ToString());
                    plantms.Items.Add(row.ItemArray[i].ToString());

                }
            }
            plantfm.SelectedIndex = 0;
            plantdm.SelectedIndex = 0;
            plantss.SelectedIndex = 0;
            plantms.SelectedIndex = 0;
            plantgs.SelectedIndex = 0;
            connection.Close();
        }

        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            if (fmmin.Text != "" && fmmax.Text != "" && fmrate.Text != "")
            {
                string query2 = "INSERT INTO `fm` (`Min`, `Max`, `Rate`, `Plant`) VALUES ('" + fmmin.Text + "', '" + fmmax.Text + "', '" + fmrate.Text + "','" + plantfm.Text  + "')";
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
            }

            if (dmmin.Text != "" && dmmax.Text != "" && dmrate.Text != "")
            {
                string query2 = "INSERT INTO `ds` (`Min`, `Max`, `Rate`, `Plant`) VALUES ('" + dmmin.Text + "', '" + dmmax.Text + "', '" + dmrate.Text + "','" + plantdm.Text  + "')";
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
            }
            if (msmin.Text != "" && msmax.Text != "" && msmrate.Text != "")
            {
                string query2 = "INSERT INTO `ms` (`Min`, `Max`, `Rate`, `Plant`) VALUES ('" + msmin.Text + "', '" + msmax.Text + "', '" + msmrate.Text + "','" + plantms.Text  + "')";
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
            }

            if (ssmin.Text != "" && ssmax.Text != "" && ssrate.Text != "")
            {
                string query2 = "INSERT INTO `ss` (`Min`, `Max`, `Rate`, `Plant`) VALUES ('" + ssmin.Text + "', '" + ssmax.Text + "', '" + ssrate.Text + "','" + plantms.Text  + "')";
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
            }

            if (gsmin.Text != "" && gsmax.Text != "" && gsrate.Text != "")
            {
                string query2 = "INSERT INTO `gs` (`Min`, `Max`, `Rate`, `Plant`) VALUES ('" + gsmin.Text + "', '" + gsmin.Text + "', '" + gsrate.Text + "','" + plantms.Text  + "')";
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
            }
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

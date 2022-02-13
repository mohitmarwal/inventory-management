using Microsoft.Data.Sqlite;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace RibbonWin
{
    /// <summary>
    /// Interaction logic for EmployeeInfo.xaml
    /// </summary>
    public partial class EmployeeInfo : UserControl
    {


        string connetionString;
        string server = "localhost";
        string database = "test";
        string uid = "root";
        string password = "";
        MySql.Data.MySqlClient.MySqlConnection connection;
        string connectionString;
        public EmployeeInfo()
        {
            InitializeComponent();
            Fillbag();
            FillPartner();
            FillPlantName();
            FillGoods();
            FillPaymentMethod();
            date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            time.Text = DateTime.Now.TimeOfDay.ToString("hh\\:mm\\:ss");

        }
        private void Fillbag()
        {
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
             database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select Type From bags", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("myTable");
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    bagtype.Items.Add(row.ItemArray[i].ToString());

                }
            }
            bagtype.SelectedIndex = 0;
            connection.Close();
        }

        private void FillPartner()
        {
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
             database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select Name From partner", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("myTable");
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    Partnername.Items.Add(row.ItemArray[i].ToString());

                }
            }
            Partnername.SelectedIndex = 0;
            connection.Close();
        }

        private void FillGoods()
        {
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
             database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select Name From goods", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("myTable");
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    goodtype.Items.Add(row.ItemArray[i].ToString());

                }
            }
            goodtype.SelectedIndex = 0;
            connection.Close();
        }

        private void FillPlantName()
        {
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
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

                }
            }
            Plant.SelectedIndex = 0;
            connection.Close();
        }

        private void FillPaymentMethod()
        {
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select Method From payment", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("myTable");
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    paymentmethod.Items.Add(row.ItemArray[i].ToString());

                }
            }
            paymentmethod.SelectedIndex = 0;
            connection.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
          String PartnerName = Partnername.Text;
          String MobileNumber = mobilenumber.Text;
          String EmailId = email.Text;
          String Date = date.Text;
          String Time = time.Text;
          String DealerSign = dealer.Text;
          String ProcurerSign = procurer.Text;
          String Transportation = vehicleno.Text;
          String GoodType = goodtype.Text;
          String Quantity = Quan.Text;
          String BagTpye = bagtype.Text;
          String RatePerQuintal = quintalrate.Text;
          String Commission = comi.Text;
          String StandarCharges = stdcharges.Text;
          String OtherCharges = othercharges.Text;
          String PaymentMethod = paymentmethod.Text;
          String FM = fm.Text;
          String DM = dm.Text;
          String MS = ms.Text;
          String TotalAmount = ""+ (Int16.Parse(RatePerQuintal)* Int16.Parse(Quantity)) + Int16.Parse(Commission) + Int16.Parse(StandarCharges) + Int16.Parse(OtherCharges);

            string query2 = "INSERT INTO `inventory` (`PartnerName`, `MobileNumber`, `EmailId`, `Date`, `Time`, `DealerSign`, `ProcurerSign`, `Transportation`, `GoodType`, `PlantName` , `Quantity`, `BagType`, `NoBags` , `RatePerQuintal`, `Comission`, `StandardCharges`, `OtherCharges`, `FM`, `DM`, `MS`, `TotalAmount`, `PaymentMethod`, `PaymentStatus`, `HandOver`, `Remarks`) VALUES ('" + PartnerName + "', '" + MobileNumber + "', '" + EmailId + "', '" + Date + "', '" + Time + "', '" + DealerSign + "', '" + ProcurerSign + "', '" + Transportation + "', '" + GoodType + "', '" +Plant.Text+ "', '" + Quantity + "', '" + BagTpye + "', '" + Numberbags.Text+ "', '" + RatePerQuintal + "', '" + Commission + "', '" + StandarCharges + "', '" + OtherCharges + "', '" + FM + "', '" + DM + "', '" + MS + "', '" + TotalAmount + "', '" + PaymentMethod + "', '" + payreceived.Text+ "', '" + paystatus.Text + "', '" + remark.Text+ "')";
            //open connection
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();

            //create command and assign the query and connection from the constructor
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query2, connection);


            //Execute command
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Entry Saved Sucessfully");
            this.Opacity = 0;
        }


        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}

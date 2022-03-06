using Microsoft.Data.Sqlite;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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


        string server = "localhost";
        string database = "inventoryapp";
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
            Fillphone();
            Fillemail();
            date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            paystatus.SelectedIndex = 0;

            if (paymentmethod.Text == "NEFT")
            {
                stdcharges.Text = "59";

            }
            else if (paymentmethod.Text == "RTGS")
            {
                stdcharges.Text = "59";
            }
            else if (paymentmethod.Text == "TRF")
            {
                stdcharges.Text = "59";
            }
            else if (paymentmethod.Text == "CASH")
            {
                stdcharges.Text = "" + long.Parse(TotalAmt.Text) * 0.05;

            }

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

        private void Fillemail()
        {
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
             database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select Email From partner WHERE Name='" + Partnername.Text + "'", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("myTable");
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    email.Text = row.ItemArray[i].ToString();

                }
            }
            
            connection.Close();
        }

        private void Fillphone()
        {
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
             database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select Phone From partner WHERE Name='" + Partnername.Text+ "'", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("myTable");
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    mobilenumber.Text= row.ItemArray[i].ToString();

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

        private Boolean checkbill()
        {
            if(billno.Text.Equals(""))
            {
                MessageBox.Show("Please enter bill no.");
                return false;
            }
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * From inventory where Billno="+billno.Text, connection);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("myTable");
            da.Fill(table);

            if(table.Rows.Count>=1)
            {
                MessageBox.Show("Bill no already exist");
                return false;
            }
            connection.Close();
            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (checkbill())
                {
                    String PartnerName = Partnername.Text;
                    String MobileNumber = mobilenumber.Text;
                    String EmailId = email.Text;
                    String Date = "";
                    try
                    {
                        Date = date.SelectedDate.Value.Date.ToShortDateString();
                    }
                    catch (Exception ex) { MessageBox.Show("Please enter Proper Date"); return; }
                    String DealerSign = dealer.Text;
                    String ProcurerSign = procurer.Text;
                    String Transportation = vehicleno.Text;
                    String GoodType = goodtype.Text;
                    String Quantity = Quan.Text;
                    String BagTpye = bagtype.Text;
                    String RatePerQuintal = quintalrate.Text;
                    String Commission = "" + String.Format("{0:0.00}", (double.Parse(RatePerQuintal) * double.Parse(Quantity)));
                    String transactiondecution = stdcharges.Text;
                    String PaymentMethod = paymentmethod.Text;
                    String FM = fm.Text;
                    String DM = dm.Text;
                    String MS = ms.Text;
                    String stddeduction = "" + String.Format("{0:0.00}", (double.Parse(othercharges.Text)));
                    String TotalAmount = "" + String.Format("{0:0.00}", (double.Parse(Commission) - ((double.Parse(stdcharges.Text)) + double.Parse(othercharges.Text))));
                  
                    string query2 = "INSERT INTO `inventory` (`Billno`, `PartnerName`, `MobileNumber`, `EmailId`, `Date`, `DealerSign`, `ProcurerSign`, `Transportation`, `GoodType`, `PlantName` , `Quantity`, `BagType`, `NoBags` , `RatePerQuintal`, `Subtotal`, `TransactionCharges`, `QualityDeduction`, `FM`, `DM`, `MS`, `TotalAmount`, `PaymentMethod`, `PaymentStatus`, `HandOver`, `Remarks`, `Amount Pending`) VALUES ('" + billno.Text + "', '" + PartnerName + "', '" + MobileNumber + "', '" + EmailId + "', '" + Date + "', '" + DealerSign + "', '" + ProcurerSign + "', '" + Transportation + "', '" + GoodType + "', '" + Plant.Text + "', '" + Quantity + "', '" + BagTpye + "', '" + Numberbags.Text + "', '" + RatePerQuintal + "', '" + Commission + "', '" + transactiondecution + "', '" + stddeduction + "', '" + FM + "', '" + DM + "', '" + MS + "', '" + TotalAmount + "', '" + PaymentMethod + "', '" + paystatus.Text + "','" + payreceived.Text + "', '" + remark.Text + "', '" + amountpending.Text + "')";
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
            }
            catch (Exception ex) {
                 File.WriteAllText("Log.txt", ex.ToString());
            }
        }


        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[.][0-9]+$|^[0-9]*[.]{0,1}[0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));

        }

        private void Partnername_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        async private void Onpartnerchange(object sender, SelectionChangedEventArgs e)
        {
            await Task.Delay(10);
            Fillemail();
            Fillphone();
        }

        private void onpending(object sender, RoutedEventArgs e)
        {
            try {
                amountpending.Text = ""+(double.Parse(TotalAmt.Text) - double.Parse(payreceived.Text));
            }catch(Exception ex){
                string bug = ex.ToString();
                amountpending.Text = "";
            }
            }

        async private void totalcalc(object sender, TextChangedEventArgs e)
        {
            await Task.Delay(10);
            try
            {
                if (paymentmethod.Text == "NEFT")
                {
                    stdcharges.Text = "59";

                }
                else if (paymentmethod.Text == "RTGS")
                {
                    stdcharges.Text = "59";
                }
                else if (paymentmethod.Text == "TRF")
                {
                    stdcharges.Text = "59";
                }
                else if (paymentmethod.Text == "CASH")
                {
                    stdcharges.Text = String.Format("{0:0.00}", (((double.Parse(comi.Text) - double.Parse(othercharges.Text)) * 0.05 / 100) + (((double.Parse(comi.Text) - double.Parse(othercharges.Text)) * 0.05 / 100) * 18 / 100)));


                }
                String DealerSign = dealer.Text;
                String ProcurerSign = procurer.Text;
                String Transportation = vehicleno.Text;
                String GoodType = goodtype.Text;
                String Quantity = Quan.Text;
                String BagTpye = bagtype.Text;
                String RatePerQuintal = quintalrate.Text;
                String Commission = "" + String.Format("{0:0.00}",(double.Parse(RatePerQuintal) * double.Parse(Quantity)));
                String transactiondecution = stdcharges.Text;
                String PaymentMethod = paymentmethod.Text;
                String FM = fm.Text;
                String DM = dm.Text;
                String MS = ms.Text;
                String stddeduction = "" + String.Format("{0:0.00}",(double.Parse(othercharges.Text)));
                String TotalAmount = "" + String.Format("{0:0.00}",(double.Parse(Commission) - ((double.Parse(stdcharges.Text)) + double.Parse(othercharges.Text))));
                TotalAmt.Text = TotalAmount;
                //  othercharges.Text = stddeduction;
                comi.Text = Commission;
            }
            catch (Exception ex) { TotalAmt.Text = ""; }

        }

        async private void onpaymentchange(object sender, SelectionChangedEventArgs e)
        {
            await Task.Delay(10);
            try
            {
                await Task.Delay(10);

                if (paymentmethod.Text == "NEFT")
                {
                    stdcharges.Text = "59";

                }
                else if (paymentmethod.Text == "RTGS")
                {
                    stdcharges.Text = "59";
                }
                else if (paymentmethod.Text == "TRF")
                {
                    stdcharges.Text = "59";
                }
                else if (paymentmethod.Text == "CASH")
                {
                   // stdcharges.Text = "" + (((double.Parse(comi.Text) - double.Parse(othercharges.Text)) * 0.05 / 100) + (((double.Parse(comi.Text) - double.Parse(othercharges.Text)) * 0.05 / 100) * 18 / 100));
                    stdcharges.Text = String.Format("{0:0.00}", (((double.Parse(comi.Text) - double.Parse(othercharges.Text)) * 0.05 / 100) + (((double.Parse(comi.Text) - double.Parse(othercharges.Text)) * 0.05 / 100) * 18 / 100)));
                    

                }
            }
            catch (Exception ex) { };

        }
    }
}

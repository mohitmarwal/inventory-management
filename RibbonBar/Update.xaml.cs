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
    public partial class Update : UserControl
    {
        public string datel;
        public static string entryno;
        string connetionString;
        string server = "localhost";
        string database = "inventoryapp";
        string uid = "root";
        string password = "";
        MySql.Data.MySqlClient.MySqlConnection connection;
        string connectionString;
        string status = "";
        public Update()
        {
            InitializeComponent();
            Fillbag();
            FillPartner();
            FillGoods();
            FillPlantName();
            FillPaymentMethod();
            UdateForm();

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
        async private void Onpartnerchange(object sender, SelectionChangedEventArgs e)
        {
            await Task.Delay(10);
            Fillemail();
            Fillphone();
        }
        private void UdateForm()
        {
            try
            {

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
                String AmountPending = "";
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                 database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


                connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
                connection.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM inventory WHERE Billno=" + entryno, connection);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable("myTable");
                da.Fill(table);

                foreach (DataRow row in table.Rows)
                {

                    Partnername.SelectedIndex = Partnername.Items.IndexOf(row.ItemArray[2].ToString());
                    mobilenumber.Text = row.ItemArray[3].ToString();
                    email.Text = row.ItemArray[4].ToString();
                    date.SelectedDate = DateTime.Parse((row.ItemArray[5].ToString()));
                    datel = row.ItemArray[5].ToString();
                    dealer.Text = row.ItemArray[6].ToString();
                    procurer.Text = row.ItemArray[7].ToString();
                    vehicleno.Text = row.ItemArray[8].ToString();
                    goodtype.SelectedIndex = goodtype.Items.IndexOf(row.ItemArray[9].ToString());
                    Plant.SelectedIndex = Plant.Items.IndexOf(row.ItemArray[10].ToString());
                    Quan.Text = row.ItemArray[11].ToString();
                    bagtype.SelectedIndex = bagtype.Items.IndexOf(row.ItemArray[12].ToString());
                    Numberbags.Text = row.ItemArray[13].ToString();
                    quintalrate.Text = row.ItemArray[14].ToString();
                    comi.Text = row.ItemArray[15].ToString();
                    stdcharges.Text = row.ItemArray[16].ToString();
                    othercharges.Text = row.ItemArray[17].ToString();
                    fm.Text = row.ItemArray[18].ToString();
                    dm.Text = row.ItemArray[19].ToString();
                    ms.Text = row.ItemArray[20].ToString();
                    TotalAmt.Text = row.ItemArray[21].ToString();
                    paymentmethod.SelectedIndex = paymentmethod.Items.IndexOf(row.ItemArray[22].ToString());
                    paystatus.SelectedItem = (ComboBoxItem)this.paystatus.FindName(row.ItemArray[23].ToString());
                    status = row.ItemArray[23].ToString();
                    payreceived.Text = row.ItemArray[24].ToString();
                    remark.Text = row.ItemArray[25].ToString();
                    amountpending.Text = row.ItemArray[26].ToString();
                    billno.Text = row.ItemArray[1].ToString();

                }
            }
            catch(Exception ex) { }

            connection.Close();
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
            String Date="";
            if (date.SelectedDate==null)
            {
                Date = datel;
            }
            else
            {
                Date = date.SelectedDate.Value.Date.ToShortDateString();
            }

            String DealerSign = dealer.Text;
            String ProcurerSign = procurer.Text;
            String Transportation = vehicleno.Text;
            String GoodType = goodtype.Text;
            String Quantity = Quan.Text;
            String BagTpye = bagtype.Text;
            String RatePerQuintal = quintalrate.Text;
            String Commission = "" + (double.Parse(RatePerQuintal) * double.Parse(Quantity));
            String transactiondecution = stdcharges.Text;
            String PaymentMethod = paymentmethod.Text;
            String FM = fm.Text;
            String DM = dm.Text;
            String MS = ms.Text;
            String stddeduction = "" + (double.Parse(othercharges.Text));
            String TotalAmount = "" + (double.Parse(Commission) - ((double.Parse(stdcharges.Text)) + double.Parse(othercharges.Text)));

            if (paystatus.SelectedIndex!=-1)
            {
                status = paystatus.Text;
            }


            string query2 = "UPDATE `inventory` set PartnerName='" + Partnername.Text + "', MobileNumber='" + mobilenumber.Text + "', Billno='" + billno.Text + "', EmailId='" + email.Text + "',  Date='" + Date + "', DealerSign='" + dealer.Text + "', ProcurerSign='" + procurer.Text + "', Transportation='" + vehicleno.Text + "', GoodType='" + goodtype.Text + "', PlantName='" + Plant.Text + "', Quantity='" + Quan.Text + "', BagType='" + bagtype.Text + "', NoBags='" + Numberbags.Text + "', RatePerQuintal='" + quintalrate.Text + "', Subtotal='" + comi.Text + "', TransactionCharges='" + stdcharges.Text + "', QualityDeduction='" + othercharges.Text + "', TotalAmount='" + TotalAmt.Text + "', PaymentMethod='" + paymentmethod.Text + "', PaymentStatus='" + status + "', HandOver='" + payreceived.Text + "', Remarks='" + remark.Text + "', `Amount Pending`='" + amountpending.Text+ "' WHERE Billno=" + entryno;
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
                    stdcharges.Text = "" + (((double.Parse(comi.Text) - double.Parse(othercharges.Text)) * 0.05 / 100) + (((double.Parse(comi.Text) - double.Parse(othercharges.Text)) * 0.05 / 100) * 18 / 100));


                }
                String DealerSign = dealer.Text;
                String ProcurerSign = procurer.Text;
                String Transportation = vehicleno.Text;
                String GoodType = goodtype.Text;
                String Quantity = Quan.Text;
                String BagTpye = bagtype.Text;
                String RatePerQuintal = quintalrate.Text;
                String Commission = "" + (double.Parse(RatePerQuintal) * double.Parse(Quantity));
                String transactiondecution = stdcharges.Text;
                String PaymentMethod = paymentmethod.Text;
                String FM = fm.Text;
                String DM = dm.Text;
                String MS = ms.Text;
                String stddeduction = "" + (double.Parse(othercharges.Text));
                String TotalAmount = "" + (double.Parse(Commission) - ((double.Parse(stdcharges.Text)) + double.Parse(othercharges.Text)));
                TotalAmt.Text = TotalAmount;
              //  othercharges.Text = stddeduction;
                comi.Text = Commission;
            }
            catch (Exception ex) { TotalAmt.Text = ""; }

        }

        private void onpending(object sender, TextChangedEventArgs e)
        {
            try
            {
                amountpending.Text = "" + (double.Parse(TotalAmt.Text) - double.Parse(payreceived.Text));
            }
            catch (Exception ex)
            {
                string bug = ex.ToString();
                amountpending.Text = "";
            }
        }

        async private void onpaymentchange(object sender, SelectionChangedEventArgs e)
        {
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
                    stdcharges.Text = "" + (((double.Parse(comi.Text) - double.Parse(othercharges.Text)) * 0.05 / 100) + (((double.Parse(comi.Text) - double.Parse(othercharges.Text)) * 0.05 / 100) * 18 / 100));


                }
            }
            catch (Exception ex) { };
        }
    }
}

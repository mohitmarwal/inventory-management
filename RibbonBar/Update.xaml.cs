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
        string database = "test";
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
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM inventory WHERE Entry_no=" + entryno, connection);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable("myTable");
                da.Fill(table);

                foreach (DataRow row in table.Rows)
                {

                    Partnername.SelectedIndex = Partnername.Items.IndexOf(row.ItemArray[1].ToString());
                    mobilenumber.Text = row.ItemArray[2].ToString();
                    email.Text = row.ItemArray[3].ToString();
                    date.SelectedDate = DateTime.Parse((row.ItemArray[4].ToString()));
                    datel = row.ItemArray[4].ToString();
                    dealer.Text = row.ItemArray[5].ToString();
                    procurer.Text = row.ItemArray[6].ToString();
                    vehicleno.Text = row.ItemArray[7].ToString();
                    goodtype.SelectedIndex = goodtype.Items.IndexOf(row.ItemArray[8].ToString());
                    Plant.SelectedIndex = Plant.Items.IndexOf(row.ItemArray[9].ToString());
                    Quan.Text = row.ItemArray[10].ToString();
                    bagtype.SelectedIndex = bagtype.Items.IndexOf(row.ItemArray[11].ToString());
                    Numberbags.Text = row.ItemArray[12].ToString();
                    quintalrate.Text = row.ItemArray[13].ToString();
                    comi.Text = row.ItemArray[14].ToString();
                    stdcharges.Text = row.ItemArray[15].ToString();
                    othercharges.Text = row.ItemArray[16].ToString();
                    fm.Text = row.ItemArray[17].ToString();
                    dm.Text = row.ItemArray[18].ToString();
                    ms.Text = row.ItemArray[19].ToString();
                    TotalAmt.Text = row.ItemArray[20].ToString();
                    paymentmethod.SelectedIndex = paymentmethod.Items.IndexOf(row.ItemArray[21].ToString());
                    paystatus.SelectedItem = (ComboBoxItem)this.paystatus.FindName(row.ItemArray[22].ToString());
                    status = row.ItemArray[22].ToString();
                    payreceived.Text = row.ItemArray[23].ToString();
                    remark.Text = row.ItemArray[24].ToString();
                    amountpending.Text = row.ItemArray[25].ToString();
                    

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
          String Commission = comi.Text;
          String StandarCharges = stdcharges.Text;
          String OtherCharges = othercharges.Text;
          String PaymentMethod = paymentmethod.Text;
            if (paystatus.SelectedIndex!=-1)
            {
                status = paystatus.Text;
            }
          String TotalAmount = ""+ (Int16.Parse(RatePerQuintal)* Int16.Parse(Quantity)) + Int16.Parse(Commission) + Int16.Parse(StandarCharges) + Int16.Parse(OtherCharges);

            string query2 = "UPDATE `inventory` set PartnerName='" + Partnername.Text + "', MobileNumber='" + mobilenumber.Text + "', EmailId='" + email.Text + "',  Date='" + Date + "', DealerSign='" + dealer.Text + "', ProcurerSign='" + procurer.Text + "', Transportation='" + vehicleno.Text + "', GoodType='" + goodtype.Text + "', PlantName='" + Plant.Text + "', Quantity='" + Quan.Text + "', BagType='" + bagtype.Text + "', NoBags='" + Numberbags.Text + "', RatePerQuintal='" + quintalrate.Text + "', Comission='" + comi.Text + "', StandardCharges='" + stdcharges.Text + "', OtherCharges='" + othercharges.Text + "', TotalAmount='" + TotalAmt.Text + "', PaymentMethod='" + paymentmethod.Text + "', PaymentStatus='" + status + "', HandOver='" + payreceived.Text + "', Remarks='" + remark.Text + "', `Amount Pending`='" + amountpending.Text+ "' WHERE Entry_No=" + entryno;
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

        private void totalcalc(object sender, TextChangedEventArgs e)
        {
            try
            {
                String Quantity = Quan.Text;
                String BagTpye = bagtype.Text;
                String RatePerQuintal = quintalrate.Text;
                String Commission = comi.Text;
                String StandarCharges = stdcharges.Text;
                String OtherCharges = othercharges.Text;
                String FM = fm.Text;
                String DM = dm.Text;
                String MS = ms.Text;
                String TotalAmount = "" + (long.Parse(RatePerQuintal) * long.Parse(Quantity)) + long.Parse(Commission) + long.Parse(StandarCharges) + long.Parse(OtherCharges);
                TotalAmt.Text = TotalAmount;
            }
            catch (Exception ex) { TotalAmt.Text = ""; }

        }

        private void onpending(object sender, TextChangedEventArgs e)
        {
            try
            {
                amountpending.Text = "" + (long.Parse(TotalAmt.Text) - long.Parse(payreceived.Text));
            }
            catch (Exception ex)
            {
                string bug = ex.ToString();
                amountpending.Text = "";
            }
        }
    }
}

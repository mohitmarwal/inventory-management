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
            UdateFormAsync();
            Fillbroker();

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
        private async Task UdateFormAsync()
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
                    await Task.Delay(150);
                    date.IsEnabled = true;
                    date.SelectedDate = DateTime.Parse((row.ItemArray[5].ToString()));
                    date.DisplayDate = DateTime.Parse((row.ItemArray[5].ToString()));
                    date.SelectedDateChanged += DatePicker_SelectedDateChanged;
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
                    Brokername.SelectedIndex = Brokername.Items.IndexOf(row.ItemArray[31].ToString());
                    paystatus.SelectedItem = (ComboBoxItem)this.paystatus.FindName(row.ItemArray[23].ToString());
                    status = row.ItemArray[23].ToString();
                    payreceived.Text = row.ItemArray[24].ToString();
                    remark.Text = row.ItemArray[25].ToString();
                    amountpending.Text = row.ItemArray[26].ToString();
                    Quan1.Text = row.ItemArray[27].ToString();
                    quintalrate1.Text = row.ItemArray[28].ToString();
                    Quan2.Text = row.ItemArray[29].ToString();
                    quintalrate2.Text = row.ItemArray[30].ToString();
                    billno.Text = row.ItemArray[1].ToString();

                }
            }
            catch(Exception ex) { File.WriteAllText("Log.txt", DateTime.Now.ToString() + " : " + ex.ToString()); }

            connection.Close();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var picker = sender as DatePicker;
            DateTime? date = picker.SelectedDate;

           
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


        private void Fillbroker()
        {
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select name From broker", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("myTable");
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    Brokername.Items.Add(row.ItemArray[i].ToString());

                }
            }
            paymentmethod.SelectedIndex = -1;
            paystatus.SelectedIndex = -1;
            paystatus.SelectedItem = null;
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
            String FM = fm.Text;
            String DM = dm.Text;
            String MS = ms.Text;
            String Commission = ""; 
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
            if (!RatePerQuintal.Equals("") && !Quantity.Equals(""))
            {
                if ((!quintalrate1.Text.Equals("") && !Quan1.Text.Equals("")) && (quintalrate2.Text.Equals("") && Quan2.Text.Equals("")))
                {
                    Commission = "" + String.Format("{0:0.00}", (double.Parse(RatePerQuintal) * double.Parse(Quantity) + (double.Parse(quintalrate1.Text) * double.Parse(Quan1.Text))));
                    comi.Text = Commission;
                }

                if ((quintalrate1.Text.Equals("") && Quan1.Text.Equals("")) && (quintalrate2.Text.Equals("") && Quan2.Text.Equals("")))
                {
                    Commission = "" + String.Format("{0:0.00}", (double.Parse(RatePerQuintal) * double.Parse(Quantity)));
                    comi.Text = Commission;
                }

                if ((!quintalrate2.Text.Equals("") && !Quan2.Text.Equals("")) && (quintalrate1.Text.Equals("") && Quan1.Text.Equals("")))
                {
                    Commission = "" + String.Format("{0:0.00}", (double.Parse(RatePerQuintal) * double.Parse(Quantity) + (double.Parse(quintalrate2.Text) * double.Parse(Quan2.Text))));
                    comi.Text = Commission;
                }

                if ((!quintalrate2.Text.Equals("") && !Quan2.Text.Equals("")) && (!quintalrate1.Text.Equals("") && !Quan1.Text.Equals("")))
                {
                    Commission = "" + String.Format("{0:0.00}", (double.Parse(RatePerQuintal) * double.Parse(Quantity) + (double.Parse(quintalrate2.Text) * double.Parse(Quan2.Text)) + (double.Parse(quintalrate1.Text) * double.Parse(Quan1.Text))));
                    comi.Text = Commission;
                }
            }
            String transactiondecution = stdcharges.Text;
            String PaymentMethod = paymentmethod.Text;

            if (!othercharges.Text.Equals("") && !stdcharges.Text.Equals("") && Commission.Equals(""))
            {
                String stddeduction = "" + String.Format("{0:0.00}", (double.Parse(othercharges.Text)));
                String TotalAmount = "" + String.Format("{0:0.00}", (double.Parse(Commission) - ((double.Parse(stdcharges.Text)) + double.Parse(othercharges.Text))));
                TotalAmt.Text = TotalAmount;
                //  othercharges.Text = stddeduction;
            
                //String.Format("{0:0.00}", (double.Parse(Commission) - ((double.Parse(stdcharges.Text)) + double.Parse(othercharges.Text))));
            }
            if (paystatus.SelectedIndex!=-1)
            {
                status = paystatus.Text;
            }


            string query2 = "UPDATE `inventory` set PartnerName='" + Partnername.Text + "', MobileNumber='" + mobilenumber.Text + "', Billno='" + billno.Text + "', EmailId='" + email.Text + "',  Date='" + Date + "', DealerSign='" + dealer.Text + "', ProcurerSign='" + procurer.Text + "', Transportation='" + vehicleno.Text + "', GoodType='" + goodtype.Text + "', PlantName='" + Plant.Text + "', Quantity='" + Quan.Text + "', BagType='" + bagtype.Text + "', NoBags='" + Numberbags.Text + "', RatePerQuintal='" + quintalrate.Text + "', Subtotal='" + comi.Text + "', TransactionCharges='" + stdcharges.Text + "', QualityDeduction='" + othercharges.Text + "', FM='" + FM + "', DM='" + DM + "', MS='" + MS + "', TotalAmount='" + TotalAmt.Text + "', PaymentMethod='" + paymentmethod.Text + "', PaymentStatus='" + status + "', HandOver='" + payreceived.Text + "', Remarks='" + remark.Text + "', `Amount Pending`='" + amountpending.Text + "', `Quantity1`='" + Quan1.Text + "', `Rate1`='" + quintalrate1.Text + "', `Quantity2`='" + Quan2.Text + "', `Rate2`='" + quintalrate2.Text + "', `broker`='" + Brokername.Text + "' WHERE Billno=" + entryno;
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
            Regex regex = new Regex("^[.][0-9]+$|^[0-9]*[.]{0,1}[0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void NumberValidationTextBox1(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));

        }

        async private void totalcalc(object sender, TextChangedEventArgs e)
        {
            String subtotal = "";
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
                    stdcharges.Text = "0";
                }
                else if (paymentmethod.Text == "CASH")
                {
                    stdcharges.Text = String.Format("{0:0.00}", (((double.Parse(comi.Text) - double.Parse(othercharges.Text)) * 0.05 / 100) + (((double.Parse(comi.Text) - double.Parse(othercharges.Text)) * 0.05 / 100) * 18 / 100)));
                    stdcharges.Text = Math.Round(double.Parse(stdcharges.Text)).ToString();

                }

                String Quantity = Quan.Text;
                String BagTpye = bagtype.Text;
                String RatePerQuintal = quintalrate.Text;
                if (!RatePerQuintal.Equals("") && !Quantity.Equals(""))
                {
                    if ((!quintalrate1.Text.Equals("") && !Quan1.Text.Equals("")) && (quintalrate2.Text.Equals("") && Quan2.Text.Equals("")))
                    {
                        subtotal = "" + String.Format("{0:0.00}", (double.Parse(RatePerQuintal) * double.Parse(Quantity) + (double.Parse(quintalrate1.Text) * double.Parse(Quan1.Text))));
                        comi.Text = subtotal;
                    }

                    if ((quintalrate1.Text.Equals("") && Quan1.Text.Equals("")) && (quintalrate2.Text.Equals("") && Quan2.Text.Equals("")))
                    {
                        subtotal = "" + String.Format("{0:0.00}", (double.Parse(RatePerQuintal) * double.Parse(Quantity)));
                        comi.Text = subtotal;
                    }

                    if ((!quintalrate2.Text.Equals("") && !Quan2.Text.Equals("")) && (quintalrate1.Text.Equals("") && Quan1.Text.Equals("")))
                    {
                        subtotal = "" + String.Format("{0:0.00}", (double.Parse(RatePerQuintal) * double.Parse(Quantity) + (double.Parse(quintalrate2.Text) * double.Parse(Quan2.Text))));
                        comi.Text = subtotal;
                    }

                    if ((!quintalrate2.Text.Equals("") && !Quan2.Text.Equals("")) && (!quintalrate1.Text.Equals("") && !Quan1.Text.Equals("")))
                    {
                        subtotal = "" + String.Format("{0:0.00}", (double.Parse(RatePerQuintal) * double.Parse(Quantity) + (double.Parse(quintalrate2.Text) * double.Parse(Quan2.Text)) + (double.Parse(quintalrate1.Text) * double.Parse(Quan1.Text))));
                        comi.Text = subtotal;
                    }
                }
                String transactiondecution = stdcharges.Text;
                String PaymentMethod = paymentmethod.Text;
                String FM = fm.Text;
                String DM = dm.Text;
                String MS = ms.Text;
                if (!othercharges.Text.Equals("") || !stdcharges.Text.Equals("") || subtotal.Equals(""))
                {
                    String stddeduction = "" + String.Format("{0:0.00}", (double.Parse(othercharges.Text)));
                    String TotalAmount = "" + String.Format("{0:0.00}", (double.Parse(subtotal) - ((double.Parse(stdcharges.Text)) + double.Parse(othercharges.Text))));
                    TotalAmt.Text = TotalAmount;

                }
            }
            catch (Exception ex) { TotalAmt.Text = ""; File.WriteAllText("Log.txt", DateTime.Now.ToString() + " : " + ex.ToString()); }

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
                    stdcharges.Text = "0";
                }
                else if (paymentmethod.Text == "CASH")
                {
                    stdcharges.Text = String.Format("{0:0.00}", (((double.Parse(comi.Text) - double.Parse(othercharges.Text)) * 0.05 ) + (((double.Parse(comi.Text) - double.Parse(othercharges.Text)) * 0.05 ) * 18 / 100))); stdcharges.Text = "" + (((double.Parse(comi.Text) - double.Parse(othercharges.Text)) * 0.05 ) + (((double.Parse(comi.Text) - double.Parse(othercharges.Text)) * 0.05 ) * 18 / 100));
                     stdcharges.Text = Math.Round(double.Parse(stdcharges.Text)).ToString();

                }
            }
            catch (Exception ex) { File.WriteAllText("Log.txt", DateTime.Now.ToString() + " : " + ex.ToString()); };
        }
    }
}

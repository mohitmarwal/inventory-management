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
            Fillbroker();
           // Fillphone();
           // Fillemail();
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
                stdcharges.Text = "0";
            }
            else if (paymentmethod.Text == "CASH")
            {
                stdcharges.Text = String.Format("{0:0.00}", (((double.Parse(subtotal.Text)) * 0.05 ) + (((double.Parse(subtotal.Text)) * 0.05 ) * 18 / 100)));
                stdcharges.Text = Math.Ceiling(double.Parse(stdcharges.Text)).ToString();
            }
            paystatus.SelectedIndex = -1;
            paystatus.SelectedItem = null;
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
            bagtype.SelectedIndex = -1;

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
            Partnername.SelectedIndex = -1;
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
            goodtype.SelectedIndex = -1;
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
            Plant.SelectedIndex = -1;
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
            paymentmethod.SelectedIndex = -1;
            paystatus.SelectedIndex = -1;
            paystatus.SelectedItem = null;
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
            String stddeduction ="";
            String TotalAmount = "";
            String subtotal1 = "";
            String PaymentMethod = paymentmethod.Text;
            String FM = fm.Text;
            String DM = dm.Text;
            String MS = ms.Text;
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
                    if (!RatePerQuintal.Equals("") && !Quantity.Equals(""))
                    {
                        if ((!quintalrate1.Text.Equals("") && !Quan1.Text.Equals("")) && (quintalrate2.Text.Equals("") && Quan2.Text.Equals("")))
                        {
                            subtotal1 = "" + String.Format("{0:0.00}", (double.Parse(RatePerQuintal) * double.Parse(Quantity) + (double.Parse(quintalrate1.Text) * double.Parse(Quan1.Text))));
                            subtotal.Text = subtotal1;
                        }
                        if ((quintalrate1.Text.Equals("") && Quan1.Text.Equals("")) && (quintalrate2.Text.Equals("") && Quan2.Text.Equals("")))
                        {
                            subtotal1 = "" + String.Format("{0:0.00}", (double.Parse(RatePerQuintal) * double.Parse(Quantity)));
                            subtotal.Text = subtotal1;
                        }

                        if ((!quintalrate2.Text.Equals("") && !Quan2.Text.Equals("")) && (quintalrate1.Text.Equals("") && Quan1.Text.Equals("")))
                        {
                            subtotal1 = "" + String.Format("{0:0.00}", (double.Parse(RatePerQuintal) * double.Parse(Quantity) + (double.Parse(quintalrate2.Text) * double.Parse(Quan2.Text))));
                            subtotal.Text = subtotal1;
                        }

                        if ((!quintalrate2.Text.Equals("") && !Quan2.Text.Equals("")) && (!quintalrate1.Text.Equals("") && !Quan1.Text.Equals("")))
                        {
                            subtotal1 = "" + String.Format("{0:0.00}", (double.Parse(RatePerQuintal) * double.Parse(Quantity) + (double.Parse(quintalrate2.Text) * double.Parse(Quan2.Text)) + (double.Parse(quintalrate1.Text) * double.Parse(Quan1.Text))));
                            subtotal.Text = subtotal1;
                        }
                    }

                    String transactiondecution = stdcharges.Text;

                    if (!othercharges.Text.Equals("") && !stdcharges.Text.Equals("") && subtotal.Equals("")) 
                    {
                         stddeduction = "" + String.Format("{0:0.00}", (double.Parse(othercharges.Text)));
                         TotalAmount = "" + String.Format("{0:0.00}", (double.Parse(subtotal1) - ((double.Parse(stdcharges.Text)) + double.Parse(othercharges.Text))));
                        TotalAmt.Text = TotalAmount;
                        //  othercharges.Text = stddeduction;
                    
                        String.Format("{0:0.00}", (double.Parse(subtotal1) - ((double.Parse(stdcharges.Text)) + double.Parse(othercharges.Text))));
                    }
                   
                  
                    string query2 = "INSERT INTO `inventory` (`Billno`, `PartnerName`, `MobileNumber`, `EmailId`, `Date`, `DealerSign`, `ProcurerSign`, `Transportation`, `GoodType`, `PlantName` , `Quantity`, `BagType`, `NoBags` , `RatePerQuintal`, `subtotal`, `TransactionCharges`, `QualityDeduction`, `FM`, `DM`, `MS`, `TotalAmount`, `PaymentMethod`, `PaymentStatus`, `HandOver`, `Remarks`, `Amount Pending`,`Quantity1`,`Rate1`,`Quantity2`,`Rate2`,`broker`,`BR1`,`BR2`,`BR3`,`BQ1`,`BQ2`,`BQ3`,`DQ1`,`DQ2`,`DQ3`,`Tax`) VALUES ('" + billno.Text + "', '" + PartnerName + "', '" + MobileNumber + "', '" + EmailId + "', '" + Date + "', '" + DealerSign + "', '" + ProcurerSign + "', '" + Transportation + "', '" + GoodType + "', '" + Plant.Text + "', '" + Quantity + "', '" + BagTpye + "', '" + Numberbags.Text + "', '" + RatePerQuintal + "', '" + subtotal + "', '" + transactiondecution + "', '" + othercharges.Text + "', '" + FM + "', '" + DM + "', '" + MS + "', '" + TotalAmt.Text + "', '" + PaymentMethod + "', '" + paystatus.Text + "','" + payreceived.Text + "', '" + remark.Text + "', '" + amountpending.Text + "', '" + Quan1.Text + "', '"+ quintalrate1.Text + "', '"+ Quan2.Text + "', '"+ quintalrate2.Text+ "', '" + Brokername.Text + "', '" + br1.Text + "', '" + br2.Text + "', '" + br3.Text + "', '" + bq1.Text + "', '" + bq2.Text + "', '" + bq3.Text + "', '"  + "', '" + Brokername.Text + "', '" + ss.Text + "')";
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
                 File.WriteAllText("Log.txt", DateTime.Now.ToString()+ " : "+ex.ToString());
            }
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
        {/*
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
                    TextBox obj = sender as TextBox;
                    string _name = obj.Name;
                    if (!_name.Equals("stdcharges"))
                    {
                        stdcharges.Text = String.Format("{0:0.00}", (((double.Parse(subtotal.Text)) * 0.05/100) + (((double.Parse(subtotal.Text)) * 0.05/100) * 18 / 100)));
                        stdcharges.Text = Math.Ceiling(double.Parse(stdcharges.Text)).ToString();
                    }
                }
             
                String Quantity = Quan.Text;
                String BagTpye = bagtype.Text;
                String RatePerQuintal = quintalrate.Text;
                if (!RatePerQuintal.Equals("") && !Quantity.Equals(""))
                {
                    if ((!quintalrate1.Text.Equals("") && !Quan1.Text.Equals("")) && (quintalrate2.Text.Equals("") && Quan2.Text.Equals("")))
                    {
                        subtotal = "" + String.Format("{0:0.00}", (double.Parse(RatePerQuintal) * double.Parse(Quantity) + (double.Parse(quintalrate1.Text) * double.Parse(Quan1.Text))));
                        subtotal.Text = subtotal;
                    }

                    if ((quintalrate1.Text.Equals("") && Quan1.Text.Equals("")) && (quintalrate2.Text.Equals("") && Quan2.Text.Equals("")))
                    {
                        subtotal = "" + String.Format("{0:0.00}", (double.Parse(RatePerQuintal) * double.Parse(Quantity)));
                        subtotal.Text = subtotal;
                    }
                    if ((!quintalrate2.Text.Equals("") && !Quan2.Text.Equals("")) && (quintalrate1.Text.Equals("") && Quan1.Text.Equals("")))
                    {
                        subtotal = "" + String.Format("{0:0.00}", (double.Parse(RatePerQuintal) * double.Parse(Quantity) + (double.Parse(quintalrate2.Text) * double.Parse(Quan2.Text))));
                        subtotal.Text = subtotal;
                    }

                    if ((!quintalrate2.Text.Equals("") && !Quan2.Text.Equals("")) && (!quintalrate1.Text.Equals("") && !Quan1.Text.Equals("")))
                    {
                        subtotal = "" + String.Format("{0:0.00}", (double.Parse(RatePerQuintal) * double.Parse(Quantity) + (double.Parse(quintalrate2.Text) * double.Parse(Quan2.Text)) + (double.Parse(quintalrate1.Text) * double.Parse(Quan1.Text))));
                        subtotal.Text = subtotal;
                    }
                }
                String transactiondecution = stdcharges.Text;
                String PaymentMethod = paymentmethod.Text;
                String FM = fm.Text;
                String DM = dm.Text;
                String MS = ms.Text;
                if (!othercharges.Text.Equals("") || !stdcharges.Text.Equals("") || subtotal.Equals(""))
                {
                    String stddeduction = "" + String.Format("{0:0.00}", Math.Ceiling((double.Parse(othercharges.Text))));
                    String TotalAmount = "" + String.Format("{0:0.00}", Math.Ceiling((double.Parse(subtotal) - ((double.Parse(stdcharges.Text)) + double.Parse(othercharges.Text)))));
                    TotalAmt.Text = TotalAmount;
         

                }
            }
            catch (Exception ex) { TotalAmt.Text = ""; File.WriteAllText("Log.txt", DateTime.Now.ToString() + " : " + ex.ToString());  }
            */
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
                    stdcharges.Text = "0";
                }
                else if (paymentmethod.Text == "CASH")
                {
                    // stdcharges.Text = "" + (((double.Parse(subtotal.Text) - double.Parse(othercharges.Text)) * 0.05 / 100) + (((double.Parse(subtotal.Text) - double.Parse(othercharges.Text)) * 0.05 / 100) * 18 / 100));
                    stdcharges.Text = String.Format("{0:0.00}", (((double.Parse(subtotal.Text)) * 0.05/100) + (((double.Parse(subtotal.Text)) * 0.05/100) * 18 / 100)));
                    stdcharges.Text = Math.Ceiling(double.Parse(stdcharges.Text)).ToString();


                }
            }
            catch (Exception ex) { File.WriteAllText("Log.txt", DateTime.Now.ToString() + " : " + ex.ToString()); };

        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            if (Quan.Text == "") { Quan.Text = "0"; }if (Quan1.Text == "") { Quan1.Text = "0"; }if (Quan2.Text == "") { Quan2.Text = "0"; }
            if (quintalrate.Text == "") { quintalrate.Text = "0"; }if (quintalrate1.Text == "") { quintalrate1.Text = "0"; }if (quintalrate2.Text == "") { quintalrate2.Text = "0"; }
            if (br1.Text == "") { br1.Text = "0"; }if (br2.Text == "") { br2.Text = "0"; }if (br3.Text == "") { br3.Text = "0"; }
            if (bq1.Text == "") { bq1.Text = "0"; }if (bq2.Text == "") { bq2.Text = "0"; } if (bq3.Text == "") { bq3.Text = "0"; }
            if (dm.Text == "") { dm.Text = "0"; }if (ms.Text == "") { bq2.Text = "0"; }if (fm.Text == "") { fm.Text = "0"; }if (ss.Text == "") { ss.Text = "0"; }if (gs.Text == "") { ss.Text = "0"; }

            subtotal.Text = "" + Math.Round(((double.Parse(bq1.Text)) * (double.Parse(quintalrate.Text)) + (double.Parse(quintalrate1.Text)) * (double.Parse(bq2.Text)) + (double.Parse(bq3.Text)) * (double.Parse(quintalrate2.Text))), MidpointRounding.AwayFromZero);
            shortage.Text = "" + Math.Round(((((double.Parse(bq1.Text))- (double.Parse(Quan.Text)))* (double.Parse(br1.Text)))+ (((double.Parse(bq2.Text)) - (double.Parse(Quan1.Text))) * (double.Parse(br2.Text))) + (((double.Parse(bq3.Text)) - (double.Parse(Quan2.Text))) * (double.Parse(br3.Text)))), MidpointRounding.AwayFromZero);
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
             database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            double dsmultiplier=0; double fmmultiplier=0; double gsmultiplier=0; double msmultiplier=0; double ssmultiplier=0;

            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select Rate From ds WHERE " + dm.Text+ " between Min and Max and Plant ='"+Plant.Text+"'", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("myTable");
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    dsmultiplier = double.Parse( row.ItemArray[i].ToString());

                }
            }

            connection.Close();

           
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySql.Data.MySqlClient.MySqlCommand("select Rate From fm WHERE " + fm.Text + " between Min and Max and Plant ='" + Plant.Text + "'", connection);

            da = new MySqlDataAdapter(cmd);
             table = new DataTable("myTable");
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    fmmultiplier = double.Parse(row.ItemArray[i].ToString());

                }
            }

            connection.Close();

          
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySql.Data.MySqlClient.MySqlCommand("select Rate From gs WHERE " + gs.Text + " between Min and Max and Plant ='" + Plant.Text + "'", connection);
            da = new MySqlDataAdapter(cmd);
            table = new DataTable("myTable");
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    gsmultiplier = double.Parse(row.ItemArray[i].ToString());

                }
            }

            connection.Close();

           
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySql.Data.MySqlClient.MySqlCommand("select Rate From ms WHERE " + ms.Text + " between Min and Max and Plant ='" + Plant.Text + "'", connection);

            da = new MySqlDataAdapter(cmd);
            table = new DataTable("myTable");
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    msmultiplier = double.Parse(row.ItemArray[i].ToString());

                }
            }

            connection.Close();

            
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySql.Data.MySqlClient.MySqlCommand("select Rate From ms WHERE " + ss.Text + " between Min and Max and Plant ='" + Plant.Text + "'", connection);

            da = new MySqlDataAdapter(cmd);
            table = new DataTable("myTable");
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    ssmultiplier = double.Parse(row.ItemArray[i].ToString());

                }
            }

            connection.Close();

            double hamali=0;
            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySql.Data.MySqlClient.MySqlCommand("select Rate From hamali WHERE Plant ='" + Plant.Text + "'" + " and Bagtype ='" +bagtype.Text +"'", connection);

            da = new MySqlDataAdapter(cmd);
            table = new DataTable("myTable");
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    hamali = double.Parse(row.ItemArray[i].ToString());

                }
            }

            connection.Close();

            double fmcal; double fmcal1; double fmcal2; double fmcal3;
            double dmcal; double dmcal1; double dmcal2; double dmcal3;
            double mscal; double mscal1; double mscal2; double mscal3;
            double sscal; double sscal1; double sscal2; double sscal3;
            double gscal; double gscal1; double gscal2; double gscal3;
            double finaldedcution;

            fmcal1 = Math.Round((double.Parse(br1.Text)) * (double.Parse(bq1.Text)) * (fmmultiplier / 100), MidpointRounding.AwayFromZero);
            dmcal1 = Math.Round((double.Parse(br1.Text)) * (double.Parse(bq1.Text)) * (dsmultiplier / 100), MidpointRounding.AwayFromZero); 
            gscal1 = Math.Round((double.Parse(br1.Text)) * (double.Parse(bq1.Text)) * (gsmultiplier / 100), MidpointRounding.AwayFromZero);
            sscal1 = Math.Round((double.Parse(br1.Text)) * (double.Parse(bq1.Text)) * (ssmultiplier / 100), MidpointRounding.AwayFromZero); 
            mscal1 = Math.Round((double.Parse(br1.Text)) * (double.Parse(bq1.Text)) * (msmultiplier / 100), MidpointRounding.AwayFromZero);

            fmcal2 = Math.Round((double.Parse(br2.Text)) * (double.Parse(bq2.Text)) * (fmmultiplier / 100), MidpointRounding.AwayFromZero);
            dmcal2 = Math.Round((double.Parse(br2.Text)) * (double.Parse(bq2.Text)) * (dsmultiplier / 100), MidpointRounding.AwayFromZero);
            gscal2 = Math.Round((double.Parse(br2.Text)) * (double.Parse(bq2.Text)) * (gsmultiplier / 100), MidpointRounding.AwayFromZero);
            sscal2 = Math.Round((double.Parse(br2.Text)) * (double.Parse(bq2.Text)) * (ssmultiplier / 100), MidpointRounding.AwayFromZero);
            mscal2 = Math.Round((double.Parse(br2.Text)) * (double.Parse(bq2.Text)) * (msmultiplier / 100), MidpointRounding.AwayFromZero);

            fmcal3 = Math.Round((double.Parse(br3.Text)) * (double.Parse(bq3.Text)) * (fmmultiplier / 100), MidpointRounding.AwayFromZero);
            dmcal3= Math.Round((double.Parse(br3.Text))  *  (double.Parse(bq3.Text)) * (dsmultiplier / 100), MidpointRounding.AwayFromZero);
            gscal3 = Math.Round((double.Parse(br3.Text)) * (double.Parse(bq3.Text)) * (gsmultiplier / 100), MidpointRounding.AwayFromZero);
            sscal3 = Math.Round((double.Parse(br3.Text)) * (double.Parse(bq3.Text)) * (ssmultiplier / 100), MidpointRounding.AwayFromZero);
            mscal3 = Math.Round((double.Parse(br3.Text)) * (double.Parse(bq3.Text)) * (msmultiplier / 100), MidpointRounding.AwayFromZero);

            fmcal = fmcal1 + fmcal2 + fmcal3;
            dmcal = dmcal1 + dmcal2 + dmcal3;
            gscal = gscal1 + gscal2 + gscal3;
            sscal = sscal1 + sscal2 + sscal3;
            mscal = mscal1 + mscal2 + mscal3;

           finaldedcution = fmcal + dmcal + gscal + sscal + mscal + (hamali * (double.Parse(Numberbags.Text))) ;

           


        }
    }
}

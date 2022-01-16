using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RibbonWin
{
    /// <summary>
    /// Interaction logic for EmployeeInfo.xaml
    /// </summary>
    public partial class EmployeeInfo : UserControl
    {
        public static String Productname = "1";
        public static String MobileNumber = "1";
        public static String EmailId = "1";
        public static String Date = "1";
        public static String Time = "1";
        public static String DealerSign = "1";
        public static String ProcurerSign = "1";
        public static String Transportation = "1";
        public static String GoodType = "1";
        public static String Quantity = "1";
        public static String BagTpye = "1";
        public static String RatePerQuintal = "1";
        public static String Commission = "1";
        public static String StandarCharges = "1";
        public static String TotalAmount = "1";
        public static String OtherCharges = "1";
        public static String PaymentMethod = "1";

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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string query = "INSERT INTO inventory (name, age) VALUES('John Smith', '33')";

            string query1 = @"INSERT INTO inventory (ProductName, MobileNumber, EmailId, Date, Time, DealerSign, ProcurerSign, Transportation, GoodType, Quantity, BagType, RatePerQuintal, Comission, StandardCharges, OtherCharges, TotalAmount, PaymentMethod) VALUES" + "(" + Productname + "," + MobileNumber + ", " + EmailId + "," + Date + ", '123123', '123123', '123123', '13213', '112', '13123', '123123', '123123', '12321', '123123', '123213', '123123', '123213', '123123'), ('123213', '123213', '123123', '123213', '123213', '123123', '123123', '123123', '123123', '12312321', '123123', '123123', '123213', '123123', '123123', '123123', '123123')";

            string query2 = "INSERT INTO `inventory` (`ProductName`, `MobileNumber`, `EmailId`, `Date`, `Time`, `DealerSign`, `ProcurerSign`, `Transportation`, `GoodType`, `Quantity`, `BagType`, `RatePerQuintal`, `Comission`, `StandardCharges`, `OtherCharges`, `TotalAmount`, `PaymentMethod`) VALUES ('" + Productname + "', '" + MobileNumber + "', '" + EmailId + "', '" + Date + "', '" + Time + "', '" + DealerSign + "', '" + ProcurerSign + "', '" + Transportation + "', '" + Quantity + "', '" + GoodType + "', '" + BagTpye + "', '" + RatePerQuintal + "', '" + Commission + "', '" + StandarCharges + "', '" + OtherCharges + "', '" + TotalAmount + "', '" + PaymentMethod + "')";
            //open connection
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
           
       
             connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
              connection.Open();
            MessageBox.Show("Connection Open  !");
            //create command and assign the query and connection from the constructor
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query2, connection);


            //Execute command
            cmd.ExecuteNonQuery();
            connection.Close();

        }
    }
}

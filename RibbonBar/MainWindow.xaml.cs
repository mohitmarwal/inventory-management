
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        EmployeeInfo EmployeFrom;
        TableView view;
        Update up;


        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void OnMouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            UIPanel.Children.Remove(view);
            UIPanel.Children.Remove(up);
            view = null;
            up = null;
        
            if (EmployeFrom == null)
            {
                EmployeFrom = new EmployeeInfo();
                UIPanel.Children.Add(EmployeFrom);
            }
            else
            {
                UIPanel.Children.Remove(EmployeFrom);
                EmployeFrom = null;
                EmployeFrom = new EmployeeInfo();
                UIPanel.Children.Add(EmployeFrom);
            }
        }

        private void RibbonApplicationMenuItem_Click(object sender, RoutedEventArgs e)
        {

            UIPanel.Children.Remove(EmployeFrom);
            UIPanel.Children.Remove(view);
            UIPanel.Children.Remove(up);
            up = null;
            EmployeFrom = null;
            view = null;
            view = new TableView();
            UIPanel.Children.Add(view);
            
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            InputDialogSample dialog = new InputDialogSample();
            dialog.ShowDialog();
            UIPanel.Children.Remove(EmployeFrom);
            UIPanel.Children.Remove(view);
            UIPanel.Children.Remove(up);
            up = null;
            EmployeFrom = null;
            view = null;
            up= new Update();
            UIPanel.Children.Add(up);
        }

        private void Onaddpartnerclick(object sender, RoutedEventArgs e)
        {
            RibbonWin.Window2 dialog = new RibbonWin.Window2();
            dialog.ShowDialog();
            UIPanel.Children.Remove(EmployeFrom);
            UIPanel.Children.Remove(view);
            UIPanel.Children.Remove(up);
            up = null;
            EmployeFrom = null;
            view = null;
           
        }
        private void plant_click(object sender, RoutedEventArgs e)
        {
            RibbonWin.plant dialog = new RibbonWin.plant();
            dialog.ShowDialog();
            UIPanel.Children.Remove(EmployeFrom);
            UIPanel.Children.Remove(view);
            UIPanel.Children.Remove(up);
            up = null;
            EmployeFrom = null;
            view = null;

        }
        private void obaddgoodclick(object sender, RoutedEventArgs e)
        {
            RibbonWin.good dialog = new RibbonWin.good();
            dialog.ShowDialog();
            UIPanel.Children.Remove(EmployeFrom);
            UIPanel.Children.Remove(view);
            UIPanel.Children.Remove(up);
            up = null;
            EmployeFrom = null;
            view = null;
        }

        private void onaddbagclick(object sender, RoutedEventArgs e)
        {
            RibbonWin.bag dialog = new RibbonWin.bag();
            dialog.ShowDialog();
            UIPanel.Children.Remove(EmployeFrom);
            UIPanel.Children.Remove(view);
            UIPanel.Children.Remove(up);
            up = null;
            EmployeFrom = null;
            view = null;
        }

        private void onpaymentclick(object sender, RoutedEventArgs e)
        {
            RibbonWin.payment dialog = new RibbonWin.payment();
            dialog.ShowDialog();
            UIPanel.Children.Remove(EmployeFrom);
            UIPanel.Children.Remove(view);
            UIPanel.Children.Remove(up);
            up = null;
            EmployeFrom = null;
            view = null;
        }

        private void partner_click(object sender, RoutedEventArgs e)
        {
            RibbonWin.Window2 dialog = new RibbonWin.Window2();
            dialog.ShowDialog();
            UIPanel.Children.Remove(EmployeFrom);
            UIPanel.Children.Remove(view);
            UIPanel.Children.Remove(up);
            up = null;
            EmployeFrom = null;
            view = null;
        }

        private void on_export(object sender, RoutedEventArgs e)
        {
            try
            {
                RibbonWin.datepicker dialog = new RibbonWin.datepicker();
                dialog.ShowDialog();
                String fromDate = dialog.datePicker1.SelectedDate.Value.Date.ToShortDateString();
                String toDate = dialog.datePicker2.SelectedDate.Value.Date.ToShortDateString();
                UIPanel.Children.Remove(EmployeFrom);
                UIPanel.Children.Remove(view);
                UIPanel.Children.Remove(up);
                up = null;
                EmployeFrom = null;
                view = null;
                SaveFileDialog _SD = new SaveFileDialog();
                _SD.Filter = "csv File (*.csv)|*.csv";
                _SD.FileName = "Untitled";
                _SD.Title = "Save As";
                Nullable<bool> result = _SD.ShowDialog();
                if (result == true)
                {
                    string connetionString;
                    string server = "localhost";
                    string database = "test";
                    string uid = "root";
                    string password = "";
                    MySql.Data.MySqlClient.MySqlConnection connection;
                    string connectionString;
                    MySqlDataAdapter da;
                    DataTable table;
                    connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                       database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


                    connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
                    connection.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * From inventory where (Date BETWEEN '" + fromDate + "'AND '" + toDate + "')", connection);


                    //  MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * From inventory where
                    //(From_date BETWEEN '2013-01-03'AND '2013-01-09'", connection);

                    da = new MySqlDataAdapter(cmd);
                    table = new DataTable("myTable");
                    da.Fill(table);


                    StreamWriter sw = new StreamWriter(_SD.FileName, false);
                    //headers    
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        sw.Write(table.Columns[i]);
                        if (i < table.Columns.Count - 1)
                        {
                            sw.Write(",");
                        }
                    }
                    sw.Write(sw.NewLine);
                    foreach (DataRow dr in table.Rows)
                    {
                        for (int i = 0; i < table.Columns.Count; i++)
                        {
                            if (!Convert.IsDBNull(dr[i]))
                            {
                                string value = dr[i].ToString();
                                if (value.Contains(','))
                                {
                                    value = String.Format("\"{0}\"", value);
                                    sw.Write(value);
                                }
                                else
                                {
                                    sw.Write(dr[i].ToString());
                                }
                            }
                            if (i < table.Columns.Count - 1)
                            {
                                sw.Write(",");
                            }
                        }
                        sw.Write(sw.NewLine);
                    }
                    sw.Close();
                }
            }
            catch (Exception ex) { }
        }

        private void PDF_Click(object sender, RoutedEventArgs e)
        {
            InputDialogSample dialog = new InputDialogSample();
            dialog.ShowDialog();
            string entryno = Update.entryno;
            string connetionString;
            string server = "localhost";
            string database = "test";
            string uid = "root";
            string password = "";
            MySql.Data.MySqlClient.MySqlConnection connection;
            string connectionString = "";
            string DealerSign = "";
            string ProcurerSign = "";
            string vehicleno = "";
            string GoodType = "";
            string Quantity = "";
            string BagTpye = "";
            string RatePerQuintal = "";
            string Commission = "";
            string StandarCharges = "";
            string OtherCharges = "";
            string PaymentMethod = "";
            string Partnername = "";
            string mobilenumber = "";
            string email = "";
            string date = "";
            string time = "";
            string Plant = "";
            string Numberbags = "";
            string FM = "";
            string DM = "";
            string MS = "";
            string TotalAmt = "";
            string paystatus = "";
            string payreceived = "";
            string remark = "";
            string billno = "";
            string Pending = "";
            


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

                Partnername = row.ItemArray[2].ToString();
                mobilenumber = row.ItemArray[3].ToString();
                email= row.ItemArray[4].ToString();
                date= row.ItemArray[5].ToString();
                DealerSign = row.ItemArray[6].ToString();
                ProcurerSign = row.ItemArray[7].ToString();
                vehicleno = row.ItemArray[8].ToString();
                GoodType = row.ItemArray[9].ToString();
                Plant = row.ItemArray[10].ToString();
                Quantity = row.ItemArray[11].ToString();
                BagTpye = row.ItemArray[12].ToString();
                Numberbags = row.ItemArray[13].ToString();
                RatePerQuintal = row.ItemArray[14].ToString();
                Commission = row.ItemArray[15].ToString();
                StandarCharges = row.ItemArray[16].ToString();
                OtherCharges = row.ItemArray[17].ToString();
                FM = row.ItemArray[18].ToString();
                DM = row.ItemArray[19].ToString();
                MS = row.ItemArray[20].ToString();
                TotalAmt = row.ItemArray[21].ToString();
                PaymentMethod = row.ItemArray[22].ToString();
                paystatus = row.ItemArray[23].ToString();
                payreceived = row.ItemArray[24].ToString();
                remark = row.ItemArray[25].ToString();
                billno = row.ItemArray[1].ToString();
                Pending = row.ItemArray[26].ToString();

            }

            connection.Close();
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "My First PDF";
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
          //  PdfSharp.Drawing.XImage logo = PdfSharp.Drawing.XImage.FromFile(@"c:\logo.png");
            XFont font = new XFont("Verdana", 9, XFontStyle.Regular);

            graph.DrawString("Bill No : " + billno, font, XBrushes.Black, new XPoint(450, 50));
            graph.DrawString("Partner Name : "+ Partnername, font, XBrushes.Black, new XPoint(80, 220));
            graph.DrawString("Mobile Number : " + mobilenumber, font, XBrushes.Black, new XPoint(80, 240));
            graph.DrawString("Email Id : " + email, font, XBrushes.Black, new XPoint(80, 260));
            graph.DrawString("Date : " + date, font, XBrushes.Black, new XPoint(80, 280));
            graph.DrawString("Dealer : " + DealerSign, font, XBrushes.Black, new XPoint(80, 300));
            graph.DrawString("Procurer : " + ProcurerSign, font, XBrushes.Black, new XPoint(80, 320));
            graph.DrawString("Transportation : " + vehicleno, font, XBrushes.Black, new XPoint(350, 240));
            graph.DrawString("Good Type : " + GoodType, font, XBrushes.Black, new XPoint(350, 260));
            graph.DrawString("Plant Name : " + Plant, font, XBrushes.Black, new XPoint(350, 280));
            graph.DrawString("Bag Type : " + BagTpye, font, XBrushes.Black, new XPoint(350, 300));

            graph.DrawString("Quantity : " + Quantity, font, XBrushes.Black, new XPoint(80, 400));
            graph.DrawString("No of Bags : " + Numberbags, font, XBrushes.Black, new XPoint(80, 420));
            graph.DrawString("Rate Per Qunintal : " + RatePerQuintal, font, XBrushes.Black, new XPoint(80, 440));
            graph.DrawString("Commission : " + Commission, font, XBrushes.Black, new XPoint(80, 460));
            graph.DrawString("Standard Charges : " + StandarCharges, font, XBrushes.Black, new XPoint(80, 480));
            graph.DrawString("Subtotal : " , font, XBrushes.Black, new XPoint(80, 500));
            graph.DrawString("FM : " + FM, font, XBrushes.Black, new XPoint(320, 400));
            graph.DrawString("DM : " + DM, font, XBrushes.Black, new XPoint(320, 420));
            graph.DrawString("MS : " + MS, font, XBrushes.Black, new XPoint(320, 440));
            graph.DrawString("Other Charges : " + OtherCharges, font, XBrushes.Black, new XPoint(320, 460));
            graph.DrawString("Total Deduction : ", font, XBrushes.Black, new XPoint(320, 480));

            graph.DrawString("Total Amount : " + TotalAmt, font, XBrushes.Black, new XPoint(80, 590));
            graph.DrawString("Payment Method : " + PaymentMethod, font, XBrushes.Black, new XPoint(80, 610));
            graph.DrawString("Payment Status : " + paystatus, font, XBrushes.Black, new XPoint(80, 630));
            graph.DrawString("Total Received Amount : " + payreceived, font, XBrushes.Black, new XPoint(80, 650));
            graph.DrawString("Remarks : " + remark, font, XBrushes.Black, new XPoint(80, 670));
            graph.DrawString("Total Pending : " + Pending, font, XBrushes.Black, new XPoint(320, 590));
            graph.DrawString("Signature/Stamp : " , font, XBrushes.Black, new XPoint(80, 740));

            // graph.DrawImage(logo,new XPoint(pdfPage.Width/2.6, 10));
            graph.DrawRectangle(XPens.Black, new XRect(new XPoint(50, 200), new XPoint(550, 350)));
            graph.DrawRectangle(XPens.Black, new XRect(new XPoint(50, 370), new XPoint(550, 550)));
            graph.DrawRectangle(XPens.Black, new XRect(new XPoint(50, 570), new XPoint(550, 700)));
            graph.DrawRectangle(XPens.Black, new XRect(new XPoint(50, 720), new XPoint(550, 800)));
            graph.DrawLine(XPens.Black, new XPoint(300,370), new XPoint(300,550));
            SaveFileDialog _SD = new SaveFileDialog();
            _SD.Filter = "PDF File (*.pdf)|*.pdf";
            _SD.FileName = "Untitled";
            _SD.Title = "Save As";
            Nullable<bool> result = _SD.ShowDialog();
            if (result == true)
            {
                // Save PDF 
                pdf.Save(_SD.FileName);
                Process.Start(_SD.FileName);
            }
        }
    }
}

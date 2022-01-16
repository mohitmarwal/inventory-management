using System;
using System.Collections.Generic;
using System.Data;
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
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void OnMouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            UIPanel.Children.Remove(view);
            view = null;
        
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
            EmployeFrom = null;
            view = null;
            Update up= new Update();
            UIPanel.Children.Add(up);
        }


    }
}

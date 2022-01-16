﻿using System;
using System.Collections.Generic;
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
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void OnMouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
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
    }
}

﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D2813549EF22218F75AC979C7AD3E1586849048C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace RibbonWin {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Controls.Ribbon.RibbonWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.Ribbon RibbonWin;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonTab ribbontab;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonGroup ClipboardGroup;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonApplicationMenuItem update;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonTab Admintab;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonGroup ClipboardGroup1;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel UIPanel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Inventory App;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.RibbonWin = ((System.Windows.Controls.Ribbon.Ribbon)(target));
            return;
            case 2:
            this.ribbontab = ((System.Windows.Controls.Ribbon.RibbonTab)(target));
            return;
            case 3:
            this.ClipboardGroup = ((System.Windows.Controls.Ribbon.RibbonGroup)(target));
            return;
            case 4:
            
            #line 37 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OnMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.update = ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target));
            
            #line 39 "..\..\MainWindow.xaml"
            this.update.Click += new System.Windows.RoutedEventHandler(this.Update_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 41 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.RibbonApplicationMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 43 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.PDF_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Admintab = ((System.Windows.Controls.Ribbon.RibbonTab)(target));
            return;
            case 9:
            this.ClipboardGroup1 = ((System.Windows.Controls.Ribbon.RibbonGroup)(target));
            return;
            case 10:
            
            #line 53 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.partner_click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 55 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.plant_click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 57 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.obaddgoodclick);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 59 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.onaddbagclick);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 61 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.onpaymentclick);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 64 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.onaddbrokerclick);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 66 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.on_export);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 68 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.on_pass);
            
            #line default
            #line hidden
            return;
            case 18:
            this.UIPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


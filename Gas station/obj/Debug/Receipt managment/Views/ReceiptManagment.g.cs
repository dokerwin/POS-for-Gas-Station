#pragma checksum "..\..\..\..\Receipt managment\Views\ReceiptManagment.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B80CE4CBFF9B793ED56186908B74AD838B787257832FCE60612A20CDA53E1195"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Gas_station.Receipt_managment.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Gas_station.Receipt_managment.Views {
    
    
    /// <summary>
    /// ReceiptManagment
    /// </summary>
    public partial class ReceiptManagment : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\Receipt managment\Views\ReceiptManagment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView receiptListView;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Receipt managment\Views\ReceiptManagment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button topOrders;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Receipt managment\Views\ReceiptManagment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Id_receipt_txt;
        
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
            System.Uri resourceLocater = new System.Uri("/Gas station;component/receipt%20managment/views/receiptmanagment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Receipt managment\Views\ReceiptManagment.xaml"
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
            this.receiptListView = ((System.Windows.Controls.ListView)(target));
            
            #line 15 "..\..\..\..\Receipt managment\Views\ReceiptManagment.xaml"
            this.receiptListView.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.receiptList_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\..\Receipt managment\Views\ReceiptManagment.xaml"
            this.receiptListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.receiptListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.topOrders = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\Receipt managment\Views\ReceiptManagment.xaml"
            this.topOrders.Click += new System.Windows.RoutedEventHandler(this.topOrders_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Id_receipt_txt = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\..\Receipt managment\Views\ReceiptManagment.xaml"
            this.Id_receipt_txt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Id_receipt_txt_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\Customer managment\Views\AddCustomer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "25C53A8326E8852A7E616A8DED5521AA4D5F6A55225B42256A2548AA05F211B6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Gas_station.Customer_managment.Views;
using Gas_station.Validation;
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


namespace Gas_station.Customer_managment.Views {
    
    
    /// <summary>
    /// AddCustomer
    /// </summary>
    public partial class AddCustomer : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 71 "..\..\..\..\Customer managment\Views\AddCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox person_surname_txt;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Customer managment\Views\AddCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox age_txt;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\Customer managment\Views\AddCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phone_txt;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\..\Customer managment\Views\AddCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SexBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Gas station;component/customer%20managment/views/addcustomer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Customer managment\Views\AddCustomer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.person_surname_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.age_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.phone_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.SexBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 153 "..\..\..\..\Customer managment\Views\AddCustomer.xaml"
            this.SexBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SexBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 155 "..\..\..\..\Customer managment\Views\AddCustomer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddCustomer_btn);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


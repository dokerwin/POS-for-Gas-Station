#pragma checksum "..\..\..\..\LoyaltyCard mamagment\Views\CardManagment.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B55D86397308048554D9CD9C030CB7EF9E4D20F6CE00B330B8A2F833A1F47DC7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Gas_station.LoyaltyCard_mamagment.Views;
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


namespace Gas_station.LoyaltyCard_mamagment.Views {
    
    
    /// <summary>
    /// CardManagment
    /// </summary>
    public partial class CardManagment : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\LoyaltyCard mamagment\Views\CardManagment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button checkBalance_btn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\LoyaltyCard mamagment\Views\CardManagment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button topUp_btn;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\LoyaltyCard mamagment\Views\CardManagment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label balance_lbl;
        
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
            System.Uri resourceLocater = new System.Uri("/Gas station;component/loyaltycard%20mamagment/views/cardmanagment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\LoyaltyCard mamagment\Views\CardManagment.xaml"
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
            this.checkBalance_btn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\LoyaltyCard mamagment\Views\CardManagment.xaml"
            this.checkBalance_btn.Click += new System.Windows.RoutedEventHandler(this.checkBalance_btn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.topUp_btn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\LoyaltyCard mamagment\Views\CardManagment.xaml"
            this.topUp_btn.Click += new System.Windows.RoutedEventHandler(this.topUp_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.balance_lbl = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


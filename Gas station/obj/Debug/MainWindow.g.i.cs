﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "99FCFD9EFDE20C125A11E2129F0CA97B9067F3BD968FC88C2F68DC70CB8D0205"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Gas_station;
using HamburgerMenu;
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
using WpfPageTransitions;


namespace Gas_station {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Main;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfPageTransitions.PageTransition pageTransitionControl;
        
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
            System.Uri resourceLocater = new System.Uri("/Gas station;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.Main = ((System.Windows.Controls.Frame)(target));
            
            #line 15 "..\..\MainWindow.xaml"
            this.Main.Navigating += new System.Windows.Navigation.NavigatingCancelEventHandler(this.MainFrame_OnNavigating);
            
            #line default
            #line hidden
            return;
            case 2:
            this.pageTransitionControl = ((WpfPageTransitions.PageTransition)(target));
            return;
            case 3:
            
            #line 38 "..\..\MainWindow.xaml"
            ((HamburgerMenu.HamburgerMenuItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.PosWindowSelected);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 39 "..\..\MainWindow.xaml"
            ((HamburgerMenu.HamburgerMenuItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.CustomerManagmentSelected);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 40 "..\..\MainWindow.xaml"
            ((HamburgerMenu.HamburgerMenuItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ProductManagmentSelected);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 41 "..\..\MainWindow.xaml"
            ((HamburgerMenu.HamburgerMenuItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ShiftManagmentSelected);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 42 "..\..\MainWindow.xaml"
            ((HamburgerMenu.HamburgerMenuItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.CardManagmentSelected);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 43 "..\..\MainWindow.xaml"
            ((HamburgerMenu.HamburgerMenuItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.FuelManagmentSelected);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 44 "..\..\MainWindow.xaml"
            ((HamburgerMenu.HamburgerMenuItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.OredersManagmentSelected);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


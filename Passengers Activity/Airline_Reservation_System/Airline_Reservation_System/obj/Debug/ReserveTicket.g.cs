﻿#pragma checksum "..\..\ReserveTicket.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0EAC016136F193CC8302CA52CE5E32EE"
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


namespace Airline_Reservation_System {
    
    
    /// <summary>
    /// ReserveTicket
    /// </summary>
    public partial class ReserveTicket : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ReserveTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fromAirport;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ReserveTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox toAirport;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ReserveTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox T_Type;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ReserveTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox T_Fare;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ReserveTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button print_tkt;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ReserveTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelTCK;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ReserveTicket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backRT;
        
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
            System.Uri resourceLocater = new System.Uri("/Airline_Reservation_System;component/reserveticket.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ReserveTicket.xaml"
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
            this.fromAirport = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.toAirport = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.T_Type = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.T_Fare = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.print_tkt = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\ReserveTicket.xaml"
            this.print_tkt.Click += new System.Windows.RoutedEventHandler(this.print_tkt_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cancelTCK = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\ReserveTicket.xaml"
            this.cancelTCK.Click += new System.Windows.RoutedEventHandler(this.cancelTCK_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.backRT = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\ReserveTicket.xaml"
            this.backRT.Click += new System.Windows.RoutedEventHandler(this.backRT_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


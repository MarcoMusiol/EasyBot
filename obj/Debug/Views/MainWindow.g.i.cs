﻿#pragma checksum "..\..\..\Views\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AAD5B98463BE3707FF4FE0D37A1D5B03D06CCD3B1E3FBFA26F5AA1EE830615A1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using EasyBot.Views;
using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
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


namespace EasyBot.Views {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBox_Actions;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Deselect;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_UP;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_DOWN;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Start;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Add;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Settings;
        
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
            System.Uri resourceLocater = new System.Uri("/EasyBot;component/views/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainWindow.xaml"
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
            this.ListBox_Actions = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.Button_Deselect = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Views\MainWindow.xaml"
            this.Button_Deselect.Click += new System.Windows.RoutedEventHandler(this.Button_Deselect_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Button_UP = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\Views\MainWindow.xaml"
            this.Button_UP.Click += new System.Windows.RoutedEventHandler(this.Button_UP_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Button_DOWN = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\Views\MainWindow.xaml"
            this.Button_DOWN.Click += new System.Windows.RoutedEventHandler(this.Button_DOWN_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Button_Start = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.Button_Add = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\Views\MainWindow.xaml"
            this.Button_Add.Click += new System.Windows.RoutedEventHandler(this.Button_Add_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Button_Settings = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\Views\MainWindow.xaml"
            this.Button_Settings.Click += new System.Windows.RoutedEventHandler(this.Button_Settings_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "527A5180703CBB11198C6F192A64CF7FCCD5EC10"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Calculator;
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


namespace Calculator {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Screen;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button7;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button8;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button9;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button4;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button5;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button6;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button1;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button2;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button3;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Buttonce;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button0;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Buttonequal;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Calculator;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Screen = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Button7 = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\MainWindow.xaml"
            this.Button7.Click += new System.Windows.RoutedEventHandler(this.MyButton7_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Button8 = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\MainWindow.xaml"
            this.Button8.Click += new System.Windows.RoutedEventHandler(this.MyButton8_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Button9 = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\MainWindow.xaml"
            this.Button9.Click += new System.Windows.RoutedEventHandler(this.MyButton9_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Button4 = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\MainWindow.xaml"
            this.Button4.Click += new System.Windows.RoutedEventHandler(this.MyButton4_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Button5 = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\MainWindow.xaml"
            this.Button5.Click += new System.Windows.RoutedEventHandler(this.MyButton5_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Button6 = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\MainWindow.xaml"
            this.Button6.Click += new System.Windows.RoutedEventHandler(this.MyButton6_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Button1 = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\MainWindow.xaml"
            this.Button1.Click += new System.Windows.RoutedEventHandler(this.MyButton1_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Button2 = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\MainWindow.xaml"
            this.Button2.Click += new System.Windows.RoutedEventHandler(this.MyButton2_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Button3 = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\MainWindow.xaml"
            this.Button3.Click += new System.Windows.RoutedEventHandler(this.MyButton3_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Buttonce = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\MainWindow.xaml"
            this.Buttonce.Click += new System.Windows.RoutedEventHandler(this.MyButtonCE_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Button0 = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\MainWindow.xaml"
            this.Button0.Click += new System.Windows.RoutedEventHandler(this.MyButton0_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Buttonequal = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\MainWindow.xaml"
            this.Buttonequal.Click += new System.Windows.RoutedEventHandler(this.MyButtonequal_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


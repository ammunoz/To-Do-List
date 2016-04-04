﻿#pragma checksum "..\..\LoginPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9C52EF264504824515E608054A859EAB"
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
using ToDoList;


namespace ToDoList {
    
    
    /// <summary>
    /// LoginPage
    /// </summary>
    public partial class LoginPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 160 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox usernameBox;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordBox;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label passwordLabel;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label registerLabel;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label error_message;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
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
            System.Uri resourceLocater = new System.Uri("/ToDoList;component/loginpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LoginPage.xaml"
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
            this.usernameBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 160 "..\..\LoginPage.xaml"
            this.usernameBox.GotFocus += new System.Windows.RoutedEventHandler(this.usernameBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 160 "..\..\LoginPage.xaml"
            this.usernameBox.LostFocus += new System.Windows.RoutedEventHandler(this.usernameBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.passwordBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 161 "..\..\LoginPage.xaml"
            this.passwordBox.GotFocus += new System.Windows.RoutedEventHandler(this.passwordBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 161 "..\..\LoginPage.xaml"
            this.passwordBox.LostFocus += new System.Windows.RoutedEventHandler(this.passwordBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.passwordLabel = ((System.Windows.Controls.Label)(target));
            
            #line 162 "..\..\LoginPage.xaml"
            this.passwordLabel.GotFocus += new System.Windows.RoutedEventHandler(this.passwordLabel_GotFocus);
            
            #line default
            #line hidden
            
            #line 162 "..\..\LoginPage.xaml"
            this.passwordLabel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.passwordLabel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 163 "..\..\LoginPage.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.registerLabel = ((System.Windows.Controls.Label)(target));
            
            #line 173 "..\..\LoginPage.xaml"
            this.registerLabel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.registerLabel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.error_message = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


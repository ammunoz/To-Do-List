﻿#pragma checksum "..\..\AddClassWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "193373D243B78BD5A3B8AE2303A5631C"
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


namespace ToDoList {
    
    
    /// <summary>
    /// AddClassWindow
    /// </summary>
    public partial class AddClassWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 269 "..\..\AddClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addClassBox;
        
        #line default
        #line hidden
        
        
        #line 270 "..\..\AddClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button doneButton;
        
        #line default
        #line hidden
        
        
        #line 271 "..\..\AddClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
        #line default
        #line hidden
        
        
        #line 272 "..\..\AddClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 273 "..\..\AddClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer scroll;
        
        #line default
        #line hidden
        
        
        #line 274 "..\..\AddClassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel memberList;
        
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
            System.Uri resourceLocater = new System.Uri("/ToDoList;component/addclasswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddClassWindow.xaml"
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
            
            #line 6 "..\..\AddClassWindow.xaml"
            ((ToDoList.AddClassWindow)(target)).ContentRendered += new System.EventHandler(this.Window_ContentRendered);
            
            #line default
            #line hidden
            return;
            case 2:
            this.addClassBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 269 "..\..\AddClassWindow.xaml"
            this.addClassBox.GotFocus += new System.Windows.RoutedEventHandler(this.addClassBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 269 "..\..\AddClassWindow.xaml"
            this.addClassBox.LostFocus += new System.Windows.RoutedEventHandler(this.addClassBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.doneButton = ((System.Windows.Controls.Button)(target));
            
            #line 270 "..\..\AddClassWindow.xaml"
            this.doneButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.doneButton_MouseDown);
            
            #line default
            #line hidden
            
            #line 270 "..\..\AddClassWindow.xaml"
            this.doneButton.Click += new System.Windows.RoutedEventHandler(this.doneButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.scroll = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 7:
            this.memberList = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


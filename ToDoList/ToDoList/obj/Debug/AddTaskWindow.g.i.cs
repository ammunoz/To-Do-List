﻿#pragma checksum "..\..\AddTaskWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "47AA712599443000FD710EAF5123AF70"
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
    /// AddTaskWindow
    /// </summary>
    public partial class AddTaskWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 104 "..\..\AddTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addTaskBox;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\AddTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button doneButton;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\AddTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\AddTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\AddTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Month;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\AddTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Day;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\AddTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Year;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\AddTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox description;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\AddTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\AddTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
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
            System.Uri resourceLocater = new System.Uri("/ToDoList;component/addtaskwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddTaskWindow.xaml"
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
            this.addTaskBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 104 "..\..\AddTaskWindow.xaml"
            this.addTaskBox.GotFocus += new System.Windows.RoutedEventHandler(this.addTaskBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 104 "..\..\AddTaskWindow.xaml"
            this.addTaskBox.LostFocus += new System.Windows.RoutedEventHandler(this.addTaskBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.doneButton = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\AddTaskWindow.xaml"
            this.doneButton.Click += new System.Windows.RoutedEventHandler(this.doneButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.comboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.Month = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.Day = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.Year = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.description = ((System.Windows.Controls.TextBox)(target));
            
            #line 147 "..\..\AddTaskWindow.xaml"
            this.description.GotFocus += new System.Windows.RoutedEventHandler(this.description_GotFocus);
            
            #line default
            #line hidden
            
            #line 147 "..\..\AddTaskWindow.xaml"
            this.description.LostFocus += new System.Windows.RoutedEventHandler(this.description_LostFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\PresentationLayer\ProductWindowView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A271D62EA74537E79A85D0F9D3FA5412858A0EB9"
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
using WPF_MasterDetailApp.PresentationLayer;


namespace WPF_MasterDetailApp {
    
    
    /// <summary>
    /// ProductWindowView
    /// </summary>
    public partial class ProductWindowView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\PresentationLayer\ProductWindowView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WPF_MasterDetailApp.ProductWindowView ListWindow;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\PresentationLayer\ProductWindowView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_Search;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\PresentationLayer\ProductWindowView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Search;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\PresentationLayer\ProductWindowView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBox_ProductList;
        
        #line default
        #line hidden
        
        
        #line 223 "..\..\..\PresentationLayer\ProductWindowView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Add;
        
        #line default
        #line hidden
        
        
        #line 231 "..\..\..\PresentationLayer\ProductWindowView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Delete;
        
        #line default
        #line hidden
        
        
        #line 239 "..\..\..\PresentationLayer\ProductWindowView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Quit;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_MasterDetailApp;component/presentationlayer/productwindowview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PresentationLayer\ProductWindowView.xaml"
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
            this.ListWindow = ((WPF_MasterDetailApp.ProductWindowView)(target));
            return;
            case 2:
            this.TextBox_Search = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Button_Search = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\PresentationLayer\ProductWindowView.xaml"
            this.Button_Search.Click += new System.Windows.RoutedEventHandler(this.Button_Search_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListBox_ProductList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.Button_Add = ((System.Windows.Controls.Button)(target));
            
            #line 229 "..\..\..\PresentationLayer\ProductWindowView.xaml"
            this.Button_Add.Click += new System.Windows.RoutedEventHandler(this.Button_Add_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Button_Delete = ((System.Windows.Controls.Button)(target));
            
            #line 237 "..\..\..\PresentationLayer\ProductWindowView.xaml"
            this.Button_Delete.Click += new System.Windows.RoutedEventHandler(this.Button_Delete_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Button_Quit = ((System.Windows.Controls.Button)(target));
            
            #line 246 "..\..\..\PresentationLayer\ProductWindowView.xaml"
            this.Button_Quit.Click += new System.Windows.RoutedEventHandler(this.Button_Quit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


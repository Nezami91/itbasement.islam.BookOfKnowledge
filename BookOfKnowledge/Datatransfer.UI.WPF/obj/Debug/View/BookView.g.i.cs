﻿#pragma checksum "..\..\..\View\BookView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3C6886025886E4BE052D18D2766D6F0DDA7F8A4121FD2236899F6F3C2CAF370F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Datatransfer.UI.WPF.View;
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


namespace Datatransfer.UI.WPF.View {
    
    
    /// <summary>
    /// BookView
    /// </summary>
    public partial class BookView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\View\BookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtGetList;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\BookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtCreate_Update;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\BookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtDelete;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\View\BookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListBookView;
        
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
            System.Uri resourceLocater = new System.Uri("/Datatransfer.UI.WPF;component/view/bookview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\BookView.xaml"
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
            this.BtGetList = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\View\BookView.xaml"
            this.BtGetList.Click += new System.Windows.RoutedEventHandler(this.Button_GetList);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtCreate_Update = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\View\BookView.xaml"
            this.BtCreate_Update.Click += new System.Windows.RoutedEventHandler(this.Button_Create_Update);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtDelete = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\View\BookView.xaml"
            this.BtDelete.Click += new System.Windows.RoutedEventHandler(this.Button_Delete);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListBookView = ((System.Windows.Controls.ListView)(target));
            
            #line 19 "..\..\..\View\BookView.xaml"
            this.ListBookView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBookView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


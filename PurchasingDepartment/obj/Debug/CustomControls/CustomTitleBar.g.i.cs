﻿#pragma checksum "..\..\..\CustomControls\CustomTitleBar.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "59BE9865ADAF6D226B5BA31DE6497FC5174401283125B0755B0F624D3BF8A24D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PurchasingDepartment.CommonComands;
using PurchasingDepartment.CustomControls;
using PurchasingDepartment.Views;
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


namespace PurchasingDepartment.CustomControls {
    
    
    /// <summary>
    /// CustomTitleBar
    /// </summary>
    public partial class CustomTitleBar : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\CustomControls\CustomTitleBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PurchasingDepartment.CustomControls.CustomTitleBar TitleBar;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\CustomControls\CustomTitleBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdTitleBar;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\CustomControls\CustomTitleBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinimizeButton;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\CustomControls\CustomTitleBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExpandButton;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\CustomControls\CustomTitleBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
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
            System.Uri resourceLocater = new System.Uri("/PurchasingDepartment;component/customcontrols/customtitlebar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CustomControls\CustomTitleBar.xaml"
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
            this.TitleBar = ((PurchasingDepartment.CustomControls.CustomTitleBar)(target));
            
            #line 13 "..\..\..\CustomControls\CustomTitleBar.xaml"
            this.TitleBar.MouseMove += new System.Windows.Input.MouseEventHandler(this.TitleBar_MouseMove);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\CustomControls\CustomTitleBar.xaml"
            this.TitleBar.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TitleBar_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\CustomControls\CustomTitleBar.xaml"
            this.TitleBar.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.TitleBar_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grdTitleBar = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.MinimizeButton = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\..\CustomControls\CustomTitleBar.xaml"
            this.MinimizeButton.Click += new System.Windows.RoutedEventHandler(this.MinimizeButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ExpandButton = ((System.Windows.Controls.Button)(target));
            
            #line 124 "..\..\..\CustomControls\CustomTitleBar.xaml"
            this.ExpandButton.Click += new System.Windows.RoutedEventHandler(this.ExpandButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 128 "..\..\..\CustomControls\CustomTitleBar.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


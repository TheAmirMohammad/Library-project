﻿#pragma checksum "..\..\..\..\Pages\Member\MemberPanel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "136CA922346B8DEF0B239BF040754428E87CF43A3CF6E6708BEA063B76B7B30E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Library_Manager {
    
    
    /// <summary>
    /// MemberPanel
    /// </summary>
    public partial class MemberPanel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\Pages\Member\MemberPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button close_btn;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\..\Pages\Member\MemberPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame memberFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/Library Manager;component/pages/member/memberpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Member\MemberPanel.xaml"
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
            
            #line 29 "..\..\..\..\Pages\Member\MemberPanel.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.drag);
            
            #line default
            #line hidden
            return;
            case 2:
            this.close_btn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Pages\Member\MemberPanel.xaml"
            this.close_btn.Click += new System.Windows.RoutedEventHandler(this.exit);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 74 "..\..\..\..\Pages\Member\MemberPanel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.home_btn);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 82 "..\..\..\..\Pages\Member\MemberPanel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.edit_member_btn);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 90 "..\..\..\..\Pages\Member\MemberPanel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.books_btn);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 98 "..\..\..\..\Pages\Member\MemberPanel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.mybooks_btn);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 106 "..\..\..\..\Pages\Member\MemberPanel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.subs_btn);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 114 "..\..\..\..\Pages\Member\MemberPanel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bud_btn);
            
            #line default
            #line hidden
            return;
            case 9:
            this.memberFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


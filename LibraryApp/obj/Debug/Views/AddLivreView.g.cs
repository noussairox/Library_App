﻿#pragma checksum "..\..\..\Views\AddLivreView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D2CCFB28AED8EBBBD10B3BBA44609282B217BB87016B28C4FE5C934B2BA4B640"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using LibraryApp.Views;
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


namespace LibraryApp.Views {
    
    
    /// <summary>
    /// AddLivreView
    /// </summary>
    public partial class AddLivreView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Views\AddLivreView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TitreTextBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\AddLivreView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AuteurTextBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Views\AddLivreView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ISBNTextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Views\AddLivreView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePublicationDatePicker;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Views\AddLivreView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QuantiteDisponibleTextBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Views\AddLivreView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid LivresDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/LibraryApp;component/views/addlivreview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AddLivreView.xaml"
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
            this.TitreTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.AuteurTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ISBNTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DatePublicationDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.QuantiteDisponibleTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 43 "..\..\..\Views\AddLivreView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AjouterLivreBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LivresDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 46 "..\..\..\Views\AddLivreView.xaml"
            this.LivresDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LivresDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 64 "..\..\..\Views\AddLivreView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteLivreBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 65 "..\..\..\Views\AddLivreView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateLivreBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


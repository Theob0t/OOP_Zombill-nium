﻿#pragma checksum "..\..\CreerPerso.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5CB23B8C78A44C8333F2AE81F9B7DA89F7D388FA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using PFR_Rendu3;
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


namespace PFR_Rendu3 {
    
    
    /// <summary>
    /// CreerPerso
    /// </summary>
    public partial class CreerPerso : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 64 "..\..\CreerPerso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox saisiFonction;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\CreerPerso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox saisiMatrice;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\CreerPerso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox saisiNom;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\CreerPerso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox saisiPrenom;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\CreerPerso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox saisiSexe;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\CreerPerso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Valid;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\CreerPerso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReInit;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\CreerPerso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Menu;
        
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
            System.Uri resourceLocater = new System.Uri("/PFR_Rendu3;component/creerperso.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreerPerso.xaml"
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
            this.saisiFonction = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.saisiMatrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.saisiNom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.saisiPrenom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.saisiSexe = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Valid = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\CreerPerso.xaml"
            this.Valid.Click += new System.Windows.RoutedEventHandler(this.Valid_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ReInit = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\CreerPerso.xaml"
            this.ReInit.Click += new System.Windows.RoutedEventHandler(this.ReInit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Menu = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\CreerPerso.xaml"
            this.Menu.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


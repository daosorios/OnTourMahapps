﻿#pragma checksum "..\..\AutoRegistro.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D9239EA93D8BB8A7881EF34AC98F7DE4C169B967D1813EDDD5428768345A916D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Behaviours;
using MahApps.Metro.Controls;
using ProyectoBeLife;
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
using System.Windows.Interactivity;
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


namespace ProyectoBeLife {
    
    
    /// <summary>
    /// AutoRegistro
    /// </summary>
    public partial class AutoRegistro : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 69 "..\..\AutoRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbCorreoRegistro;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\AutoRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbNombreRegistro;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\AutoRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbRutRegistro;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\AutoRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbCursoRegistro;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\AutoRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbInstituRegistro;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\AutoRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox TxbContraseñaRegistro;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\AutoRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtAutoRegistrar;
        
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
            System.Uri resourceLocater = new System.Uri("/ProyectoBeLife;component/autoregistro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AutoRegistro.xaml"
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
            this.TxbCorreoRegistro = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TxbNombreRegistro = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TxbRutRegistro = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TxbCursoRegistro = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TxbInstituRegistro = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TxbContraseñaRegistro = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.BtAutoRegistrar = ((System.Windows.Controls.Button)(target));
            
            #line 180 "..\..\AutoRegistro.xaml"
            this.BtAutoRegistrar.Click += new System.Windows.RoutedEventHandler(this.BtAutoRegistrar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


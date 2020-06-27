using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;

namespace ProyectoBeLife
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public Acceso acceso = new Acceso();
        public Curso registroCurso = new Curso();
        public AutoRegistro autoRegistro = new AutoRegistro();

        public MainWindow()
        {
            InitializeComponent();

            acceso.ControladorAcceso = this;
            registroCurso.ControladorRegistroCurso = this;
            autoRegistro.ControladoAutoregistro = this; 
            miFrame.NavigationService.Navigate(acceso);
        }

        private void miFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}

using OnTour.Negocio;
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

namespace ProyectoBeLife
{
    /// <summary>
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Acceso : Page
    {
        public static int numid;
        public MainWindow ControladorAcceso;
        public Acceso()
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, RoutedEventArgs e)
        {
            usuarios usu = new usuarios()
            {
                correo = TxbCorreoIngreso.Text
            };

            if (usu.Read())
            {
                if (usu.tipo.Equals("E"))
                {
                    numid = usu.id;
                    ControladorAcceso.miFrame.NavigationService.Navigate(ControladorAcceso.registroCurso);
                }
                else if (usu.tipo.Equals("A")) {
                    numid = usu.id;
                    ControladorAcceso.apoderado.buscarUsuario();
                    ControladorAcceso.miFrame.NavigationService.Navigate(ControladorAcceso.apoderado);
                    
                }


            }
            else
            {
                MessageBox.Show("Intente nuevamente, este usuario no existe");
            }


        }

        private void BtAutoReg_Click(object sender, RoutedEventArgs e)
        {
            ControladorAcceso.miFrame.NavigationService.Navigate(ControladorAcceso.autoRegistro);
        }
    }
}

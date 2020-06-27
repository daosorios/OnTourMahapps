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
    /// Lógica de interacción para AutoRegistro.xaml
    /// </summary>
    public partial class AutoRegistro : Page
    {
       
        
        public MainWindow ControladoAutoregistro;
        public AutoRegistro()
        {
            InitializeComponent();
        }

        private  void BtAutoRegistrar_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int idrandom= rnd.Next(1, 1000);
            usuarios usu = new usuarios()
            {
                correo = TxbCorreoRegistro.Text,
                contra = TxbContraseñaRegistro.Password,
                id = idrandom,
                tipo = "A"

            };

            if (usu.Create())
            {
                Personas per = new Personas()
                {
                    id_persona = idrandom,
                    nombre = TxbNombreRegistro.Text,
                    rut = TxbRutRegistro.Text,

                };

                if (per.Create())
                {
                    MessageBox.Show("Apoderado regsitrado exitosamente");
                    ControladoAutoregistro.miFrame.NavigationService.Navigate(ControladoAutoregistro.acceso);
                }
                else
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Apoderado no pudi ser regsitrado ");
            }


 
        }
    }
}

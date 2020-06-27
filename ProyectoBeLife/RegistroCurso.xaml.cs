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
using OnTour.Negocio;

namespace ProyectoBeLife
{
    /// <summary>
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class RegistroCurso : Page
    {
        public MainWindow ControladorRegistroCurso;
        public RegistroCurso()
        {
            InitializeComponent();
            CargarCurso();
        }

        private void BtAgregar_Click(object sender, RoutedEventArgs e)
        {
            
            Random rnd = new Random();
            int idrandom = rnd.Next(1, 1000);

            Curso cur = new Curso()
            {

                id_ejecutivo = Acceso.numid,
                curso1 = TxbCurso.Text,
                institucion = TxbInstitución.Text,
                cantidad = int.Parse(TxbCantidad.Text)
            };

            if (cur.Create())
            {
                MessageBox.Show("Curso Registrado exitosamente");
            }
            else
            {
                MessageBox.Show("Curso no pudo ser Registrado ");
            }
        }

        private void BtBuscar_Click(object sender, RoutedEventArgs e)
        {
            Curso cur = new Curso()
            {
                curso1 = TxbCurso.Text
            };

            if (cur.Read())
            {                
                TxbCurso.Text = cur.curso1;
                TxbInstitución.Text = cur.institucion;
                TxbCantidad.Text = cur.cantidad.ToString();

                MessageBox.Show("Curso leído", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Cliente no pudo ser leído", "Información", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        

        //revisar despues 
        private void BtModificar_Click(object sender, RoutedEventArgs e)
        {
            Curso cur = new Curso()
            {
                curso1 = TxbCurso.Text,
                institucion = TxbInstitución.Text,
                cantidad =int.Parse(TxbCantidad.Text)
           
            };

            if (cur.Update())
            {
                MessageBox.Show("Curso Actualizado", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
               
            }
            else
            {
                MessageBox.Show("Curso no pudo ser modificado", "Atención", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        public void CargarCurso()
        {
            //cargar los empleados en la data grid 
            Curso cursos = new Curso();
            DgCurso.ItemsSource = cursos.ReadAll();


        }

        private void BtEliminar_Click(object sender, RoutedEventArgs e)
        {
            Curso cur = new Curso()
            {
                curso1 = TxbCurso.Text
            };
            if (cur.Delete())
            {
                MessageBox.Show("Curso eliminado", "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
                //Limpiar();

            }
            else
            {
                MessageBox.Show("Curso no pudo ser eliminado", "Atención", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }


        private void BtRefresh_Click(object sender, RoutedEventArgs e)
        {
            CargarCurso();
        }
    }
}

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
            CargarContrato();
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
                Limpiar();
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
                Limpiar();
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
                Limpiar();

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


        //Contrato Crud
        private void BtCrearCont_Click(object sender, RoutedEventArgs e)
        {
            Contratos con = new Contratos()

            {
                id_ejec=Acceso.numid,                
                institucion=TxbInstContra.Text,
                curso=TxbCursoContra.Text,
                cantidad=int.Parse(TxbCantContra.Text),
                nombre_rep= TxbNombRContra.Text,
                rut_rep= TxbCRutRContra.Text,
                correo_rep= TxbCorreoRContra.Text,
                seguro=CbSeguroContra.SelectedIndex.ToString(),
                destino=CbDestinoContra.SelectedIndex.ToString(),
                costo=int.Parse(TxbCostoContra.Text)
            };


            if (con.Create())
            {
                MessageBox.Show("Contrato registrado exitosamente", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Contrato no pudo ser registrado", "Atención", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void BtBuscarCont_Click(object sender, RoutedEventArgs e)
        {
            Contratos con = new Contratos()
            {
                rut_rep = txbRutRepBusca.Text
            };

            if (con.Read())
            {
                TxbInstContra.Text = con.institucion;
                TxbCursoContra.Text = con.curso;
                TxbCantContra.Text= con.cantidad.ToString();
                TxbNombRContra.Text = con.nombre_rep;
                TxbCRutRContra.Text = con.rut_rep;
                TxbCorreoRContra.Text = con.correo_rep;
                CbSeguroContra.SelectedItem = con.seguro;
                CbDestinoContra.SelectedItem = con.destino;
                TxbCostoContra.Text = con.costo.ToString();

                               
                MessageBox.Show("Contrato leído", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Ccontrato no pudo ser leído", "Atención", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void BtModificarCont_Click(object sender, RoutedEventArgs e)
        {
            Contratos con = new Contratos()
            {
                institucion = TxbInstContra.Text,
                curso = TxbCursoContra.Text,
                cantidad = int.Parse(TxbCantContra.Text),
                nombre_rep = TxbNombRContra.Text,
                rut_rep = TxbCRutRContra.Text,
                correo_rep=TxbCorreoRContra.Text,
                seguro=CbSeguroContra.SelectedIndex.ToString(),
                destino=CbDestinoContra.SelectedIndex.ToString(),
                costo=int.Parse(TxbCostoContra.Text)
            
                
            };

            if (con.Update())
            {
                MessageBox.Show("Contrato modificado", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Contrato no pudo ser kodificado", "Atención", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void BtEliminarCont_Click(object sender, RoutedEventArgs e)
        {
            //eliminar al cliente 
            Contratos con = new Contratos()
            {
                rut_rep = TxbCRutRContra.Text
            };
            if (con.Delete())
            {
                MessageBox.Show("Contrato eliminado", "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
                Limpiar();

            }
            else
            {
                MessageBox.Show("Contrato no pudo ser eliminado", "Atención", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void CargarContrato()
        {
            /* Carga todos los Empleados */
            Contratos contrato = new Contratos();
            DgContrato.ItemsSource = contrato.ReadAll();
        }

        private void BtRefreshContr_Click(object sender, RoutedEventArgs e)
        {
            CargarContrato();
            Limpiar();
        }

        private void Limpiar()
        {

            TxbInstContra.Text = string.Empty;
            TxbCursoContra.Text = string.Empty;
            TxbCRutRContra.Text = string.Empty;
            TxbCantContra.Text = string.Empty;
            TxbNombRContra.Text = string.Empty;
            txbRutRepBusca.Text = string.Empty;
            TxbCorreoRContra.Text = string.Empty;
            CbSeguroContra.SelectedIndex = 0;
            CbDestinoContra.SelectedIndex = 0;
            TxbCostoContra.Text = string.Empty;

        }
    }
}

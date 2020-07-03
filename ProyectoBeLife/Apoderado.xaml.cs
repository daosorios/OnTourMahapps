using OnTour.Datos;
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
    public partial class Apoderado : Page
    {
        String correo = "";
        public MainWindow ControladoApoderado;
        public Apoderado()
        {
            InitializeComponent();          
                

        }


        private void BtPagar_Click(object sender, RoutedEventArgs e)
        {


            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();


                mmsg.To.Add(correo);
                mmsg.Subject = "Comprobante de Pago";
                mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
                mmsg.Bcc.Add("daniela.osorio.santana@gmail.com");

                mmsg.Body = "Se realizado el pago exitosamente con un abono de $" + TxbMonto + " con fecha " + DateTime.Today.ToString("dd/MM/yyyy") +
                    " recuerde guardar este comprobante. Feliz Viaje";
                mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                mmsg.IsBodyHtml = true;
                mmsg.From = new System.Net.Mail.MailAddress("ontourpago@gmail.com");

                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

                cliente.Credentials = new System.Net.NetworkCredential("ontourpago@gmail.com", "tour2019");
                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.Host = "smtp.gmail.com";

                try
                {
                    cliente.Send(mmsg);
      
                }
                catch (Exception)
                {

                }

   



        }

        public void buscarUsuario()
        {

            //buscando correo
            usuarios usu = new usuarios();
            usu.id = Acceso.numid;
            usu.ReadiD();
           
            Console.WriteLine(usu.correo);
            correo = usu.correo;

            //buscando nombe
            OnTour.Negocio.Personas per = new OnTour.Negocio.Personas();
            per.id_persona = Acceso.numid;
            per.ReadiD();
            LbNombreBienven.Content = "apoerado" + " " + per.nombre;
            Console.WriteLine(per.nombre);

 


        }
    }
}

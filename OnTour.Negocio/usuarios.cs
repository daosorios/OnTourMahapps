using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTour.Negocio
{
    public class usuarios
    {
        public  string correo { get; set; }
        public string  contra { get; set; }
        public int id { get; set; }
        public  string tipo { get; set; }

        public usuarios()
        {
            this.Init();
        }
        public void Init()
        {
            correo = string.Empty;
            contra = string.Empty;
            id = 0;
            tipo = string.Empty;

        }

        public bool Create()
        {
            Datos.OnTourEntities1 bbdd = new Datos.OnTourEntities1();
            Datos.usuario usu = new Datos.usuario();

            try
            {
                CommonBC.Syncronize(this,usu);

                bbdd.usuario.Add(usu);
                bbdd.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                bbdd.usuario.Remove(usu);
                return false;
            }
        }

        public bool Read()
        {
            Datos.OnTourEntities1 bbdd = new Datos.OnTourEntities1();
            try
            {
                Datos.usuario usu = bbdd.usuario.First(e => e.correo.Trim() == correo.Trim());
                CommonBC.Syncronize(usu, this);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false ;
            }
                                  
     
        }
  
    }
}

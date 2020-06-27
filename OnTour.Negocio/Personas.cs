using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTour.Negocio
{
    public class Personas
    {
        public int id_persona { get; set; }
        public string nombre { get; set; }
        public string rut { get; set; }


        public Personas()
        {
            this.Init();

        }

        public void Init()
        {
            id_persona = 0;
            nombre = string.Empty;
            rut = string.Empty;

        }

        public bool Create()
        {
            Datos.OnTourEntities1 bbdd = new Datos.OnTourEntities1();
            Datos.Personas per = new Datos.Personas();

            try
            {
                CommonBC.Syncronize(this, per);

                bbdd.Personas.Add(per);
                bbdd.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                bbdd.Personas.Remove(per);
                return false;
            }
        }


    }
}

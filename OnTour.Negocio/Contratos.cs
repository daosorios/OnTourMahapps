using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTour.Negocio
{
    public class Contratos
    {
        public int id_ejec { get; set; }
        public string institucion { get; set; }
        public string curso { get; set; }
        public int cantidad { get; set; }
        public string nombre_rep { get; set; }
        public string rut_rep { get; set; }
        public string correo_rep { get; set; }
        public string seguro { get; set; }
        public string destino { get; set; }
        public int costo { get; set; }

        public Contratos()
        {
            this.Init();
        }

        public void Init()
        {
            id_ejec = 0;
            institucion = string.Empty;
            curso = string.Empty;
            cantidad = 0;
            nombre_rep = string.Empty;
            rut_rep = string.Empty;
            correo_rep = string.Empty;
            seguro = string.Empty;
            destino = string.Empty;
            costo = 0;

        }

        public bool Create()
        {
            Datos.OnTourEntities1 bbdd = new Datos.OnTourEntities1();
            Datos.Contratos con = new Datos.Contratos();

            try
            {
                CommonBC.Syncronize(this, con);      

                bbdd.Contratos.Add(con);
                bbdd.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                bbdd.Contratos.Remove(con);
                return false;
            }

        }

        public bool Read()
        {
            Datos.OnTourEntities1 bbdd = new Datos.OnTourEntities1();

            try
            {
                Datos.Contratos con = bbdd.Contratos.First(e => e.rut_rep == rut_rep);
                CommonBC.Syncronize(con, this);

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update()
        {
            Datos.OnTourEntities1 bbdd = new Datos.OnTourEntities1();
            try
            {

                Datos.Contratos con = bbdd.Contratos.First(e => e.rut_rep == rut_rep);
                CommonBC.Syncronize(this, con);
        
                bbdd.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool Delete()
        {
            Datos.OnTourEntities1 bbdd = new Datos.OnTourEntities1();

            try
            {
                Datos.Contratos con = bbdd.Contratos.First(e => e.rut_rep == rut_rep);
                bbdd.Contratos.Remove(con);
                bbdd.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Contratos> ReadAll()
        {

            //lee todos los registros de los contratos
            Datos.OnTourEntities1 bbdd = new Datos.OnTourEntities1();

            try
            {
                /* Se obtiene todos los registro desde la tabla */
                List<Datos.Contratos> listadoDatos = bbdd.Contratos.ToList<Datos.Contratos>();

                /* Se convierte el listado de datos en un listado de negocio */
                List<Contratos> listadoContrato = GenerarListado(listadoDatos);

                /* Se retorna la lista */
                return listadoContrato;
            }
            catch (Exception)
            {
                return new List<Contratos>();
            }
        }

        /// <summary>
        /// Convierte un listado de objetos de datos en un listado de objetos de negocio (contra)
        /// </summary>
        /// <param name="listadoDatos"></param>
        /// <returns></returns>
        private List<Contratos> GenerarListado(List<Datos.Contratos> listadoDatos)
        {
            List<Contratos> listadoContrato = new List<Contratos>();

            foreach (Datos.Contratos dato in listadoDatos)
            {

                Contratos contra = new Contratos();
                CommonBC.Syncronize(dato, contra);

                listadoContrato.Add(contra);
            }

            return listadoContrato;
        }

    }
}

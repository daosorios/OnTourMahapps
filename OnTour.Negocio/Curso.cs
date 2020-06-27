using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTour.Negocio
{
    public class Curso
    {
        public int id_ejecutivo { get; set; }
        public string curso1 { get; set; }
        public string institucion { get; set; }
        public int cantidad { get; set; }

        public Curso()
        {
            this.Init();

        }

        public void Init()
        {
            id_ejecutivo = 0;
            curso1 = string.Empty;
            institucion = string.Empty;
            cantidad = 0;
        }

        public bool Create()
        {
            Datos.OnTourEntities1 bbdd = new Datos.OnTourEntities1();
            Datos.Curso cur = new Datos.Curso();

            try
            {
                CommonBC.Syncronize(this, cur);

                bbdd.Curso.Add(cur);
                bbdd.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                bbdd.Curso.Remove(cur);

               return false;
            }
        }

        public bool Read()
        {
            Datos.OnTourEntities1 bbdd = new Datos.OnTourEntities1();

            try
            {
                Datos.Curso cur = bbdd.Curso.First(e => e.curso1 == curso1);
                CommonBC.Syncronize(cur, this);
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

                Datos.Curso cur = bbdd.Curso.First(e => e.curso1 == curso1);
                CommonBC.Syncronize(this, cur);
                bbdd.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        public bool Delete()
        {
            Datos.OnTourEntities1 bbdd = new Datos.OnTourEntities1();

            try
            {
                Datos.Curso cur = bbdd.Curso.First(e => e.curso1 == curso1);
                bbdd.Curso.Remove(cur);
                bbdd.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public List<Curso> ReadAll()
        {
            Datos.OnTourEntities1 bbdd = new Datos.OnTourEntities1();

            try
            {
                List<Datos.Curso> listaDatos = bbdd.Curso.ToList<Datos.Curso>();

                //se envia la lista de Cliente base de datos pra que retorne una lista de Cliente
                List<Curso> listaRegistro = GenerarListado(listaDatos);

                //retrona la lista al datagrid
                return listaRegistro;
            }
            catch (Exception)
            {

                return new List<Curso>();
            }
        }

        private List<Curso> GenerarListado(List<Datos.Curso> listaDatos)
        {

            //se crea lista para para retornar clientes
            List<Curso> listaRegistro = new List<Curso>();


            //un foreach que recorre la lista de cliente de la base de datos que inserta hacia la lista de cliente
            foreach (Datos.Curso datos in listaDatos)

            {
                //se crea un objeto cliente
                Curso curso= new Curso();
                //se envia un cliente de base de dato y un cliente y retorna un cliente nuevo
                CommonBC.Syncronize(datos, curso);

                //se inserta cliente en la lista de cliente                
                listaRegistro.Add(curso);

            }

            //retorna la lista
            return listaRegistro;
        }
    }
}

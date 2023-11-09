using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO201_ejMuseo01
{
    class Galeria
    {
        private int id;
        private String nombre;
        private List<Exposicion> listadoExposiciones;

        public int Id {  get; set; }
        public string Nombre { get; set; }
        public List<Exposicion> ListadoExposiciones { get; set; }

        public Galeria(int id, string nombre, List<Exposicion> listadoExposiciones)
        {
            Id = id;
            Nombre = nombre;
            ListadoExposiciones = listadoExposiciones;
        }
    }
}

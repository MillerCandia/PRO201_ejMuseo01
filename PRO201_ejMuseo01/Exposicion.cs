using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO201_ejMuseo01
{
    class Exposicion
    {
        private int id;
        private String nombre;
        private String fechaIncio;
        private String fechaTermino;
        //Atributo de listado
        private List<ObraArte> listadoObras;

        public int Id {  get; set; }
        public String Nombre {  get; set; }
        public String FechaInicio {  get; set; }
        public String FechaTermino { get; set; }

        public List<ObraArte> ListadoObras {  get; set; }   

        public Exposicion(int id, string nombre, string fechaIncio, string fechaTermino, List<ObraArte> listadoObras) 
        {
            Id = id;
            Nombre = nombre;    
            FechaInicio = fechaIncio;
            FechaTermino = fechaTermino;
            ListadoObras = listadoObras;
        }

    }
}

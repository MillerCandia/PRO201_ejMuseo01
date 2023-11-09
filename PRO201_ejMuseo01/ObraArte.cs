using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO201_ejMuseo01
{
    class ObraArte
    {
        //Atributos
        private int id;
        private String nombre;
        private String autor;
        private String fecha;
        private String descripcion;

        //Metodos
        public int Id {  get { return id; } set {  id = value; } } 
        public String Nombre { get {  return nombre; } set {  nombre = value; } }
        public String Autor { get {  return autor; } set {  autor = value; } }
        public String Fecha { get {  return fecha; } set {  fecha = value; } }
        public String Descripcion { get {  return descripcion; } set {  descripcion = value; } }

        //Constructor
        public ObraArte(int id, String nombre, string autor, string fecha, string descripcion) 
        {
            Id = id;
            Nombre = nombre;
            Autor = autor;
            Fecha = fecha;
            Descripcion = descripcion;
        }
    }
}

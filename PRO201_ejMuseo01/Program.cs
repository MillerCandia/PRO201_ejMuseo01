using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO201_ejMuseo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Listado con 2 administradores
            //Crear una lista
            List<Administrador> listadoAdministrador = new List<Administrador>();   
            //paso2:Agregar objetos directamente al listado
            listadoAdministrador.Add(new Administrador(1, "jperez", "Juan", "Perez", "12345"));
            listadoAdministrador.Add(new Administrador(1, "adiaz", "Andrea", "Diaz", "54321"));

            //Listado con 2 guias
            //Crear una lista
            List<Guia> listadoGuias = new List<Guia>();
            //paso2:Agregar objetos directamente al listado
            listadoGuias.Add(new Guia(1, "mgonzales", "Marcela", "Gonzales", "12345"));
            listadoGuias.Add(new Guia(1, "opereira", "Octavio", "Pereira", "54321"));

            //Listado conm 4 obras
            List<ObraArte> listadoObras = new List<ObraArte>();
            listadoObras.Add(new ObraArte(1, "La Mona Lisa", "Leonardo da Vinci", "1583 - 1506", "Retrato enigmatico de una mujer"));
            listadoObras.Add(new ObraArte(2, "La noche estrellada", "Vincent van Gogh", "1889", "Cielo nocturno turbulento sobre el pueblo"));
            listadoObras.Add(new ObraArte(3, "La persistencia de la memoria", "Salvador Dali", "1931", "Relojes derretidos en un paisaje desertico"));
            listadoObras.Add(new ObraArte(4, "La creacion de Adan", "Miguel Angel", "1512", "Representacion de Dios dando vida a Adan"));

            //Crear lista de obras que van en exposiciones 1
            List<ObraArte> obrasExposicion1 = new List<ObraArte>();
            //1 exposicion1 con 3 obras de arte
            obrasExposicion1.Add(listadoObras[0]);
            obrasExposicion1.Add(listadoObras[1]);
            obrasExposicion1.Add(listadoObras[2]);
            Exposicion exposicion1 = new Exposicion(1, "Exposicion de Obras Famosas", "23-11-01", "23-11-01", obrasExposicion1);

            //Crear lista de obras que van en exposiciones 1
            List<ObraArte> obrasExposicion2 = new List<ObraArte>();
            //1 exposicion1 con 1 obras de arte
            obrasExposicion2.Add(listadoObras[3]);
            obrasExposicion2.Add(listadoObras[2]);
            Exposicion exposicion2 = new Exposicion(2, "Exposicion de arte renacentista", "23-11-01", "23-11-01", obrasExposicion2);

            //CREAR LISTADO DE EXPOSICIONES
            List<Exposicion> listadoExposicion = new List<Exposicion>();
            listadoExposicion.Add(exposicion1);
            listadoExposicion.Add(exposicion2);

            //Crear una galeria con una exposicion
            List<Exposicion> listadoExposicionesGaleria = new List<Exposicion>();
            listadoExposicionesGaleria.Add(exposicion1);


            Galeria galeria = new Galeria(1, "Mi Galeria", listadoExposicionesGaleria);
            List<Galeria> listadoGalerias = new List<Galeria>();
            listadoGalerias.Add(galeria);

            //VALIDAR QIE EXISTE USUARIO
            //SI EXISTE: MOSTRAR EL MENU SEGUN TIPO DE USUARIO
            int opcionA =MenuAdministrador();
            int opcionG =MenuGuia();

            Console.WriteLine(opcionA);
            Console.WriteLine(opcionG);
            Console.ReadLine();

        }

        //MENU PARA ADMINISTRADOR 
        static int MenuAdministrador()
        {
            Console.WriteLine("--Menu Administrador--");
            Console.WriteLine("[1] Ver listado de Guias");
            Console.WriteLine("[2] Ver listado de Obras de arte");
            Console.WriteLine("[3] Ver listado de Exposiciones");
            Console.WriteLine("[4] Ver listado de Galerias");
            Console.WriteLine("[5] Agregar Galeria");
            Console.WriteLine("[6] Editar Galeria (Agregar exposicion)");
            Console.WriteLine("[0] Salir");
            Console.WriteLine("Seleccione una opcion");
            int opcion = int.Parse(Console.ReadLine());//falta validar el int
            Console.ReadLine();
            return opcion;    
        }

        //MENU PARA GUIA
        static int MenuGuia() 
        {
            Console.WriteLine("--Menu Guia--");
            Console.WriteLine("[1] Ver listado de Galerias");
            Console.WriteLine("[2] Salir");
            Console.WriteLine("Seleccione una opcion");
            int opcion = int.Parse(Console.ReadLine());//falta validar el int
            Console.ReadLine();
            return opcion;
        }

        

    }
}

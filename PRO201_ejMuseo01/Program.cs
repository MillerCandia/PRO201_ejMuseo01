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

            //Agregar un boleano para validar respuesta
            bool continuar = true;

            //while por defecto viene en verdadero 
            while (continuar)
            {
                string tipoUser = LoginUser(listadoAdministrador, listadoGuias);
                if (tipoUser == "admin")
                {
                    int opcion;
                    do
                    {
                        opcion = MenuAdministrador();
                        switch (opcion)
                        {
                            case 1:
                                VerGuia(listadoGuias);
                                break;
                            case 2:
                                VerObra(listadoObras);
                                break;
                            case 3:
                                VerExpocision(listadoExposicion);
                                break;
                            case 4:
                                VerGaleria(listadoGalerias);
                                break;
                            case 5:
                                Console.WriteLine("------AGREGAR GALERIA ----------");
                                //Solicitar datos
                                Console.WriteLine("Ingrese Id:");
                                int id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese Nombre:");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Seleccione Exposicion para Agregar");
                                VerExpocision(listadoExposicion);
                                Console.WriteLine("Ingrese Id de Exposicion ");
                                int idExpo = int.Parse(Console.ReadLine());
                                List<Exposicion> listaAgregar = new List<Exposicion>();
                                foreach (Exposicion itemExpo in listadoExposicion)
                                {
                                    if (itemExpo.Id == idExpo)
                                    {
                                        listaAgregar.Add(itemExpo);
                                    }
                                }
                                Galeria gal = new Galeria(id, nombre, listaAgregar);
                                listadoGalerias.Add(gal);
                                Console.WriteLine("Galeria Agregada Correctamente");
                                break;
                            case 6:
                                Console.WriteLine("----EDITAR GALERIA -----");
                                foreach (var gale in listadoGalerias)
                                {
                                    Console.WriteLine($"ID: {gale.Id} | Nombre: {gale.Nombre}");
                                }
                                Console.WriteLine("Seleccione Galeria");
                                int galeria_seleccionada = int.Parse(Console.ReadLine());
                                foreach (var gale in listadoGalerias)
                                {
                                    if (gale.Id == galeria_seleccionada)
                                    {
                                        Console.WriteLine("EXPOSICIONES ACTUALES EN LA GALERIA");
                                        foreach (var expo in gale.ListadoExposiciones)
                                        {
                                            Console.WriteLine($"Id: {expo.Id} | Nombre: {expo.Nombre}");
                                        }
                                        Console.WriteLine("Motrar todas las exposiciones");
                                        foreach (var expo in listadoExposicion)
                                        {
                                            Console.WriteLine($"Id: {expo.Id} | Nombre: {expo.Nombre}");
                                        }
                                        Console.WriteLine("Selecciona exposicion a agregar");
                                        int expo_IdSeleccionada = int.Parse(Console.ReadLine());
                                        Exposicion expoBuscada = BuscarExposicion(expo_IdSeleccionada, listadoExposicion);
                                        if (expoBuscada != null)
                                        {
                                            bool existeExpo = false;
                                            foreach (var expo in gale.ListadoExposiciones)
                                            {
                                                if (expo.Id == expoBuscada.Id)
                                                {
                                                    Console.WriteLine("Ya existe la exposicion");
                                                    existeExpo = true;
                                                    break;
                                                }
                                            }
                                            if (!existeExpo)
                                            {
                                                gale.ListadoExposiciones.Add(expoBuscada);
                                                Console.WriteLine("Exposicion Agregada");
                                            }
                                        }
                                    }
                                }
                                break;
                            case 0:
                                continuar = false;
                                break;
                            default:
                                Console.WriteLine("Opción Inválida");
                                break;
                        }
                    } while (opcion != 0);
                }
                else if (tipoUser == "guia")
                {
                    int opcion;
                    do
                    {
                        opcion = MenuGuia();
                        switch (opcion)
                        {
                            case 1:
                                VerGaleria(listadoGalerias);
                                break;
                            case 0:
                                continuar = false;
                                break;
                            default:
                                Console.WriteLine("Opción Inválida");
                                break;
                        }
                    } while (opcion != 0);
                }
                else
                {
                    Console.WriteLine("No Existe");
                    continuar = false;
                }
            }
            Console.WriteLine("Programa finalizado.");
            Console.ReadLine();
        }
        static String LoginUser(List<Administrador> listadmin, List<Guia> listguia)
        {
            Console.WriteLine("Ingrese Usuario");
            String User = Console.ReadLine();
            Console.WriteLine("Ingrese Contraseña");
            String Pass = Console.ReadLine();
            foreach (Administrador admin in listadmin)
            {
                if (admin.Usuario == User && admin.Password == Pass)
                {
                    return "admin";
                }

            }
            foreach (Guia guia in listguia)
            {
                if (guia.Usuario == User && guia.Password == Pass)
                {
                    return "guia";
                }

            }
            return "Invalido";
        }
        //Ver Exposicion
        static void VerExpocision(List<Exposicion> ListaExposicion)
        {
            foreach (var item in ListaExposicion)
            {

                Console.WriteLine($"-------------{item.Nombre}--------ID: {item.Id}---------");
                VerObra(item.ListadoObras);
            }
        }
        //Ver Guia
        static void VerGuia(List<Guia> listadoGuia)
        {
            foreach (var guia in listadoGuia)
            {
                Console.WriteLine($"Id: {guia.Id} Nombre: {guia.Nombre} {guia.Apellido}");
                Console.WriteLine($"Usuario: {guia.Usuario}");
            }
        }
        //Ver Obra de Arte
        static void VerObra(List<ObraArte> listadoObraArte)
        {
            foreach (var obra in listadoObraArte)
            {
                Console.WriteLine($"Id: {obra.Id} Nombre: {obra.Nombre}");
                Console.WriteLine($"Autor: {obra.Autor} Fecha: {obra.Fecha}");
                Console.WriteLine($"Descripción: {obra.Descripcion}");
            }
        }
        static void VerGaleria(List<Galeria> listaGaleria)
        {
            foreach (var item in listaGaleria)
            {
                Console.WriteLine($"Id: {item.Id} Nombre: {item.Nombre}");
                VerExpocision(item.ListadoExposiciones);
            }
        }
        static int MenuAdministrador()
        {
            Console.WriteLine("-- Menú Administrador --:");
            Console.WriteLine("[1] Ver listado de Guías");
            Console.WriteLine("[2] Ver listado de Obras de arte");
            Console.WriteLine("[3] Ver listado de Exposiciones");
            Console.WriteLine("[4] Ver listado de Galerías");
            Console.WriteLine("[5] Agregar Galería");
            Console.WriteLine("[6] Editar Galería (Agregar exposición, verificar primero que no existe ya en la galería actual)");
            Console.WriteLine("[0] Salir");
            Console.WriteLine("Selecciona una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            return opcion;
        }
        static int MenuGuia()
        {
            Console.WriteLine("[1] Ver listado de Galerías");
            Console.WriteLine("[0] Salir");
            int opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

        static Exposicion BuscarExposicion(int idBuscar, List<Exposicion> listadoExposiciones)
        {
            foreach (var expo in listadoExposiciones)
            {
                if (expo.Id == idBuscar)
                {
                    return expo;
                }
            }
            return null;
        }
    }
}

        

    


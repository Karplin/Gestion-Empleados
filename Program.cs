using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_empleados
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<tiempocom> completo = new List<tiempocom>();

            List<mediotiem> medio = new List<mediotiem>();

            List<temporero> temp = new List<temporero>();

            int empleado1 = 0;
            do
            {
                Console.WriteLine("********************");
                Console.WriteLine("Gestion de Empleados - PerezSoftware");
                Console.WriteLine("********************");
                Console.WriteLine("");
                Console.WriteLine("Selecciona la opcion\n" +
                "\n1.-Crear un empleado" +
                "\n2.-Eliminar un empleado" +
                "\n3.-Mostrar los empleados" +
                "\n4.-Salir\n");


                int s1 = 0;

                s1 = Convert.ToInt32(Console.ReadLine());

                switch (s1)
                {

                    case 1:

                        Console.WriteLine("Ingrese el numero de empleados que va a crear");
                        int numempleado = Convert.ToInt32(Console.ReadLine());


                        //------------------------------------------CREAR--------------------------------------------------------
                    Console.WriteLine("Selecciona el tipo de empleado que quieres CREAR\n" +
                    "\n1.-Tiempo Completo" +
                    "\n2.-Medio Tiempo" +
                    "\n3.-Temporero" +
                    "\n4.-Salir" +
                    "\n5.-Menu Principal\n");
                        
                        empleado1 = Convert.ToInt16(Console.ReadLine());

                        switch (empleado1)
                        {

                            case 1:

                                for (int i = 0; i < numempleado; i++)
                                {
                                    tiempocom empleadox = new tiempocom();

                                    Console.WriteLine("Coloque el codigo");
                                    empleadox.codigo = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Coloque el nombre");
                                    empleadox.nombre = Console.ReadLine();
                                    Console.WriteLine("Coloque el departamento");
                                    empleadox.departamento = Console.ReadLine();
                                    Console.WriteLine("Coloque el cargo");
                                    empleadox.cargo = Console.ReadLine();
                                    Console.WriteLine("Coloque las horas laboradas");
                                    empleadox.horas_laboral = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Coloque el precio por hora");
                                    empleadox.precio = Convert.ToInt32(Console.ReadLine());

                                    empleadox.salario = empleadox.horas_laboral * empleadox.precio;

                                    

                                    completo.Add(empleadox);
                                   


                                    Console.Clear();

                                }

                               

                                break;

                            case 2:
                                for (int i = 0; i < numempleado; i++)
                                {
                                    mediotiem empleadoz = new mediotiem();

                                    Console.WriteLine("Coloque el codigo");
                                    empleadoz.codigo = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Coloque el nombre");
                                    empleadoz.nombre = Console.ReadLine();
                                    Console.WriteLine("Coloque el departamento");
                                    empleadoz.departamento = Console.ReadLine();
                                    Console.WriteLine("Coloque el cargo");
                                    empleadoz.cargo = Console.ReadLine();
                                    Console.WriteLine("Coloque las horas laboradas");
                                    empleadoz.horas_laboral = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Coloque el precio por hora");
                                    empleadoz.precio = Convert.ToInt32(Console.ReadLine());

                                    empleadoz.salario = empleadoz.horas_laboral * empleadoz.precio;

                                    medio.Add(empleadoz);
                                    Console.Clear();

                                }
                   
                                break;

                            case 3:

                                for (int i = 0; i < numempleado; i++)
                                {
                                    temporero empleadoc = new temporero();

                                    Console.WriteLine("Coloque el codigo");
                                    empleadoc.codigo = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Coloque el nombre");
                                    empleadoc.nombre = Console.ReadLine();
                                    Console.WriteLine("Coloque el departamento");
                                    empleadoc.departamento = Console.ReadLine();
                                    Console.WriteLine("Coloque el cargo");
                                    empleadoc.cargo = Console.ReadLine();
                                    Console.WriteLine("Coloque las horas laboradas");
                                    empleadoc.horas_laboral = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Coloque el precio por hora");
                                    empleadoc.precio = Convert.ToInt32(Console.ReadLine());

                                    empleadoc.salario = empleadoc.horas_laboral * empleadoc.precio;

                                    temp.Add(empleadoc);

                                    Console.Clear();
                                }
                                break;
                            case 4:
                                Environment.Exit(0);
                                break;

                            default:
                                break;
                        }
                        break;


                    //------------------------------------------BORRAR--------------------------------------------------------
                    case 2:
                        Console.WriteLine("Selecciona el tipo de empleado que quieres BORRAR\n" +
                        "\n1.-Tiempo Completo" +
                        "\n2.-Medio Tiempo" +
                        "\n3.-Temporero" +
                        "\n4.-Salir\n");

                        int tipo0 = 0;
                        tipo0 = Convert.ToInt16(Console.ReadLine());
                        switch (tipo0)
                        {
                            case 1:
                                Console.WriteLine("Coloque el codigo del empleado que quiere eliminar");
                                int codigoeliminar = Convert.ToInt32(Console.ReadLine());

                                for (int i = completo.Count - 1; i >= 0; i--)
                                {
                                    if (completo[i].codigo == codigoeliminar)
                                    {
                                        completo.Remove(completo[i]);
                                    }
                                }
                           break;

                            case 2:

                                Console.WriteLine("Coloque el codigo del empleado que quiere eliminar");
                                int codigomedio = Convert.ToInt32(Console.ReadLine());

                                for (int i = medio.Count - 1; i >= 0; i--)
                                {
                                    if (medio[i].codigo == codigomedio)
                                    {
                                        medio.Remove(medio[i]);
                                    }
                                }


                                break;

                            case 3:

                                Console.WriteLine("Coloque el codigo del empleado que quiere eliminar");
                                int codigotemp = Convert.ToInt32(Console.ReadLine());

                                for (int i = temp.Count - 1; i >= 0; i--)
                                {
                                    if (temp[i].codigo == codigotemp)
                                    {
                                        temp.Remove(temp[i]);
                                    }
                                }

                                break;

                            case 4:
                                Environment.Exit(0);
                                break;

                            default:                          
                                break;
                        }
                        break;


                    //----------------------------------------VISUALIZACION----------------------------------------------------------
                    case 3:
                        Console.WriteLine("Selecciona el tipo de empleado que quieres VISUALIZAR\n" +
                        "\n1.-Tiempo Completo" +
                        "\n2.-Medio Tiempo" +
                        "\n3.-Temporero" +
                        "\n4.-Mostrar poncheo, trabajo y cobro" +
                        "\n5.-Salir\n");

                        int tipo1 = 0;
                        tipo1 = Convert.ToInt16(Console.ReadLine());
                        switch (tipo1)
                        {
                            case 1:
                                foreach (var lista in completo)
                                {
                                    Console.WriteLine(lista);
                                 
                                    Console.WriteLine("");
                                   
                                }
                                break;

                            case 2:

                                foreach (var listaz in medio)
                                {
                                    Console.WriteLine(listaz);
                              
                                    Console.WriteLine(); 
                                }
                                Console.ReadKey();

                                break;


                            case 3:

                                foreach (var lista in temp)
                                {
                                    Console.WriteLine(lista);
                                   
                                    Console.WriteLine();
                  
                                }
                                
                                break;

                            case 4:
                                //-------------------------METODOS--------------------
                                Console.WriteLine("Selecciona el tipo de empleado \n" +
                               "\n1.-Tiempo Completo" +
                               "\n2.-Medio Tiempo" +
                               "\n3.-Temporero" +
                               "\n4.-Salir\n");

                                int metodox = 0;
                                metodox = Convert.ToInt16(Console.ReadLine());

                                switch (metodox)
                                {

                                    case 1:

                                        //METODO PONCHAR
                                        Console.WriteLine("Ingrese el codigo del empleado que quiere ver las funciones");
                                        int codigofuncion = Convert.ToInt32(Console.ReadLine());

                                        int haha = 0;
                                        string hoho;
                                        hoho = "";

                                        for (int i = completo.Count - 1; i >= 0; i--)
                                        {
                                            if (completo[i].codigo == codigofuncion)
                                            {
                                                haha = completo[i].codigo;
                                                hoho = completo[i].nombre;
                                            }
                                        }
                                        if (haha != 0)
                                        {
                                            tiempocom pan = new tiempocom();
                                            pan.Ponchar(haha,hoho);
                                        }
                                        else
                                        {
                                            Console.WriteLine("No existe");
                                        }

                                        //METODO TRABAJO
                                        tiempocom metodotrabajo = new tiempocom();
                                        metodotrabajo.Trabajar();
                                        Console.WriteLine("");

                                        //METODO COBRAR
                                        int salariox = 0;
                                        
                                        for (int i = completo.Count - 1; i >= 0; i--)
                                        {
                                            if (completo[i].codigo == codigofuncion)
                                            {
                                                salariox = completo[i].salario;
                                            }
                                        }

                                        if (salariox != 0)
                                        {
                                            tiempocom sala = new tiempocom();
                                            sala.Cobrar(salariox);
                                        }
                                        else
                                        {
                                            Console.WriteLine("No hay Salario");
                                        }
                                        break;

                                    case 2:
                                        //METODO PONCHAR
                                        Console.WriteLine("Ingrese el codigo del empleado que quiere ver las funciones");
                                        int codigom = Convert.ToInt32(Console.ReadLine());

                                        int codigomedio = 0;
                                        string nombremedio;
                                        nombremedio = "";

                                        for (int i = medio.Count - 1; i >= 0; i--)
                                        {
                                            if (medio[i].codigo == codigom)
                                            {
                                                codigomedio = medio[i].codigo;
                                                nombremedio = medio[i].nombre;
                                            }
                                        }
                                        if (codigomedio != 0)
                                        {
                                            tiempocom poncheo = new tiempocom();
                                            poncheo.Ponchar(codigomedio,nombremedio);

                                        }
                                        else
                                        {
                                            Console.WriteLine("No existe");
                                        }

                                        //METODO TRABAJO
                                        mediotiem trabajomedio = new mediotiem();
                                        trabajomedio.Trabajar();

                                        //METODO COBRAR

                                        int salarioz = 0;

                                        for (int i = medio.Count - 1; i >= 0; i--)
                                        {
                                            if (medio[i].codigo == codigom)
                                            {
                                                salarioz = medio[i].salario;
                                            }
                                        }

                                        if (salarioz != 0)
                                        {
                                            mediotiem salax = new mediotiem();
                                            salax.Cobrar(salarioz);
                                        }
                                        else
                                        {
                                            Console.WriteLine("No hay Salario");
                                        }



                                        break;
                                    


                                    case 3:
                                        //METODO PONCHEO
                                        Console.WriteLine("Ingrese el codigo del empleado que quiere ver las funciones");
                                        int codigotemp = Convert.ToInt32(Console.ReadLine());

                                        int tempo = 0;
                                        string nombretemp;
                                        nombretemp = "";

                                        for (int i = temp.Count - 1; i >= 0; i--)
                                        {
                                            if (temp[i].codigo == codigotemp)
                                            {
                                                tempo = temp[i].codigo;
                                                nombretemp = temp[i].nombre;
                                            }
                                        }
                                        if (tempo != 0)
                                        {
                                            temporero tempponch = new temporero();
                                            tempponch.Ponchar(tempo, nombretemp);
                                        }
                                        else
                                        {
                                            Console.WriteLine("No existe");
                                        }
                                        //METODO TRABAJO

                                        temporero trabajotemp = new temporero();
                                        trabajotemp.Trabajar();


                                        //METODO COBRAR
                                        int salarioc = 0;

                                        for (int i = temp.Count - 1; i >= 0; i--)
                                        {
                                            if (temp[i].codigo == codigotemp)
                                            {
                                                salarioc = temp[i].salario;
                                            }
                                        }

                                        if (salarioc != 0)
                                        {
                                            temporero salac = new temporero();
                                            salac.Cobrar(salarioc);
                                        }
                                        else
                                        {
                                            Console.WriteLine("No hay Salario");
                                        }


                                        break;

                                    case 4:
                                        Environment.Exit(0);
                                        break;

                                }

                                break;
                        
                            case 5:
                                Environment.Exit(0);
                                break;
                           
                            default:                                 
                            break;
                        }
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                    break;
                }

                Console.WriteLine("Quieres volver al menu principal? Pulse 5 ");
                empleado1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.ReadKey();

            } while (empleado1 == 5);
             

    }

    }

}

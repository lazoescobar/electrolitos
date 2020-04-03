using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrolitos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool estado = true;

            while (estado == true)
            {
                Console.WriteLine("******ELECTROLITOS*********");

                Empleado emple = new Empleado();

                Console.WriteLine("ingrese nombre de trabajador : " + "\n");
                emple.Nombre = Console.ReadLine();

                Console.WriteLine(".................TIPOS DE TRABJADORES ............." + "\n\n" +

                                  "  *   Jefe de tienda(Puede escribir tambien : jefe tienda o jefe)" + " \n" + 
                                  "  *   Vendedor de tienda(Puede escribir tambien : Vendedor tienda o vendedor)" + "\n" +
                                  "  *   Reponedor de tienda(Puede escribir tambien : Reponedor tienda o reponedor)" + "\n\n" +
                                  "Ingrese tipo de trabajador" + " \n"  );
                 
                string tipo = Console.ReadLine();

                Console.WriteLine("\n" + "ingrese numero de horas trabajadas : " + "\n");
                int horas = Convert.ToInt32(Console.ReadLine());


                emple.MostrarNombre();
                emple.tipoDeCargoyHoras(tipo.ToUpper(), horas);

                Console.WriteLine("\n" + "Quiere seguir calculando sueldos? : si / no");
                string opcion = Console.ReadLine().ToUpper();

                if (opcion == "SI")
                {
                    //estado = true;
                    Console.Clear();
                }
                else if( opcion == "NO")
                {
                    estado = false;
                    break;
                }
                else
                {
                    estado = false;
                    break;
                }

            }

            Console.ReadKey();

        }
    }
}

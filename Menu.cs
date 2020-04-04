using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrolitos
{
    class Menu
    {
        Validacion vali;

        public string solicitarNombre(){

            vali = new Validacion();

            String nombre;

            do {

                Console.WriteLine("Ingrese un nombre Porfavor : " + "\n");

                nombre = Console.ReadLine();

                if(vali.EsNombre(nombre) == false){

                    Console.Clear();
                    Console.WriteLine("Error...... nombre invalido " + "\n");
                }

            } while (vali.EsNombre(nombre) == false);

            Console.WriteLine();

            return nombre;
        }


        public int solicitarCargo(Empleado emple)
        {

            vali = new Validacion();
            String Opcion;

            do
            {
                Console.WriteLine("Eliga un cargo Porfavor : " + "\n" +
                                  "-------- TIPOS DE CARGOS ------------" + "\n" +
                                  "(1) JEFE DE TIENDA " + "\n" + 
                                  "(2) VENDEDOR TIENDA " + "\n" + 
                                  "(3) REPONEDOR DE TIENDA " + "\n") ;


                Opcion = Console.ReadLine();

                if (vali.EsOpcion(Opcion) == false)
                {

                    Console.Clear();

                    Console.WriteLine("Nombre Empleado : " + emple.getNombre() + "\n\n");

                    Console.WriteLine("Error......Opcion invalida " + "\n");

                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("Nombre Empleado : " + emple.getNombre() + "\n");
                }

            } while (vali.EsOpcion(Opcion) == false);

            Console.WriteLine();

            int opc = Convert.ToInt32(Opcion);

            return opc;

        }

        public int solicitarhorasTrabajadas( Empleado emple)
        {
            vali = new Validacion();

            String ingresoHoras;

            do
            {
                Console.WriteLine("Ingrese cantidad de horas trabajadas por Sr(a) :" + emple.getNombre() + "\n" );

                ingresoHoras = Console.ReadLine();

                if(vali.EsHorasTrabajdas(ingresoHoras) == false)
                {
                    Console.Clear();

                    Console.WriteLine("Nombre Empleado : " + emple.getNombre() + "\n\n" );

                    Console.WriteLine("Error......horas invalidas " + "\n");
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("Nombre Empleado : " + emple.getNombre() + "\n");
                }

            } while (vali.EsHorasTrabajdas(ingresoHoras) == false);

            Console.WriteLine();

            int horas = Convert.ToInt32(ingresoHoras);

            return horas;
        }

        public String solicitarFinPrograma()
        {
            String respuesta;

            Console.WriteLine();

            Console.WriteLine("Dese calcular un nuevo empleado : Si/no");

            respuesta = Console.ReadLine();

            Console.WriteLine();

            return respuesta.ToUpper();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrolitos
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("************" + "\n" +
                            "              ELECTROLITOS" + "\n" +
                            "                           ***************");
            Console.WriteLine();


            bool finEjecucion = false;

            while ( finEjecucion == false )
            {

                Menu men = new Menu();


                Empleado emple = new Empleado();

                emple.setNombre( men.solicitarNombre() );

                emple.setTipo( men.solicitarCargo(emple) );

                emple.determinarTipo();



                Sueldo suel = new Sueldo();

                suel.setHorasTrabajadas( men.solicitarhorasTrabajadas(emple) );

                suel.cancelarSegunTipo( emple );

                String respuesta = men.solicitarFinPrograma();


                if( respuesta == "SI" ) {

                    finEjecucion = false;

                    Console.Clear();
                }

                else if( respuesta == "NO") {

                    finEjecucion = true;

                    break;
                }

                else {

                    finEjecucion = true;

                    break;
                }

            }
   
            Console.ReadKey();

        }

    }

}

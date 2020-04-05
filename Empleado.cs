using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrolitos
{
    class Empleado
    {

        private String nombre;
        private int Tipo;


        public void setNombre(String nombre) {

            this.nombre = nombre;
        }

        public String getNombre() {

            return this.nombre;
        }

        public void setTipo(int tipo) {

            this.Tipo = tipo;
        }

        public int getTipo() { 

            return this.Tipo;
        }


        public void determinarTipo() {
            
            // TIPO '1' = JEFE
            if(Tipo == 1) {

                Console.WriteLine();
                Console.WriteLine("Tipo elegido : JEFE DE TIENDA");
                Console.WriteLine();
            }

            //TIPO '2' = VENDEDOR
            else if (Tipo == 2) {

                Console.WriteLine();
                Console.WriteLine("Tipo elegido : VENDEDOR DE TIENDA");
                Console.WriteLine();
            }
            
            //TIPO '3' = REPONEDOR
            else if (Tipo == 3) {

                Console.WriteLine();
                Console.WriteLine("Tipo elegido : REPONEDOR DE TIENDA");
                Console.WriteLine();

            }

        }

    }

}

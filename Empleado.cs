using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrolitos
{
    class Empleado
    {
        public String Nombre;
        public String tipo;
        
        public Sueldo suel= new Sueldo();

        public Empleado() { }

        public void tipoDeCargoyHoras(string cadena, int horas){

            this.tipo = cadena;

            if (tipo == "JEFE DE TIENDA" || tipo == "JEFE TIENDA" || tipo == "JEFE")
            {
                //Numero de horas && valor de la hora normal + valor hora extra           JEFE DE TIENDA
                suel.calcularPago(horas, 2000, 3000);
            }
            else if (tipo == "VENDEDOR DE TIENDA" || tipo == "VENDEDOR TIENDA" || tipo == "VENDEDOR")
            {
                //Numero de horas && valor de la hora normal + valor hora extra             VENDEDOR DE TIENDA
                suel.calcularPago(horas, 1500, 2500);
            }
            else if (tipo == "REPONEDOR DE TIENDA" || tipo == "REPONEDOR TIENDA" || tipo == "REPONEDOR"){

                ////Numero de horas && valor de la hora normal +  valor hora extra          REPONEDOR DE TIENDA
                suel.calcularPago(horas, 1000, 2000);
            }

        }

        public void MostrarNombre()
        {
            Console.WriteLine("\n" + "Nombre   :   " + this.Nombre );
        }
    }
}

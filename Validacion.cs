using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Electrolitos
{
    class Validacion
    {
        public bool EsNombre(String nombre) {

            bool resultado = false;

            //EXPRESION PUEDE SOMETERSE A UNOS REQUIRIMIENTOS
            Regex expresion = new Regex("^[A-Z|a-z]*$");

            if(expresion.IsMatch(nombre) == true){

                resultado = true;
            }

            return resultado;
        }

        public bool EsOpcion(String opcion){

            bool resultado = false;

            Regex expresion = new Regex("^[1-3]$");

            if (expresion.IsMatch(opcion) == true)
            {

                resultado = true;
            }

            return resultado;
        }

        public bool EsHorasTrabajdas(String horas){

            bool resultado = false;

            Regex expresion = new Regex("^([1-9][0-9]*)$");

            if (expresion.IsMatch(horas) == true)
            {

                resultado = true;
            }

            return resultado;
        }
    }
}

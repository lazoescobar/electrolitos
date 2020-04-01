using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrolitos
{
    class Sueldo
    {
        private int montoaCancelar = 0;
        public int horasTrabajadas;

        public void calcularPago(int horas, int valorHora, int valorHoraExtra)
        {
            this.horasTrabajadas = horas;

            int horasNormales = 0;
            int horasExtra = 0;

            int saldoHorasNormales = 0;
            int saldoHorasExtras = 0;

            if (horasTrabajadas > 40)
            {
                //obtengo las horas extras
                horasExtra += horasTrabajadas - 40;

                //horas normales = 40 'fijo'
                horasNormales += 40;

                //montoCancelar 'agregacion' horas normales
                montoaCancelar += horasNormales * valorHora;
                saldoHorasNormales += horasNormales * valorHora;

               //montoCancelar 'agregacion' horas extras
                montoaCancelar += horasExtra * valorHoraExtra;
                saldoHorasExtras += horasExtra * valorHoraExtra;
            }
            else
            {
                horasNormales = horasTrabajadas;

                montoaCancelar = horasNormales * valorHora;

                saldoHorasNormales += horasNormales * valorHora;

            }

            this.mostrarDetalle(horasNormales, horasExtra, saldoHorasNormales, saldoHorasExtras, montoaCancelar);
            
        } 

        private void mostrarDetalle(int horasNormales, int horasExtras, int saldoHoraNormal, int saldoHoraExtra, int Saldo)
        {
            Console.WriteLine("HORAS NORMALES :" + horasNormales + "    $ : " + saldoHoraNormal);
            Console.WriteLine("HORAS EXTRAS : " + horasExtras + "   $ : " + saldoHoraExtra);
            Console.WriteLine("\n" + "su sueldo es de : " + Saldo);

        }

    }
}

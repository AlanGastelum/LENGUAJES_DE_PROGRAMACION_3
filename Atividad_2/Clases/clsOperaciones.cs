using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2.Clases
{
    internal class clsOperaciones
    {
        public int Sumar(int numero1, int numero2, int numero3, int numero4, int numero5, int numero6)
        {
            int resultado;
            resultado = numero1 + numero2 + numero3 + numero4 + numero5 + numero6;
            return resultado;
        }
        public int Restar(int numero1, int numero2, int numero3, int numero4, int numero5, int numero6)
        {
            int resultado;
            resultado = numero1 - numero2 - numero3 - numero4 - numero5 - numero6;
            return resultado;
        }
        public int Multiplicar(int numero1, int numero2, int numero3, int numero4, int numero5, int numero6)
        {
            int resultado;
            resultado = numero1 * numero2 * numero3 * numero4 * numero5 * numero6;
            return resultado;
        }
        public int Dividir(int numero1, int numero2, int numero3, int numero4, int numero5, int numero6)
        {
            int resultado;
            resultado = numero1 / numero2 / numero3 / numero4 / numero5 / numero6;
            return resultado;
        }
    }
}

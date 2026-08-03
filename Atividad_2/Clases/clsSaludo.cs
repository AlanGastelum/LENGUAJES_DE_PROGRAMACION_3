using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2.Clases
{
    public class clsSaludo
    {
        public string Saludar(string nombre)
        {
            string saludo;
            saludo= "Hola " + nombre + ", que tengas un excelente día.";
            return saludo;
        }
    }
}

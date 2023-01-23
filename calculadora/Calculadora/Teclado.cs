using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Teclado
    {
        public double Recebe_num()
        {
           var number = Convert.ToDouble(Console.ReadLine());
           return number;
        }

    }
}

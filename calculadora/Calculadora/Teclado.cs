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
            try
            {
                var number = Convert.ToDouble(Console.ReadLine());
                return number;
            }
            catch(Exception ex)
            {
                throw new FormatException("Você não digitou um número " + ex);
            }
        }

    }
}

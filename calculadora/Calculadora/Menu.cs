using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Menu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Bem-vindo à calculadora, escolha qual operação você deseja realizar:");
            var i = 0;
            while (i < 5)
            {
                Console.WriteLine(i + "- " + (Enum)i);
                i++;
            }
        }

        public void PrintTeclado()
        {
            Console.WriteLine("Digite os dois número os quais você deseja para realizar a " +
                            "operação matemática");
        }

        
     }
}


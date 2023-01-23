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

        public double Selecao(int operacao, Teclado teclado)
        {
            
            var valor1 = teclado.Recebe_num();
            var valor2 = teclado.Recebe_num();

            if (operacao == (int)Enum.Soma)
            {
                return new Soma().Calculo(valor1, valor2);
            }
            else if(operacao == (int)Enum.Subtracao){
                return new Subtracao().Calculo(valor1, valor2);
            }
            else if(operacao == (int)Enum.Multiplicacao){
                return new Multiplicacao().Calculo(valor1, valor2);
            }
            else if (operacao == (int)Enum.Divisao)
            {
                return new Divisao().Calculo(valor1, valor2);
            }
            else
            {
                return 0;
            }
        }
     }
}


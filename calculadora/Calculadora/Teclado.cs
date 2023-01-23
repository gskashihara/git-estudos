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

        public double Selecao(int operacao)
        {

            var valor1 = Recebe_num();
            var valor2 = Recebe_num();

            if (operacao == (int)Enum.Soma)
            {
                return new Soma().Calculo(valor1, valor2);
            }
            else if (operacao == (int)Enum.Subtracao)
            {
                return new Subtracao().Calculo(valor1, valor2);
            }
            else if (operacao == (int)Enum.Multiplicacao)
            {
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

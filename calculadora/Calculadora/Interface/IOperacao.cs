using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Interface
{
    public interface IOperacao
    {
        public abstract double Calculo(double valor1, double valor2);
    }
}

using MentoriaDev;

namespace MentoriaDev
{
    public class Somar : IOperacao
    {
        public double Calcular(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
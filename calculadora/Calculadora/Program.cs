namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            var teclado = new Teclado();
            var condicional = true;
            while(condicional)
            {
                var opcao = -1;
                
                while(opcao < 0 || opcao > 4)
                {
                    menu.PrintMenu();
                    opcao = (int)teclado.Recebe_num();
                }
                if ((Enum)opcao == Enum.Sair) break;
                
                menu.PrintTeclado();
                Console.WriteLine("Resultado: " + teclado.Selecao(opcao));
                Console.WriteLine("-----------------------------------------------------------------------");
            }
            
        }
    }
}
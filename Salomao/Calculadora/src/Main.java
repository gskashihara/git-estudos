import java.sql.SQLOutput;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        System.out.println("");
        System.out.println("");
        System.out.println("*******  Iniciando calculadora  *******");

        double n1, n2, n3 = 0;
        int op, soma, subtracao, divisao, multiplicacao;
        String continuar = "s";
        String simb = null;

        Scanner scanner = new Scanner(System.in);

        while (continuar.equals("s")) {
            System.out.println("");
            System.out.println("###  Insira o primeiro valor" + "  ###");
            n1 = scanner.nextDouble();
            System.out.println("###  Insira o segundo valor" + "  ###");
            n2 = scanner.nextDouble();
            System.out.println("###  Insira o operador" + "  ###");
            System.out.println("[1] + Soma");
            System.out.println("[2] - Subtracao");
            System.out.println("[3] / Divisao");
            System.out.println("[4] x Multiplicacao");
            op = scanner.nextInt();

            switch (op) {
                case 1:
                    n3 = n1 + n2;
                    simb = "+";
                    break;
                case 2:
                    n3 = n1 - n2;
                    simb = "-";
                    break;
                case 3:
                    if(n2 != 0 ) {
                        n3 = n1 / n2;
                        simb = "/";
                    } else System.out.println("divisao incorreta");
                    break;
                case 4:
                    n3 = n1 * n2;
                    simb = "*";
                    break;
                default:
                    System.out.println("Algo de errado não está certo");
            }

        System.out.println("###  Resultado = " + n3 + "  ###");
        System.out.printf("%nResultado -> %5.2f %s %5.2f = %5.2f ", n1, simb, n2, n3);
        System.out.println("");
        System.out.println("Deseja calcular novamente? [s/n]");
        continuar = scanner.next();
        }

    }
}
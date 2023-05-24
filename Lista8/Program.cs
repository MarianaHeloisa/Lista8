using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8
{
    internal class Program
    {
        public static void Exercicio1() {
            Console.WriteLine("aqui esta codificado o exercicio 1");
        }
        public static void Exercicio2() {
            Console.WriteLine("aqui esta codificado o exercicio 2");
        }
        public static void Exercicio3() {
            Console.WriteLine("aqui esta codificado o exercicio 3");
        }
        public static void Exercicio4() {
            Console.WriteLine("aqui esta codificado o exercicio 4");
        }
        public static void Exercicio5() {
            Console.WriteLine("aqui esta codificado o exercicio 5");
        }

        static void Main(string[] args)
        {
            int opcao;

                do
            {
                Console.WriteLine("===================MENU================= ");
                Console.WriteLine("                     Para sair - digite 0");
                Console.WriteLine("    Para executar exercicio 1 - digite 1 ");
                Console.WriteLine("    Para executar exercicio 2 - digite 2 ");
                Console.WriteLine("    Para executar exercicio 3 - digite 3 ");
                Console.WriteLine("    Para executar exercicio 4 - digite 4 ");
                Console.WriteLine("    Para executar exercicio 5 - digite 5 ");
                Console.WriteLine("=========================================");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao) { 

                    case 0:
                        Console.WriteLine(" obrigado por tentar ");
                        break;

                    case 1:
                        Exercicio1();
                        break;

                    case 2:
                        Exercicio2();
                            break;

                    case 3:
                        Exercicio3();
                        break;

                    case 4:
                        Exercicio4();
                        break;

                    case 5:
                        Exercicio5();   
                        break;

                    default:
                        Console.WriteLine(" Não é um exercício válido!");
                        break;


                }

            } while (opcao !=0 ); 
        }
    }
}

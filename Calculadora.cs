using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram_GG
{
    class Program
    {
        static double soma(double n1, double n2)
        {
            return (n1 + n2);
        }

        static double sub(double n1, double n2)
        {
            return (n1 - n2);
        }

        static double mult(double n1, double n2)
        {
            return (n1 * n2);
        }

        static double div(double n1, double n2)
        {
            return (n1 / n2);
        }


        static void Main(string[] args){

            int escolha = 0;
            double numero1;
            double numero2;

            while(escolha != 5)
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("CALCULADORA");

                Console.WriteLine("1- Soma");
                Console.WriteLine("2- Subtração");
                Console.WriteLine("3- Multiplicação");
                Console.WriteLine("4- Divisão");
                Console.WriteLine("5- Sair");
                Console.WriteLine("**********************************");

                Console.Write("Digite a opção desejada: ");

                escolha = Convert.ToInt32(Console.ReadLine());

                if(escolha == 1)
                {
                    Console.WriteLine("Digite o Primeiro Numero: ");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o Segundo Numero: ");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("O resultado é: " + soma(numero1, numero2));
                    Console.ReadKey();
                }


                if (escolha == 2)
                {
                    Console.WriteLine("Digite o Primeiro Numero: ");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o Segundo Numero: ");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("O resultado é: " + sub(numero1, numero2));
                    Console.ReadKey();
                }


                if (escolha == 3)
                {
                    Console.WriteLine("Digite o Primeiro Numero: ");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o Segundo Numero: ");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("O resultado é: " + mult(numero1, numero2));
                    Console.ReadKey();
                }


                if (escolha == 4)
                {
                    Console.WriteLine("Digite o Primeiro Numero: ");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o Segundo Numero: ");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("O resultado é: " + div(numero1, numero2));
                    Console.ReadKey();

                    
                }
            }
        }
    }
}

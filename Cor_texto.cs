using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram_GG
{
    class Program
    {
       
        static void Main(string[] args){

            int idade;

            Console.WriteLine("Digite sua Idade:");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Permissão Concedida");
                Console.ResetColor();
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem Permissão");
                Console.ResetColor();
                Console.ReadKey();
            }

        }
    }
}


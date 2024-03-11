using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados
{
    class Program
    {
        static void print(String nome)
        {
            Console.WriteLine("Olá meu nome é " + nome);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            String nome;
            Console.Write("Digite um nome: ");
            nome = Console.ReadLine();
            print(nome);

        }
    }
}

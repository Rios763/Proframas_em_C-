using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados
{
    class Program
    {


        static void Main(string[] args)
        {
            /*5–Desenvolva um algoritmo que calcule o reajuste salarial. 
                Se o salário  for abaixo de 1.700  o ajuste é de R$300.00, 
                se for maior, reajuste de R$ 200.00.Para finalizar, exiba o novo salário na tela.
            */

            int salario;
            Console.WriteLine("DIGITE SEU SALÁRIO!\nSALARIO INSERIDO: ");
            salario = Convert.ToInt32(Console.ReadLine());

            if (salario > 1700) salario += 200;
            else salario += 300;


            Console.WriteLine("\nSALARIO APÓS O REAJUSTE: "+ salario);

            Console.ReadKey();

        }
    }
}


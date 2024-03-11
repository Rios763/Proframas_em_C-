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
            int[] meusLados = { 0, 0, 0 };
            Console.Write("AVALIADOR DE TRIANGULOS! DIGITE OS LADOS QUE FORMAM O TRIANGULO!\n");
            meusLados[0] = Convert.ToInt32(Console.ReadLine());
            meusLados[1] = Convert.ToInt32(Console.ReadLine());
            meusLados[2] = Convert.ToInt32(Console.ReadLine());

            //A = MENOR / B = MEIO / C = MAIOR
            Array.Sort(meusLados);

            if ( meusLados[0] + meusLados[1] > meusLados[2] &&
                 meusLados[1] + meusLados[2] > meusLados[0] &&
                 meusLados[2] + meusLados[0] > meusLados[1])
            {
                Console.Write("O TRIANGULO EXISTE! É ");

                //ISOCELES
                if (meusLados[0] == meusLados[1] && meusLados[1] != meusLados[2])
                {
                    Console.Write("ISOCELES");
                }

                //EQUILATERO
                else if (meusLados[0] == meusLados[1] && meusLados[1] == meusLados[2])
                {
                    Console.Write("EQUILATERO");
                }
                //ESCALENO
                else 
                {
                    Console.Write("ESCALENO");
                }

                int soma = meusLados[0] * meusLados[0] + meusLados[1] * meusLados[1];
                if (soma == meusLados[2]* meusLados[2])
                {
                    Console.WriteLine(" E RETÂNGULO!");
                }


                //AREA
                double p = Convert.ToDouble(meusLados[0] + meusLados[1] + meusLados[2]) / 2;
                double area= Math.Sqrt(p * (p-meusLados[0])
                                         * (p-meusLados[1])
                                         * (p-meusLados[2]) );
                Console.WriteLine("\nE SUA ÁREA É : " + area);


            }else Console.WriteLine("NÃO EXISTE ESSE TRIANGULO!!!");




            Console.ReadKey();

        }
    }
}


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
            int[] meusLados= {0,0,0 };
            Console.Write("AVALIADOR DE TRIANGULOS! DIGITE OS LADOS QUE FORMAM O TRIANGULO!\n");
            meusLados[0] = Convert.ToInt32( Console.ReadLine() );
            meusLados[1] = Convert.ToInt32(Console.ReadLine());
            meusLados[2] = Convert.ToInt32(Console.ReadLine());

            //A = MENOR / B = MEIO / C = MAIOR
            Array.Sort(meusLados);


            //ISOCELES
            if (meusLados[0] != meusLados[1] && meusLados[1] == meusLados[2])
            {
                Console.WriteLine("ISOCELES");
            }

            //EQUILATERO
            if (meusLados[0] == meusLados[1] && meusLados[1] == meusLados[2])
            {
                Console.WriteLine("EQUILATERO");
            }
            //ESCALENO


            
            
            Console.ReadKey();

        }
    }
}
/*
if ( (a>b && b > c) || (b > a && a > c) || (c > b && b > a) )
            {
                Console.WriteLine("Escaleno");
            }
            */

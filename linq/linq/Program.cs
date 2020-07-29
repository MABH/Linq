using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //FASE 1
            int[] numeros = { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            //IEnumerable<int> pares = from par in numeros
            int[] pares = (from par in numeros
                                     where par % 2 == 0
                          select par).ToArray();

            foreach (int par in pares)
            {
                Console.Write("{0,1} ", par);
            }
            Console.WriteLine(" ");

            //FASE2
            var media = pares.Average();
            Console.WriteLine("La media de los numeros pares es: "+ media);

            var maxima = pares.Max();
            Console.WriteLine("El máximo de los numeros pares es: " + maxima);

            var minima = pares.Min();
            Console.WriteLine("El mínimo de los numeros pares es: " + minima);

            //FASE3
            int[] mayores =  (from mayor in numeros
                                        where mayor > 5
                                        select mayor).ToArray();

            int[] menores = (from menor in numeros
                                       where menor < 5
                                       select menor).ToArray();

            Console.Write("Numeros mayores de 5: ");
            foreach (int mayor in mayores)
            {
                Console.Write("{0,1} ", mayor);
            }
            Console.WriteLine(" ");

            Console.Write("Numeros menores de 5: ");
            foreach (int menor in menores)
            {
                Console.Write("{0,1} ", menor);
            }
            Console.WriteLine(" ");

            //FASE4
            string[] noms = { "David", "Sergio", "Mari", "Laura", "Oscar", "Julia", "Oriol" };
            string[] iniciales =  (from o in noms                                            
                                             where o.StartsWith("O")
                                             select o).ToArray();

            foreach (string o in iniciales)
            {
                Console.Write("{0,1} ", o);
            }
            Console.WriteLine(" ");


            string[] lletres = (from sis in noms
                                where sis.Length>=6
                                select sis).ToArray();

            foreach (string sis in lletres)
            {
                Console.Write("{0,1} ", lletres);
            }
            Console.WriteLine(" ");


            string[] ordenado = (from des in noms
                                orderby des descending
                                select des).ToArray();

            foreach (string des in ordenado)
            {
                Console.Write("{0,1} ", des);
            }
            Console.WriteLine(" ");
        }
    }
}

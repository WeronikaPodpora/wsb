using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice000
{
    class Program
    {
        static void Main(string[] args)

        {
            //Typ wartościowy
            int a = 10;
            int b = a;

            a--;

            Console.WriteLine("Zmienna a: {0}", a); //9
            Console.WriteLine("Zmienna b: {0}", b); //11


            //Typ referencyjny
            int[] tabA = { 2, 2, 2 };
            int[] tabB = tabA;

            tabA[2] = 10;
            tabB[0] = 8;

            Console.WriteLine("Wyświetlenie tablicy A: ");
            foreach (int item in tabA)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();


            //Kopiowanie tablic
            int[] tab = { 1, 2, 3, 4, 5 };
            int[] tabCopy = new int[5];

            foreach (int item in tabCopy)
            {
                Console.Write("{0} ", item);
            }

            tab.CopyTo(tabCopy, 0);
            
            foreach (int item in tabCopy)
            {
                Console.WriteLine("{0} ", item);
            }


            //2 sposób kopiowania tablicy

            Console.WriteLine("sdf");

            int[] tabCopy2 = new int[5];
            Array.Copy(tab, tabCopy, 3);

            // Array.Copy(tab, tabCopy, tab.Length);

            foreach (int item in tabCopy)
            {
                Console.Write("{0} ", item);
            }


            Console.ReadKey();
        }
    }
}

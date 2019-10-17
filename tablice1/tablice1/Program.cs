using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Napisz program, który w 10-elementwoej tablicy jednowymiarowej
             * o nazwie tab umieszcza liczby całkowite z przedziału od 1 do 10
             */

            int n = 10, i;

            //Deklaracja tablicy o nazwie tab typu całkowitego o rozmiarze n = 10
            
            int[] tab = new int[n];

            for (i = 0; i < tab.Length; i++)
            {
                tab[i] = i;
            }

            //Wyświetlenie zawartości tablicy

            for (i = 0; i < tab.Length; i++)
            {
                Console.Write("{0} ", tab[i]);
            }

            /*Napisz program, który w 5-elementowej tablicy jednowymiarowej
             * o nazwie colors
             * umieszcza nazwy kolorów podane z klawiatury przez użytkownika (for)
             * wyświetl kolory w formacie (while):
             * 
             * kolor1: red
             * kolor2: blue
             * ...
             * kolor5: yellow
             */





            Console.ReadKey();
        }
    }
}

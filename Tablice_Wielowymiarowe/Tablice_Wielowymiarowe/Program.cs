using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice_Wielowymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] values = new int[,]

            /*
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16}
            };

            for (int i=0;i<4; i++)

            {
                for (int j=0; j<4; j++)
                {
                    Console.Write(values[i,j] + "\t");
                   
                }
                Console.WriteLine();
            }

                */







            /*
            {
                { 0, 1, 2},
                { 3, 4, 5},
                { 6, 7, 8}
            };


            int[,] numbers = new int[3, 3];

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = i * 3 + j;
                }

                Console.WriteLine();

                for ( int i = 0; i < numbers.GetLength(0); i++)
                {
                    for (int j = 0; j < numbers.GetLength(1); j++)
                }
            }
            */





            //TABLICE NIEREGULARNE


            /*
             * Wyświetl zawartość tablicy number
             * 
             * number[0, 0] = 1
             * number[0, 1] = 2
             * 
             * number[1, 0] = 3
             * number[1, 1] = 4
             * number[1, 2] = 5
             * number[1, 3] = 6
             * 
             * number[2, 0] = 7
             */

            /*
            string[][] country = new string[4][];

            Console.WriteLine("\nRozmiar zewnętrznego wymiaru tablicy nieregularnej");

            int[][] number = new int[3][]
            {
                new int[] {1, 2},
                new int[] {3, 4, 5, 6},
                new int[] {7}
            };

            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number[i].Length; j++)
                {
                    Console.WriteLine("number[{0},{1}] = {2}", i, j, number[1][j]);
                }
                Console.WriteLine();
            }
            */





            //UPROSZCZONE WYRAŻENIA INICJALIZACJI TABLIC
            

            /*
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine(vowels[0]);     //a

            byte[,] age =
            {
                {20, 30},
                {15, 35},
                {25, 35}
            };
            Console.WriteLine(age[2, 0]);

            string[][] name =
            {
                new string[] {"Katarzyna"},
                new string[] {"Asia", "Emilia"},
                new string[] {"Monika"},
            };
            Console.WriteLine(name[1][1]);   //Emilia




            // ilość wymiarów

            Console.WriteLine("Samogłoski: {0}", vowels.Rank);  //1
            Console.WriteLine("Wiek: {0}", age.Rank);   //2
            Console.WriteLine("Wiek: {0}", name.Rank);   //1
            */


            /*
             * Zapisz tabliczy tłumaczenia słów:
             * 
             * 1 Poniedziałek      Monday
             * 2 Wtorek            Tuesday
             * 
             * Użytkownik wprowadza z klawiatury polskie słowo
             * i angielskie tłumaczenie:
             * Podaj pierwszy dzień tygodnia (j. polski):
             * Podaj pierwszy dzień tygodnia (j. angielski):
             */






                Console.ReadKey();

        }
    }
}

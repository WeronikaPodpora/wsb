using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
             * Napisz program, który za pomocą intrukcji do...while
             * dla danych wartości zmieniających się wprzedziale od 0 do 15
             * oblicza wartość funkcji y = 4x
             */

            /*
             int y = 0, x = 0;
             do
             {
                 y = 4 * x;
                 Console.WriteLine("x = {0}\ty = {1}", x, y);
                 x++;
             } while (x <= 15);
             */





            /*
             * Napisz program  znajdujący się powyżej za pomocą pętli while
             */

            /* 
            int y = 0;
             int x = 0;
             while (x <= 15)
             {
                 y = 4 * x;
                 Console.WriteLine("x = {0}\ty = {1}", x, y);
                 x++;
             }
             */






            /*
             * Napisz program, który za pomocą instrukcji while
             * dla danych wartości x zmieniających się w przedziale od 1 do 50
             * obliczy ich sumę
             */

            /*
            x = 1;
            int suma = 0;
            while (x <= 50)
            {
                suma += x;
                x++;
            }
            Console.WriteLine("Suma wynosi: {0}", suma);
            */





            /*
             * Napisz program, który za pomocą pętli for sumuje liczby
             * nieparzyste z przedziału 1 do 10
             */

            /*
           suma = 0;
            for(int i = 1; i <= 10; i++)
            {
                if (i % 2 ! = 0)
                suma += i;
            }
            Console.WriteLine("Suma liczb wynosi: {0}\n", suma);
            */





            /*
             * Wyświetl tabliczkę mnożenia za pomocą dwóch pętli do...while
             */

            /*
            Console.WriteLine("Tabliczka mnożenia:");

            int n = 10, row, col;
            row = 1;
            do
            {
                col = 1;
                do
                {
                    //Console.Write(row * col + "\t");
                    Console.Write("{0}\t", row * col);
                    col++;
                }   while (col <= n);
                    row++;
                    Console.WriteLine();
            } while (row <= n);
            */





            /*
             * Napisz program, który wyświetli duże litery alfabetu
             * od A do Z i od Z do A, z wykorzystaniem pętli for
             * np. A, B, C, ..., Z.
             * np. Z, Y, X, ..., A.
             */

            /*
            char znak = 'A';
            for (; znak <= 'Z'; znak++)
            {
                if (znak != 'Z')
                    Console.Write("{0}, ", znak);
                Console.Write("{0}.", znak);
            }

            Console.WriteLine();

            znak--;

            for (; znak >= 'A'; znak--);
            {
                if (znak != 'A')
                    Console.Write("{0}, ", znak);
                else
                    Console.Write("{0}.", znak);
            }
            */



            //continue
            int j = 1;
            for (; j <= 10; j++)
            {
                if (j == 2 || j == 5 || j == 7)
                    continue;
                else
                    Console.Write("{0} ", j);
            }
            Console.WriteLine();

            //break;
            int j = 1;
            for (; j <= 10; j++)
            {
                if (j == 2 || j == 5 || j == 7)
                    break;
                else
                    Console.Write("{0} ", j);
            }
            Console.WriteLine();




            Console.ReadKey();
            
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentarz

            /*komentarz
             * w
             * wielu liniach
             */

            Console.WriteLine("Janusz"); //komentarz

            //zmienne i typy danych

            int x = 10;
            x = 15;
            Console.WriteLine(x);

            int x1, y = 10, z = 15;
            x1 = 2;

            Console.WriteLine("Zmienna x1 wynosi: ");
            Console.WriteLine(x1);

            //konkakenacja
            // \n nowa linia
            Console.WriteLine("y = " + y + "\nz = " + z);

            int a = 10;
            int b = a;
            b = 15;
            Console.WriteLine(a + " " + b);

            //alternatywny sposób deklaracji zmiennej
            //int c = 0;

            int c = new int(); //wartość domyślna ==> null (brak referencji)

            Console.WriteLine("wartość zmiennej c: " + c);

            Console.Write("Podaj swoje imie");
            string name = Console.ReadLine("");
            Console.WriteLine("twoje imię podane z klawiatury: " + name);

            int z1 = 12;

            int z2 = 20;

            float y1 = 10.55F;

            Console.WriteLine("Zmienna y1 = " + y1);

            double y2 = 15.95;
            Console.WriteLine("Zmiena y2 = " + y2);

            //oblicz pole prostokąta, dane użytkownik podaje z klawiatury

            Console.Write("Podaj bok A:");
            double bokA = double.Parse(Console.ReadLine());

            Console.Write("Podaj bok B: ");
            double bokB = double.Parse(Console.Readline());

            double result = bokA * bokB;
            Console.WriteLine("Pole wynosi: " + result);


            Console.ReadKey();
        }
    }
}

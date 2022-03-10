using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1

{
    class Program
    {
        static void Main(string[] args)

        {

            Student library = new Student();

            library.name = "Полоцкая городская";

            library.kurs = 3;

            library.pol = 1;


            Console.WriteLine($"{library.name} {library.kurs} {library.pol}");

            Student lib1 = new Student("Полоцкая центральная", 2, 0);

            Console.WriteLine($"{library.name} {library.kurs} {library.pol}");

            Console.ReadKey();

        }

    }

}
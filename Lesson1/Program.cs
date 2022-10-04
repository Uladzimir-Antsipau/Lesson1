using System;
using Library;

namespace Lesson1
{
    class Program
    {
        /* программа меняется в зависимости от используемой библиотеки
         * меняйте зависимость проектов Lesson1, LibraryRealization1, LibraryRealization2
         * для разных результатов
         * Lesson1 <- LibraryRealization[1 или 2] <- ColorRealization[1 или 2]
         */
        static void Main(string[] args)
        {

            Class.DoThings();

            Console.WriteLine("End of the program");
        }
    }
}


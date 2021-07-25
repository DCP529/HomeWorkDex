using System;

namespace Dex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Собака говорит:");

            var dog = new Dog(15, 150);
            dog.Voice();

            Console.ReadLine();
        }
    }
}

using System;

namespace Dex
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog(15, 150);
            Console.WriteLine("Собака говорит:");
            dog.Voice();

            Console.ReadLine();
        }
    }
}

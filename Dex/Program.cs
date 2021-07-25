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

            var cat = new Cat();
            Console.WriteLine("Кошка говорит:");
            cat.Voice();

            //cat и dog - наследники Animal, но Voice у них работает по разному

            Console.ReadLine();
        }
    }
}

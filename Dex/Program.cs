using System;

namespace Dex
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Колесник Тимофей Анатольевич", DateTime.Now, "Днестровск", 1);
            var person2 = new Person("Антонов Юрий Михайлович", DateTime.Now, "Днестровск", 1);
            bool result = person1.Equals(person2);
            int getHashCode = person1.GetHashCode();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dex
{
    class Dog : Animal
    {
        public Dog(double weight, double height) : base( weight, height) {}

        public override void Voice()
        {
            Console.WriteLine("Гав гав гав"); 
        }
    }
}

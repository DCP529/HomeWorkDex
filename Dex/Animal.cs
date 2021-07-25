using System;
using System.Collections.Generic;
using System.Text;

namespace Dex
{
    abstract class Animal

    {
        protected double Weight { get; set; }
        protected double Height { get; set; }

        public Animal(){}

        public Animal(double weight, double height)
        {
            Weight = weight;
            Height = height;
        }

        public abstract void Voice();

    }
}

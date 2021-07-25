using System;

namespace Dex
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Figure(1, 4, 10000000000);

            Console.WriteLine(triangle.Square); // 10000000000 - изначальное значение

            var triangel2 = Square(triangle);

            Console.WriteLine(triangel2.Square); // 1 - присвоенное измененное значение
            Console.WriteLine(triangle.Square); // 1 - измененное значение, снизу также

            triangel2 = SquareNewObject(triangle);

            Console.WriteLine(triangel2.Square); // 1
            Console.WriteLine(triangle.Square); // 1

            



            var triangleStruct = new FigureStruct(1, 4, 10000000000);

            Console.WriteLine(triangleStruct.Square); // 10000000000 - изначальное значение

            var triangleStruct2 = SquareStruct(triangleStruct);

            Console.WriteLine(triangleStruct2.Square); // 1 - присвоенное измененное значение
            Console.WriteLine(triangleStruct.Square); // 10000000000 - не поменялось тк не является ссылкой, снизу тоже самое

            triangleStruct2 = SquareNewObjectStruct(triangleStruct);

            Console.WriteLine(triangleStruct2.Square); // 1
            Console.WriteLine(triangleStruct.Square); // 10000000000

            Console.ReadLine();
        }

        public static Figure SquareNewObject(Figure figure)
        {
            double radius1 = figure.SideLength / (2 * Math.Sin((180 / figure.NumberSides) * Math.PI / 180.0)); //радиус описанной окружности

            double radius2 = radius1 * Math.Cos((180 / figure.NumberSides) * Math.PI / 180.0);//радиус вписанной окружности

            double square = 0.5 * (figure.NumberSides * figure.SideLength) * radius2;

            figure = new Figure();

            figure.Square = square;

            return figure;
        }
        public static Figure Square(Figure figure)
        {
            double radius1 = figure.SideLength / (2 * Math.Sin((180 / figure.NumberSides) * Math.PI / 180.0)); //радиус описанной окружности

            double radius2 = radius1 * Math.Cos((180 / figure.NumberSides) * Math.PI / 180.0);//радиус вписанной окружности

            double square = 0.5 * (figure.NumberSides * figure.SideLength) * radius2;

            figure.Square = square;

            return figure;
        }


        public static FigureStruct SquareNewObjectStruct(FigureStruct figure)
        {
            double radius1 = figure.SideLength / (2 * Math.Sin((180 / figure.NumberSides) * Math.PI / 180.0)); //радиус описанной окружности

            double radius2 = radius1 * Math.Cos((180 / figure.NumberSides) * Math.PI / 180.0);//радиус вписанной окружности

            double square = 0.5 * (figure.NumberSides * figure.SideLength) * radius2;

            figure = new FigureStruct();

            figure.Square = square;

            return figure;
        }
        public static FigureStruct SquareStruct(FigureStruct figure)
        {
            double radius1 = figure.SideLength / (2 * Math.Sin((180 / figure.NumberSides) * Math.PI / 180.0)); //радиус описанной окружности

            double radius2 = radius1 * Math.Cos((180 / figure.NumberSides) * Math.PI / 180.0);//радиус вписанной окружности

            double square = 0.5 * (figure.NumberSides * figure.SideLength) * radius2;

            figure.Square = square;

            return figure;
        }

    }
}

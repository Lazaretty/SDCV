using System;
using ShapesLib.Models;

namespace SDCV_Test
{
    class Program
    {
        public static void Test0()
        {
            Console.WriteLine("_________________________________________");
            var group1 = new ShapeGroup("*");
            group1.About();
            var group2 = new ShapeGroup("+");
            group2.About();
            Console.WriteLine("_________________________________________");
        }
        public static void Test1()
        {
            Console.WriteLine("_________________________________________");
            var group1 = new ShapeGroup("*");
            var circle1 = new Circle(2);
            var sphere1 = new Sphere(2);
            var square1 = new Square(3);

            group1.AddToGroup(circle1);
            group1.AddToGroup(sphere1);
            group1.AddToGroup(square1);

            group1.About();
            Console.WriteLine("_________________________________________");
        }
        public static void Test2()
        {
            Console.WriteLine("_________________________________________");
            var group1 = new ShapeGroup("*");
            var circle1 = new Circle(2);
            var sphere1 = new Sphere(2);
            var square1 = new Square(3);

            group1.AddToGroup(circle1);
            group1.AddToGroup(sphere1);
            group1.AddToGroup(square1);

            var group2 = new ShapeGroup("+");
            var square2 = new Square(1);
            var sphere2 = new Sphere(1);

            group2.AddToGroup(square2);
            group2.AddToGroup(sphere2);
            group2.AddToGroup(group1);

            group2.About();
            Console.WriteLine("_________________________________________");
        }
        public static void Test3() 
        {
            Console.WriteLine("_________________________________________");
            var group1 = new ShapeGroup("*");
            var circle1 = new Circle(2);
            var sphere1 = new Sphere(2);
            var square1 = new Square(3);

            group1.AddToGroup(circle1);
            group1.AddToGroup(sphere1);
            group1.AddToGroup(square1);

            var group2 = new ShapeGroup("+");
            var square2 = new Square(1);
            var sphere2 = new Sphere(1);

            group2.AddToGroup(square2);
            group2.AddToGroup(sphere2);
            group2.AddToGroup(group1);

            var group3 = new ShapeGroup("*");
            var square3 = new Square(1);
            var sphere3 = new Sphere(2);

            group3.AddToGroup(square3);
            group3.AddToGroup(sphere3);
            group3.AddToGroup(group2);

            group3.About();
            Console.WriteLine("_________________________________________");
        }
        public static void Test4()
        {
            Console.WriteLine("_________________________________________");
            var group1 = new ShapeGroup("*");
            group1.About();
            var group2 = new ShapeGroup("+");
            group2.AddToGroup(group1);
            group1.AddToGroup(group2);
            group2.About();
            Console.WriteLine("_________________________________________");
        }

        static void Main(string[] args)
        {
            Test0();
            Test1();
            Test2();
            Test3();
            //Test4(); // exeption : recursive definition group1 contains group2, group2 contains group1 

        }
    }
}

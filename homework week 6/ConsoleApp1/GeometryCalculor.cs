using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose option (triangle, square, radians)");

            string option = Console.ReadLine();

            switch (option)
            {
                 case "triangle":
                 Console.WriteLine($"enter side:");
                 double side = double.Parse(Console.ReadLine());
                 Console.WriteLine("enter height:");
                 double height = double.Parse(Console.ReadLine());
                 double trianglearea= side*height/2;

                 Console.WriteLine($"the area of the triangle is {trianglearea}"  );

                break;
                case "square":
                 Console.WriteLine($"enter side:");
                 double squareside = double.Parse(Console.ReadLine());
                 double squarearea = Math.Pow(squareside,2);


                 Console.WriteLine($"the area of the square is {squarearea}");
                 break;
                 case "radians":
                    Console.WriteLine("Enter the degrees you want to transform in radians");
                    double degrees = double.Parse(Console.ReadLine());
                    double radians = (Math.PI * degrees) / 180;
                    Console.WriteLine($"Your degrees in radians are = {radians}");
                   break;
                default:
                    Console.WriteLine("Incorrect option!");
                    break;
             



            }
        }
    }   }

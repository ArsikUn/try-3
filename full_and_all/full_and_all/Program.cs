//Есть разные виды символов: #, $, @ и т.д.. В метод приходит информация о символах и из них должно выводиться некое подобие флага.

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;

namespace ConsoleApplication6
{
    class Flag
    {

        static void Main(string[] args)
        {
            while (true)
            {
                int d;
                Console.Write("Меню:\n1) Task1 \n2) Task2 vpadly perevoodit bilo\n3) Task3 \n\nYOUR NUMBER: ");
                d = int.Parse(Console.ReadLine());
                switch (d)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    default:
                        Console.WriteLine("ERROR ERROR ERROR");
                        break;
                }

                Console.Write("\nEnter smth,for return");
                Console.ReadLine();
                Console.Clear();
            }

            void Task1()
            {

                Console.WriteLine("Enter 2 characters");
                var element = Console.ReadLine();
                if (element != "  " && element.Length != 2)
                {
                    Console.WriteLine("its a error\n");
                }
                else
                {
                    var flag = new char[6, 40];
                    for (var i = 0; i < flag.GetLength(0); i++)
                    for (var j = 0; j < flag.GetLength(1); j++)
                        if (i != 2 && i != 3) flag[i, j] = Convert.ToChar(element.Substring(0, 1));
                        else flag[i, j] = Convert.ToChar(element.Substring(1));
                    for (var i = 0; i < flag.GetLength(0); i++)
                    {
                        for (var j = 0; j < flag.GetLength(1); j++) Console.Write(flag[i, j]);
                        Console.Write("\n");
                    }
                }
            }
            void Task3()
            {
                Console.WriteLine("HI im here, we dont have enemys, and dont want to create this klass");
            }
        }
        static void Task2()
        {
                Shape[] shapes = new Shape[4];
                Squre squre = new Squre();
                Triangle triangle = new Triangle();
                Circle circle = new Circle();
                Rectangle rectangle = new Rectangle();

                shapes[0] = squre;
                shapes[1] = triangle;
                shapes[2] = circle;
                shapes[3] = rectangle;

                Console.WriteLine("q-exit");
                while (true)
                {
                    var s = Console.ReadKey(true);
                    if (s.KeyChar == 'q') break;
                    shapes[new Random().Next(4)].Draw();
                    Console.ReadKey(true);
                }
        }

    }

        abstract class Shape
        {
            abstract public void Draw();
        }

        class Squre : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("kvadrat");
            }
        }

        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("kryg");
            }
        }

        class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("krivoi kvadrat");
            }
        }

        class Triangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("treygolnik");
            }
        }

}
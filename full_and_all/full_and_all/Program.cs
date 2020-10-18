using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        public static void Print(string[] points, int choose)
        {
            Console.Clear();
            for (int i = 0; i < points.Length; i++)
                Console.WriteLine("{0} {1}", points[i], i == choose ? "<<--" : "");
        }
        
        public static int Menu(string[] points)
        {
            Console.CursorVisible = false; // Чтобы не было мигающего курсора.
            int choose = 0;
            while (true) // Бесконечный цикл.
            {
                Print(points, choose);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow: choose--; break;
                    case ConsoleKey.DownArrow: choose++; break;
                    case ConsoleKey.D: Console.CursorVisible = true; return -1;
                    case ConsoleKey.Enter: Console.CursorVisible = true; return choose;
                }
                choose = (choose + points.Length) % points.Length; // Зацикливаем выбор.
            }
        }

        void Task1()
        {
            problems
        }

        public static void Main()
        {
            string[] points = { "1) Task №1", "2) Task №2", "3) Task №3", "4)EXIT" };
            int choose = Menu(points);
            Console.WriteLine(choose == -1 ? "enter number pls" : string.Format("Answer to task №{0}", choose + 1));
            Console.ReadLine();
        }
    }
}
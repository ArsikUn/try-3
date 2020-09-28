
//stack

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Linq;

//namespace Сергей
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Queue<string> joke = new Queue<string>();
//            joke.Enqueue("S");
//            joke.Enqueue("e");
//            joke.Enqueue("r");
//            joke.Enqueue("g");
//            joke.Enqueue("e");
//            joke.Enqueue("i");

//            foreach (string p in joke)
//            {
//                Console.Write(p);
//            }
//            Console.WriteLine();
//            for (int i = 0; i < 3; i++)
//                joke.Dequeue();

//            foreach (string p in joke)
//            {
//                Console.Write(p);
//            }
//            Console.ReadLine();
//        }
//    }
//}


//jokes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Файлы_Анекдоты_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the address of file");
            string FilePath = Console.ReadLine();
            Random rd = new Random();
            int n;
            string text = null;

            try
            {
                while (true)
                {
                    Console.Clear();
                    n = rd.Next(1, 6);
                    using (StreamReader sr = new StreamReader(FilePath))
                    {
                        for (int i = 0; i < n; i++)
                        {
                            text = sr.ReadLine();
                        }
                        Console.WriteLine(text);
                    }

                    Console.WriteLine("1 One more\n2 Exit");
                    int condition = int.Parse(Console.ReadLine());
                    switch (condition)
                    {
                        case 1:
                        {
                            continue;
                        }
                            break;
                        case 2:
                        {
                            return;
                        }
                        default:
                        {
                            return;
                        }
                    }
                }
            }





            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

    }
}

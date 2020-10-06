using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;


namespace zadanie_3
{
    static void main()
    {
    Foo();
    Console.WriteLine($"Create objects: {A.count}");
    }

    public static void Foo()
    {
    A someobjects = new A();
    A anyobjects = new A();
    A anybjects = new A();
    }
    class A
    {
        public static int count;
        public A()
        {
            count++;
        }
    }
    class Safer<TM, TB, TD>
    {
        private readonly TM student;
        private readonly TB age;
        private readonly TD group;

        public Safer(TM stud, TB ag, TD gr)
        {
            student = stud;
            age = ag;
            group = gr;
        }


        class Program
        {
            static void second_task()
            {
                Safer<object, object, object> safer = new Safer<object, object, object>(false,25,"Morron");
            }

        }
    }
    namespace task3
    {
        class Program
        {
            static void Main(string[] args)
            {
                DDDDD();
            }

            static void DDDDD()
            {
                Duck[] ducks = new Duck[3];
                lovefulDuck lDuck = new lovefulDuck();
                lovefulDuck.color = "Black";
                RubberDuck RDuck = new RubberDuck();
                RubberDuck.color = "Yellow";
                PlasticDuck PDuck = new PlasticDuck();
                PlasticDuck.color = "Grey";
                ducks[0] = lDuck;
                ducks[1] = RDuck;
                ducks[2] = PDuck;
                Console.WriteLine("q-exit");
                while (true)
                {
                    var s = Console.ReadKey(true);
                    if (s.KeyChar == 'q') break;
                    ducks[new Random().Next(3)].grunt();
                }
            }
            class Duck
            {
                public static string color { get; set; }
                public virtual void grunt()
                {
                    Console.WriteLine("Зов уток!!!");
                }
            }

            class lovefulDuck : Duck
            {
                string word = "Ёжики";
                public override void grunt()
                {
                    Console.WriteLine(word);
                }
            }


            class RubberDuck : Duck
            {
                string word = "Я резиновая утка!!";
                public override void grunt()
                {
                    Console.WriteLine(word);
                }
            }

            class PlasticDuck : Duck
            {
                string word = "Я пластиковая утка!!";
                public override void grunt()
                {
                    Console.WriteLine(word);
                }
            }
        }
    }


}

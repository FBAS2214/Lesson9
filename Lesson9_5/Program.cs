using System;

namespace Lesson9_5
{
    interface IA
    {
        void Get();
    }

    interface IB
    {
        void Get();
    }

    class Any : IA, IB
    {
        //void IA.Get()
        //{
        //    Console.WriteLine("Get IA");
        //}

        //void IB.Get()
        //{
        //    Console.WriteLine("Get IB");
        //}

        public void Get()
        {
            Console.WriteLine("Get IAB");
        }
    }


    class Program
    {
        static void Main()
        {
            // Any any = new Any();
            // ((IA)any).Get();
            // ((IB)any).Get();


            //IA any1 = new Any();
            //IB any2 = new Any();

            //any1.Get();
            //any2.Get();


            Any any = new Any();
            any.Get();
        }
    }
}
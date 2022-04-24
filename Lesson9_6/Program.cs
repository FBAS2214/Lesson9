using System;

namespace Lesson9_6
{
    // interface IGet
    // {
    //     void Get();
    // }
    // 
    // class Base:IGet
    // {
    //     public virtual void Get()
    //     {
    //         Console.WriteLine("Base get");
    //     }
    // }
    // 
    // class Derived : Base
    // {
    //     public override void Get()
    //     {
    //         Console.WriteLine("Derived get");
    //     }
    // }
    // 
    // 
    // 
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Base derived = new Derived();
    //         derived.Get();
    //     }
    // }



    interface IDraw
    {
        public void Erase()
        {
            Console.WriteLine("Default implementation");
        }

        void Draw();
    }


    class Rectangle : IDraw
    {
        public void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }

        public void Erase()
        {
            Console.WriteLine("Erase Rectangle");
        }
    }

    class Circle : IDraw
    {
        public void Draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }





    class Program
    {
        static void Main()
        {
            List<IDraw> figures = new();

            figures.Add(new Circle());
            figures.Add(new Rectangle());

            foreach (IDraw figure in figures)
            {
                figure.Draw();
                figure.Erase();
            }
        }
    }
}
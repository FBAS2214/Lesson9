using System;

namespace Lesson9_3
{
    // Interface inheritance
    // extend

    interface IFoo
    {
        void Foo();
    }

    interface IBoo : IFoo
    {
        void Boo();
    }

    interface IGoo : IBoo
    {
        void Goo();
    }

    class Any : IGoo
    {
        public void Boo()
        {
            throw new NotImplementedException();
        }

        public void Foo()
        {
            throw new NotImplementedException();
        }

        public void Goo()
        {
            throw new NotImplementedException();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
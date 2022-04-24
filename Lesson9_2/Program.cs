using System;

namespace Lesson9_2
{
    abstract class Human
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateOnly BirthDate { get; set; }

        public override string ToString()
            => $@"Name: {Name}
Surname: {Surname}
BirthDate: {BirthDate}";
    }


    abstract class Employee : Human
    {
        public string? Position { get; set; }
        public double Salary { get; set; }

        public override string ToString()
            => $@"{base.ToString()}
Position: {Position}
Salary: {Salary}";
    }


    interface IWorker
    {
        bool IsWorking { get; set; }
        void Work();
    }

    interface IManager
    {
        void Organize();
        void Control();
        void MakeBudget();
    }


    class Director : Employee, IManager, IWorker
    {
        public bool IsWorking { get; set; }

        public void Control(){}
        public void MakeBudget(){}
        public void Organize(){}

        public void Work(){}
    }

    class Seller : Employee, IWorker
    {
        public bool IsWorking { get; set; }
        public void Work() { }
    }

    class Cashier : Employee, IWorker
    {
        public bool IsWorking { get; set; }
        public void Work() { }
    }




    class Program
    {
        static void Foo(IManager manager){}

        static void Main(string[] args)
        {
            IManager worker = new Director();
            Foo(worker);
        }
    }
}
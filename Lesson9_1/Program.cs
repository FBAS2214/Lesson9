using System;
using System.Collections.Generic;

namespace Lesson9_1
{
    // Inheritance (is a)
    // Association (has a, part of)
    // Interface   (Multiple base, can do)



    abstract class Car { }

    interface ISport {
        void Sport();
    }
    interface ITurbo { }
    interface IClassic { }

    class Mercedes : Car, IClassic, ISport
    {
        public void Sport()
        {
            Console.WriteLine("Mercedes sport");
        }
    }
    class Bmw : Car, IClassic, ISport, ITurbo {
        public void Sport()
        {
            Console.WriteLine("Bmw sport");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<ISport> sportCars = new();

            sportCars.Add(new Mercedes());
            sportCars.Add(new Bmw());

            foreach (var sportCar in sportCars)
                sportCar.Sport();
        }

    }
}
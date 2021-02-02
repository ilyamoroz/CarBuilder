using System;
using System.Collections.Generic;

namespace CarsBuilder
{
    

    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("BMW:");
            director.CreateBMW();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Mercedes-Benz:");
            director.CreateMercedes();
            Console.WriteLine(builder.GetProduct().ListParts());

            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace CarsBuilder
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car:");
            BMWBuilder bmwBuilder = new BMWBuilder();
            bmwBuilder.AddModel();
            bmwBuilder.AddEngine();
            bmwBuilder.AddCarBody();
            bmwBuilder.AddWheel();

            Console.WriteLine(bmwBuilder.Build().ToString());

            Console.WriteLine("Car:");
            MercedesBuilder mercedesBuilder = new MercedesBuilder();
            mercedesBuilder.AddModel();
            mercedesBuilder.AddEngine();
            mercedesBuilder.AddCarBody();


            Console.WriteLine(mercedesBuilder.Build().ToString());


             
        }
    }
}
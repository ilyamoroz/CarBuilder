using System;
using System.Collections.Generic;

namespace CarsBuilder
{
    

    class Program
    {
        static void Main(string[] args)
        {
            BMWBuilder bmwBuilder = new BMWBuilder();
            bmwBuilder.AddModel();
            bmwBuilder.AddEngine();
            bmwBuilder.AddCarBody();
            bmwBuilder.AddWheel();
            Console.WriteLine(bmwBuilder.Build());


            MercedesBuilder mercedesBuilder = new MercedesBuilder();
            mercedesBuilder.AddModel();
            mercedesBuilder.AddEngine();
            mercedesBuilder.AddCarBody();

            Console.WriteLine(mercedesBuilder.Build());   
        }
    }
}
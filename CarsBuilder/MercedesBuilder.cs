using System;
using System.Collections.Generic;
using System.Text;

namespace CarsBuilder
{
    class MercedesBuilder : IBuilder
    {
        Car car = new Car();
        public MercedesBuilder()
        {
            car.brand = "Mercedes-Benz, ";
        }
        public void AddModel()
        {
            car.model = "s63, ";
        }

        public void AddEngine()
        {
            car.engine = "3.0, ";
        }
        public void AddWheel()
        {
            car.wheel = "16, ";
        }
        public void AddCarBody()
        {
            car.carBody = "Sedan";
        }
        public Car Build()
        {
            return car;
        }
    }
}

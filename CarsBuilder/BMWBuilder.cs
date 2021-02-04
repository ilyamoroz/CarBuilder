using System;
using System.Collections.Generic;
using System.Text;

namespace CarsBuilder
{
    public class BMWBuilder : IBuilder
    {
        public Car car = new Car();
        
        public BMWBuilder()
        {
            car.brand = "BMW, ";
        }
        public void AddModel()
        {
            car.model = "M3, ";
        }

        public void AddEngine()
        {
            car.engine = "2.4, ";
        }
        public void AddWheel()
        {
            car.wheel = "17, ";
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

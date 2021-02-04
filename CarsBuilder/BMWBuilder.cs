using System;
using System.Collections.Generic;
using System.Text;

namespace CarsBuilder
{
    public class BMWBuilder : IBuilder
    {
        object car;
        public BMWBuilder()
        {
            car = "BMW,";
        }
        public void AddModel()
        {
            car += "Moddel: M3,";
        }

        public void AddEngine()
        {
            car += "Engine: 2.4,";
        }
        public void AddWheel()
        {
            car += "Wheels: 17,";
        }
        public void AddCarBody()
        {
            car += "Sedan";
        }

        public object Build()
        {
            return car;
        }
    }
}

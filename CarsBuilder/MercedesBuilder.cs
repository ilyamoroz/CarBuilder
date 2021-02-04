using System;
using System.Collections.Generic;
using System.Text;

namespace CarsBuilder
{
    class MercedesBuilder : IBuilder
    {
        object car;
        public MercedesBuilder()
        {
            car += "Mercedes-Benz,";
        }
        public void AddModel()
        {
            car += "Model: s63,";
        }

        public void AddEngine()
        {
            car += "Engine: 3.0,";
        }
        public void AddWheel()
        {
            car += "Wheels: 16,";
        }
        public void AddCarBody()
        {
            car += "Car Body: Sedan";
        }
        public object Build()
        {
            return car;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CarsBuilder
{
    public class Car
    {
        public string brand { get; set; }
        public string model { get; set; }
        public string engine { get; set; }
        public string wheel { get; set; }
        public string carBody { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Car: \n" + brand);
            sb.Append("Model: " + model + "\n");
            sb.Append("Engine: " + engine + "\n");
            sb.Append("Wheel: " + wheel + "\n");
            sb.Append("CarBody: " + carBody + "\n");
            return sb.ToString();
        }
    }
}

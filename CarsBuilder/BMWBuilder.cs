using System;
using System.Collections.Generic;
using System.Text;

namespace CarsBuilder
{
    public class BMWBuilder : IBuilder
    {
        private List<object> _product = new List<object>();
        public BMWBuilder()
        {
            this.Reset();
            _product.Add("BMW,");
        }

        public void Reset()
        {
            _product.Clear();
        }
        public void AddModel()
        {
            _product.Add("Moddel: M3,");
        }

        public void AddEngine()
        {
            _product.Add("Engine: 2.4,");
        }
        public void AddWheel()
        {
            _product.Add("Wheels: 17,");
        }
        public void AddCarBody()
        {
            _product.Add("Sedan");
        }

        public string Build()
        {
            StringBuilder sb = new StringBuilder();
            Console.Write("Car: \n");
            foreach (string part in _product)
            {
                sb.Append(part + " ");
            }
            return sb.ToString();
        }
    }
}

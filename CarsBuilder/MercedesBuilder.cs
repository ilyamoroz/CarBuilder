using System;
using System.Collections.Generic;
using System.Text;

namespace CarsBuilder
{
    class MercedesBuilder : IBuilder
    {
        private List<object> _product = new List<object>();
        public MercedesBuilder()
        {
            this.Reset();
            _product.Add("Mercedes-Benz,");
        }

        public void Reset()
        {
            _product.Clear();
        }
        public void AddModel()
        {
            _product.Add("Model: s63,");
        }

        public void AddEngine()
        {
            _product.Add("Engine: 3.0,");
        }
        public void AddWheel()
        {
            _product.Add("Wheels: 16,");
        }
        public void AddCarBody()
        {
            _product.Add("Car Body: Sedan");
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

using System;
using System.Collections.Generic;
using System.Text;

namespace CarsBuilder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }
        public void AddMark(string mark)
        {
            this._product.Add(mark);
        }

        public void AddEngine(string engine)
        {
            this._product.Add(engine);
        }

        public void AddCarBody(string body)
        {
            this._product.Add(body);
        }
        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}

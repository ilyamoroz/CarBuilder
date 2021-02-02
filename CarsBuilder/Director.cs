using System;
using System.Collections.Generic;
using System.Text;

namespace CarsBuilder
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }



        public void CreateBMW()
        {
            this._builder.AddMark("BMW");
            this._builder.AddEngine("2.4");
            this._builder.AddCarBody("Sedan");
        }
        public void CreateMercedes()
        {
            this._builder.AddMark("Mercedes-Benz");
            this._builder.AddEngine("3.0");
            this._builder.AddCarBody("Sedan");
        }
    }
}

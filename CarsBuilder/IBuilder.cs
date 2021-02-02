using System;
using System.Collections.Generic;
using System.Text;

namespace CarsBuilder
{
    public interface IBuilder
    {
        void AddMark(string mark);

        void AddEngine(string engine);

        void AddCarBody(string carBody);
    }
}

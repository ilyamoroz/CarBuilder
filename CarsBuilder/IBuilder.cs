using System;
using System.Collections.Generic;
using System.Text;

namespace CarsBuilder
{
    public interface IBuilder
    {
        void AddModel();
        void AddEngine();
        void AddWheel();
        void AddCarBody();
        object Build();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class SportBike : Motorcycle 
    {
        internal void Bike ()
        {
            _odometr1 = 25;
            StartProtected();
            StartProtectedPrivate();
            StartEngine1();
            StartProtected();
            StartProtectedPrivate();
            _speed = 25;
            _odometr3 = 55;
            _odometr2 = 26;
            _speed = 33;
            int number4 = _maxSpeed;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces101
{
    public class Car : IEquatable<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public bool Equals(Car car)
        {
            if (this.Make == car.Make &&
                this.Model == car.Model &&
                this.Year == car.Year)
                return true;
            else
                return false;
        }
    }

    //So you can have an interface, from which the inheriting class MUST provide an implemention of everything
    //You have a virtual METHOD within a class that the inheriting class MUST provide an override to it
    //You have abstract classes that the inheriting class can OVERRIDE pieces and parts - it's like a template

}

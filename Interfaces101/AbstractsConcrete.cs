using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces101
{
    public class Human : BaseHuman
    {
        public override bool MethodToOverride()
        {
            return true;
        }
    }

    public class Ostrich : BaseFlyingAnimal
    {
        public override bool Flies()
        {
            return false;
        }
    }

}

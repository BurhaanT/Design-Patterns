using Decorator.ConcreteComponent;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ConcreteDecorator
{
    public class DoubleStorey : HouseDecorator
    {
        public DoubleStorey(House house) : base(house)
        {
        }

        public override decimal GetBuildPrice()
        {
            return (base.GetBuildPrice() * 2); //'Cos it's a double storey! :-]
        }
    }
}

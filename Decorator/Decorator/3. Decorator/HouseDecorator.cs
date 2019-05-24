using Decorator.Component;
using Decorator.ConcreteComponent;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorator
{
    public abstract class HouseDecorator : IHouse
    {
        private House _house;
        public HouseDecorator(House house)
        {
            _house = house;
        }
        public virtual decimal GetBuildPrice() => _house.GetBuildPrice();
    }
}

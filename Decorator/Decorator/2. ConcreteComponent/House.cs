using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ConcreteComponent
{
    public class House : IHouse
    {
        public decimal GetBuildPrice() => 100000; //base house price is $100,000
        
    }
}

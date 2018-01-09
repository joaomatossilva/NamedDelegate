using System;
using System.Collections.Generic;
using System.Text;

namespace NamedDelegate
{
    public class StrategyDefault : IStrategy
    {
        public void Execeute()
        {
            Console.WriteLine("Strategy Default");
        }
    }
}

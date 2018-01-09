using System;
using System.Collections.Generic;
using System.Text;

namespace NamedDelegate
{
    public class StrategyA : IStrategy
    {
        public void Execeute()
        {
            Console.WriteLine("Stategy A");
        }
    }
}

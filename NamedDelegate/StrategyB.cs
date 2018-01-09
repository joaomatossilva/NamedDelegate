using System;
using System.Collections.Generic;
using System.Text;

namespace NamedDelegate
{
    public class StrategyB : IStrategy
    {
        public void Execeute()
        {
            Console.WriteLine("Strategy B");
        }
    }
}

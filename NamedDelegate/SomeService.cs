using System;
using System.Collections.Generic;
using System.Text;

namespace NamedDelegate
{
    public class SomeService
    {
        private readonly TheActualNamedDelegate _delegate;

        public SomeService(TheActualNamedDelegate @delegate)
        {
            _delegate = @delegate;
        }

        public void Execute(string strategy)
        {
            var strategyImplementation = _delegate.GetNamed<IStrategy>(strategy);
            strategyImplementation.Execeute();
        }
    }
}

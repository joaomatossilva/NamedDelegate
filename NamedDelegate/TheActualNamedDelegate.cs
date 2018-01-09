using Autofac;

namespace NamedDelegate
{

    /* This is just a little wrapper over the IComponentContext so that 
     * Concrete types like the SomeService does not depend on Autofac types */
    public class TheActualNamedDelegate
    {
        private readonly IComponentContext _context;

        public TheActualNamedDelegate(IComponentContext context)
        {
            _context = context;
        }

        public T GetNamed<T>(string name)
        {
            try
            {
                return _context.ResolveNamed<T>(name);
            }
            catch(Autofac.Core.Registration.ComponentNotRegisteredException)
            {
                return _context.Resolve<T>();
            }
        }
    }
}

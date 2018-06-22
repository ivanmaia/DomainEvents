using Dominio.Core.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ConsoleApp
{
    public class DependencyResolver : IDependencyResolver
    {
        private readonly UnityContainer containerIoc;

        public DependencyResolver(UnityContainer containerIoc)
        {
            this.containerIoc = containerIoc;
        }

        public T GetService<T>()
        {
            return this.containerIoc.Resolve<T>();
        }

        public object GetService(Type type)
        {
            return this.containerIoc.Resolve(type);
        }

        public IEnumerable<T> GetServices<T>()
        {
            return this.containerIoc.ResolveAll<T>();
        }

        public IEnumerable<object> GetServices(Type type)
        {
            return this.containerIoc.ResolveAll(type);
        }
    }
}

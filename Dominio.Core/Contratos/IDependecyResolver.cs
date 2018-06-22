using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Core.Contratos
{
    public interface IDependencyResolver
    {
        T GetService<T>();

        IEnumerable<T> GetServices<T>();

        object GetService(Type type);

        IEnumerable<object> GetServices(Type type);
    }
}

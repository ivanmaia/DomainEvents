using Dominio.Core.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Core.Eventos
{
    public static class DomainEvents
    {
        private static IDependencyResolver _resolver;
        private static List<dynamic> _domainEvents;

        public static void Config(IDependencyResolver resolver)
        {
            DomainEvents._resolver = resolver;
        }

        public static void EnqueueEvent<T>(T domainEvent) where T : IDomainEvent
        {
            if (_domainEvents == null)
            {
                _domainEvents = new List<dynamic>();
            }
            _domainEvents.Add(domainEvent);
        }

        public static void RaiseEnqueuedEvents()
        {
            foreach (var domainEvent in _domainEvents)
            {
                DomainEvents.Raise(domainEvent);
            }
        }

        public static void Raise<T>(T domainEvent) where T : IDomainEvent
        {
            foreach (var handler in GetHandlersFor<T>())
            {
                handler.Handle(domainEvent);
            }
        }

        private static IEnumerable<dynamic> GetHandlersFor<T>() where T : IDomainEvent
        {
            return _resolver.GetServices<IDomainEventHandler<T>>();
        }
    }
}

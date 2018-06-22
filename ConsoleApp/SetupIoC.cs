using Dominio.Core.Contratos;
using Dominio.Core.Eventos;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ConsoleApp
{
    public class SetupIoC
    {
        private static UnityContainer _container;
        public static UnityContainer Setup()
        {
            _container = new UnityContainer();
            _container.RegisterType<ICobrancaAgregadoRepository, CobrancaAgregadoRepository>();
            _container.RegisterType<IDomainEventHandler<DomainEvent>, DomainEventHandler>("DomainEventHandler");
            _container.RegisterInstance<IDependencyResolver>(new DependencyResolver(_container));
            return _container;
        }


    }
}

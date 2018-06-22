using Dominio.Core.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Core.Eventos
{
    public class DomainEventHandler: IDomainEventHandler<DomainEvent>
    {
        public void Handle(DomainEvent ev)
        {
            Console.WriteLine("Event Handler Here: " + ev.EventData);
        }
    }
}

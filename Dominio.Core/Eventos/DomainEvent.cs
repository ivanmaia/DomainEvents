using Dominio.Core.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Core.Eventos
{
    public class DomainEvent: IDomainEvent
    {
        public readonly string EventData;

        public DomainEvent(string eventData)
        {
            this.EventData = eventData;
        }
    }
}

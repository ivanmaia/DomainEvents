using Dominio.Core.Contratos;
using Dominio.Core.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Core.ModuloCobranca.CobrancaAgregado
{
    public class CobrancaAgregado: IAgregateRoot
    {
        private readonly ICobrancaAgregadoRepository _repository;

        public CobrancaAgregado(ICobrancaAgregadoRepository repository)
        {
            this._repository = repository;
        }

        public void FacaAlgoImpressionante()
        {
            _repository.DoSomething();
            DomainEvents.Raise(new DomainEvent("1"));
            DomainEvents.EnqueueEvent(new DomainEvent("2"));
            DomainEvents.EnqueueEvent(new DomainEvent("3"));
            DomainEvents.EnqueueEvent(new DomainEvent("4"));
            DomainEvents.RaiseEnqueuedEvents();
        }
    }
}

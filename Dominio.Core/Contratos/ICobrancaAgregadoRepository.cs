using Dominio.Core.ModuloCobranca.CobrancaAgregado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Core.Contratos
{
    public interface ICobrancaAgregadoRepository: IRepository<CobrancaAgregado>
    {
        void DoSomething();
    }
}

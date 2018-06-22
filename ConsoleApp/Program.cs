using Dominio.Core.Contratos;
using Dominio.Core.Eventos;
using Dominio.Core.ModuloCobranca.CobrancaAgregado;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var container = SetupIoC.Setup();
            DomainEvents.Config(container.Resolve<IDependencyResolver>());
            var cobrancaAgregado = new CobrancaAgregado(container.Resolve<ICobrancaAgregadoRepository>());
            

            cobrancaAgregado.FacaAlgoImpressionante();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}

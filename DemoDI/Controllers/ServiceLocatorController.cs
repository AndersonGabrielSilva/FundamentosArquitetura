using System;
using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDI.Controllers
{
    public class ServiceLocatorController : Controller
    {
        /*Expoe todos os serviços registrados no Statup.
            è uma forma de acessar as injeçoes de dependencia sem ter que passar um a um no construtor
            já que o [FromServices] não é recomendado a utilização, por dificultar os testes e ferir 
            os principios de SRP do Solid.*/
        private readonly IServiceProvider _serviceProvider;

        
        public ServiceLocatorController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        //Requerindo a instancia que está registrado a interface e desta forma eu posso acessar os metodos.
        //É possivel invocar qualquer serviço registrado pela interface, como no exemplo a baixo
        public void Index()        
        {

            // Retorna null se não estiver registrado
            _serviceProvider.GetRequiredService<IClienteServices>().AdicionarCliente(new Cliente());
        }
    }
}

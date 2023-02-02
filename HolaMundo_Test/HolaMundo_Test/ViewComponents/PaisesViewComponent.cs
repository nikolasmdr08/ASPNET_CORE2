using HolaMundo_Test.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolaMundo_Test.ViewComponents
{
    public class PaisesViewComponent: ViewComponent
    {
        public IRepositorioPais RepositorioPais { get;  }
        public PaisesViewComponent(IRepositorioPais repositorioPais)
        {
            RepositorioPais = repositorioPais;
        }

        public IViewComponentResult Invoke()
        {
            var paises = RepositorioPais.ObtenerTodos();
            return View(paises);
        }
    }
}

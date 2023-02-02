using HolaMundo_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolaMundo_Test.Services
{
    public class PaisRepositorioEnMemoria : IRepositorioPais
    {
        public List<Pais> ObtenerTodos()
        {
            List<Pais> paises = new List<Pais>() { 
                new Pais("Argentina")
            };
            return paises;
        }
    }
}

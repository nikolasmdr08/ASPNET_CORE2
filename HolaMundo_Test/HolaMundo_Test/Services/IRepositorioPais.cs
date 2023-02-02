using HolaMundo_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolaMundo_Test.Services
{
    public interface IRepositorioPais
    {
        List<Pais> ObtenerTodos();
    }
}

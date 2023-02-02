using HolaMundo_Test.Data;
using HolaMundo_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolaMundo_Test.Services
{
    public class PaisRepositorioEF : IRepositorioPais
    {
        public PaisRepositorioEF(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public ApplicationDbContext DbContext { get; }

        public List<Pais> ObtenerTodos()
        {
            return DbContext.Paises.ToList();
        }
    }
}

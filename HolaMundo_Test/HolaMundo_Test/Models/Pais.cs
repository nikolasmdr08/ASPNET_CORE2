using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolaMundo_Test.Models
{
    public class Pais
    {
        public Pais() { }

        public Pais(string nombre)
        {
            Nombre = nombre;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}

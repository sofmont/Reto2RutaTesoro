using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto2RutaTesoro
{
    internal class Nodo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Pista { get; set; }
        public int NivelPeligro { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(int id, string nombre, string pista, int nivelPeligro)
        {
            Id = id;
            Nombre = nombre;
            Pista = pista;
            NivelPeligro = nivelPeligro;
            Siguiente = null;
        }
    }
}

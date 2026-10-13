using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueAtracciones.Entidades
{
    public class MontanaRusa : Atraccion
    {
        public int NumeroVagones { get; set; }

        public MontanaRusa(int id, string nombre,
            string calle, int capacidad,
            int numeroVagones)
            : base(id, nombre, calle, capacidad)
        {
            NumeroVagones = numeroVagones;
        }

        private System.Collections.Generic.Dictionary<int, bool>
            anclajes = new System.Collections.Generic.Dictionary<int, bool>();

        public void RegistrarAnclaje(int numeroVagon, bool seguro)
        {
            if (numeroVagon < 1 || numeroVagon > NumeroVagones)
            {
                throw new ArgumentException(
                    "El número de vagón no es válido.");
            }

            anclajes[numeroVagon] = seguro;
        }

        public bool VerificarAnclaje(int numeroVagon)
        {
            if (numeroVagon < 1 || numeroVagon > NumeroVagones)
            {
                throw new ArgumentException(
                    "El número de vagón no es válido.");
            }

            return anclajes.ContainsKey(numeroVagon)
                && anclajes[numeroVagon];
        }

    }
}

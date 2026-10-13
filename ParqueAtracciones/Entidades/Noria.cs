using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueAtracciones.Entidades
{
    public class Noria : Atraccion
    {
        public int NumeroVehiculos { get; set; }

        public Noria(int id, string nombre,
            string calle, int capacidad,
            int numeroVehiculos)
            : base(id, nombre, calle, capacidad)
        {
            NumeroVehiculos = numeroVehiculos;
        }

        private System.Collections.Generic.Dictionary<int, bool>
            anclajes = new System.Collections.Generic.Dictionary<int, bool>();

        public void RegistrarAnclaje(int numeroVehiculo, bool seguro)
        {
            if (numeroVehiculo < 1 ||
                numeroVehiculo > NumeroVehiculos)
            {
                throw new ArgumentException(
                    "El número de vehículo no es válido.");
            }

            anclajes[numeroVehiculo] = seguro;
        }

        public bool VerificarAnclaje(int numeroVehiculo)
        {
            if (numeroVehiculo < 1 ||
                numeroVehiculo > NumeroVehiculos)
            {
                throw new ArgumentException(
                    "El número de vehículo no es válido.");
            }

            return anclajes.ContainsKey(numeroVehiculo)
                && anclajes[numeroVehiculo];
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueAtracciones.Entidades
{
    public class Operario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public bool Disponible { get; set; }
        public int AveriasAtendidas { get; set; }

        public Operario(int id, string nombre, string cedula)
        {
            Id = id;
            Nombre = nombre;
            Cedula = cedula;
            Disponible = true;
            AveriasAtendidas = 0;
        }

        public void AsignarTrabajo()
        {
            Disponible = false;
        }

        public void FinalizarTrabajo()
        {
            Disponible = true;
            AveriasAtendidas++;
        }

        public string Estado()
        {
            return Disponible ? "DISPONIBLE" : "OCUPADO";
        }
    }
}

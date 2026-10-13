using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueAtracciones.Entidades
{
    public class Averia
    {
        public int Id { get; set; }
        public int IdAtraccion { get; set; }
        public int NumeroComponente { get; set; }
        public string TipoComponente { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public Operario OperarioAsignado { get; set; }

        public Averia(int id, int idAtraccion,
            int numeroComponente, string tipoComponente,
            string descripcion)
        {
            Id = id;
            IdAtraccion = idAtraccion;
            NumeroComponente = numeroComponente;
            TipoComponente = tipoComponente;
            Descripcion = descripcion;
            Fecha = DateTime.Now;
            Estado = "PENDIENTE";
            OperarioAsignado = null;
        }

        public void AsignarOperario(Operario operario)
        {
            if (Estado != "PENDIENTE" ||
                operario == null ||
                !operario.Disponible)
                return;

            OperarioAsignado = operario;
            operario.AsignarTrabajo();
            Estado = "EN REPARACION";
        }

        public void FinalizarReparacion()
        {
            if (Estado != "EN REPARACION" ||
                OperarioAsignado == null)
                return;

            OperarioAsignado.FinalizarTrabajo();
            Estado = "REPARADA";
        }
    }
}

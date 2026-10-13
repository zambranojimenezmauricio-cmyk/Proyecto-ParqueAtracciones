using ParqueAtracciones.Controladores;
using System.Collections.Generic;

namespace ParqueAtracciones.Entidades
{
    public class CentralReceptora
    {
        public List<Operario> Operarios
        {
            get { return TListaOperarios.listaOperarios; }
        }

        public List<Averia> Averias { get; private set; }

        public CentralReceptora()
        {
            Averias = new List<Averia>();
        }

        public void RegistrarAveria(Averia averia)
        {
            Averias.Add(averia);
            AsignarOperario(averia);
        }

        public bool AsignarOperario(Averia averia)
        {
            if (averia.Estado != "PENDIENTE")
                return false;

            foreach (Operario operario in Operarios)
            {
                if (operario.Disponible)
                {
                    averia.AsignarOperario(operario);
                    return true;
                }
            }

            return false;
        }

        public void AtenderPendientes()
        {
            foreach (Averia averia in Averias)
            {
                if (averia.Estado == "PENDIENTE")
                    AsignarOperario(averia);
            }
        }
    }
}

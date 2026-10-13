using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueAtracciones.Entidades
{
    public class Vagon
    {
        public int Numero { get; set; }
        public Detector DetectorAnclaje { get; private set; }
        public bool TieneVagonPosterior { get; set; }
        public bool RevisionPendiente { get; private set; }

        public Vagon(int numero, bool tieneVagonPosterior)
        {
            Numero = numero;
            TieneVagonPosterior = tieneVagonPosterior;

            if (TieneVagonPosterior)
                DetectorAnclaje = new Detector(numero);
        }

        public bool DetectarAveria()
        {
            if (!TieneVagonPosterior ||
                RevisionPendiente)
                return false;

            DetectorAnclaje.DetectarFallo();
            RevisionPendiente = true;
            return true;
        }

        public void FinalizarRevision()
        {
            if (DetectorAnclaje != null)
                DetectorAnclaje.Restablecer();

            RevisionPendiente = false;
        }
    }
}

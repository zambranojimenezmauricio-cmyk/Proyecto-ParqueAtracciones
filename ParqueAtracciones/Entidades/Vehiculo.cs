using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueAtracciones.Entidades
{
    public class Vehiculo
    {
        public int Numero { get; set; }
        public Detector DetectorAnclaje { get; private set; }
        public bool RevisionPendiente { get; private set; }

        public Vehiculo(int numero)
        {
            Numero = numero;
            DetectorAnclaje = new Detector(numero);
            RevisionPendiente = false;
        }

        public bool DetectarAveria()
        {
            if (RevisionPendiente)
                return false;

            DetectorAnclaje.DetectarFallo();
            RevisionPendiente = true;
            return true;
        }

        public void FinalizarRevision()
        {
            DetectorAnclaje.Restablecer();
            RevisionPendiente = false;
        }
    }
}

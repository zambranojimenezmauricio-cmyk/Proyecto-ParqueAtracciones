using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueAtracciones.Entidades
{
    public class Detector
    {
        public int Id { get; set; }
        public bool AnclajeSeguro { get; private set; }

        public Detector(int id)
        {
            Id = id;
            AnclajeSeguro = true;
        }

        public void DetectarFallo()
        {
            AnclajeSeguro = false;
        }

        public void Restablecer()
        {
            AnclajeSeguro = true;
        }

        public string Estado()
        {
            return AnclajeSeguro
                ? "ANCLAJE SEGURO"
                : "FALLO DE ANCLAJE";
        }
    }
}

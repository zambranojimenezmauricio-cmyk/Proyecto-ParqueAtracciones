using ParqueAtracciones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueAtracciones.Controladores
{
    public static class TListaAverias
    {
        public static CentralReceptora CRA =
            new CentralReceptora();

        public static int Buscar(int id)
        {
            for (int i = 0; i < CRA.Averias.Count; i++)
            {
                if (CRA.Averias[i].Id == id)
                    return i;
            }

            return -1;
        }

        public static Averia Obtener(int pos)
        {
            return CRA.Averias[pos];
        }
    }
}


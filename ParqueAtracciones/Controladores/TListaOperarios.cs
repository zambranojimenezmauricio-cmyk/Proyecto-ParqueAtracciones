using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParqueAtracciones.Entidades;

namespace ParqueAtracciones.Controladores
{
    public static class TListaOperarios
    {
        public static List<Operario> listaOperarios =
            new List<Operario>();

        public static void Agregar(Operario operario)
        {
            listaOperarios.Add(operario);
        }

        public static int Buscar(int id)
        {
            for (int i = 0; i < listaOperarios.Count; i++)
            {
                if (listaOperarios[i].Id == id)
                    return i;
            }

            return -1;
        }

        public static Operario Obtener(int pos)
        {
            return listaOperarios[pos];
        }

        public static void Modificar(int pos, Operario operario)
        {
            listaOperarios[pos] = operario;
        }

        public static void Eliminar(int pos)
        {
            listaOperarios.RemoveAt(pos);
        }
    }
}

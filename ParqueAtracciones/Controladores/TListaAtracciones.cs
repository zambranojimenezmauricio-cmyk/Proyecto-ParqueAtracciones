using ParqueAtracciones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueAtracciones.Controladores
{
    public static class TListaAtracciones
    {
        public static List<Atraccion> listaAtracciones =
           new List<Atraccion>();

        public static void Agregar(Atraccion atraccion)
        {
            listaAtracciones.Add(atraccion);
        }

        public static int Buscar(int id)
        {
            for (int i = 0; i < listaAtracciones.Count; i++)
            {
                if (listaAtracciones[i].ID == id)
                    return i;
            }

            return -1;
        }

        public static void Modificar(int pos, Atraccion atraccion)
        {
            listaAtracciones[pos] = atraccion;
        }

        public static void Eliminar(int pos)
        {
            listaAtracciones.RemoveAt(pos);
        }

        public static Atraccion Obtener(int pos)
        {
            return listaAtracciones[pos];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueAtracciones.Entidades
{
    public class Atraccion
    {
        private int Id;
        private string Nombre;
        private string Calle;
        private int Capacidad;
        private int PersonasActuales;
        private int AveriasPendientes;

        public  int ID { get => Id; set => Id = value; }
        public string nombre { get => Nombre; set => Nombre = value; }
        public string calle { get => Calle; set => Calle = value; }
        public int capacidad { get => Capacidad; set => Capacidad = value; }
        public int personasActuales { get => PersonasActuales; set => PersonasActuales = value; }
        public int averiasPendientes { get => AveriasPendientes; set => AveriasPendientes = value; }

        public Atraccion(int id, string nombre,
            string calle, int capacidad)
        {
            ID = id;
            this.nombre = nombre;
            this.calle = calle;
            this.capacidad = capacidad;
            personasActuales = 0;
            averiasPendientes = 0;
        }

        public bool PuedeIngresar()
        {
            return averiasPendientes == 0 &&
                   personasActuales < capacidad;
        }

        public bool RegistrarEntrada()
        {
            if (!PuedeIngresar())
                return false;

            personasActuales++;
            return true;
        }

        public bool RegistrarSalida()
        {
            if (personasActuales <= 0)
                return false;

            personasActuales--;
            return true;
        }

        public void RegistrarAveria()
        {
            averiasPendientes++;
        }

        public void RepararAveria()
        {
            if (averiasPendientes > 0)
                averiasPendientes--;
        }

        public string Estado()
        {
            if (averiasPendientes > 0)
                return "EN MANTENIMIENTO";

            if (personasActuales >= capacidad)
                return "LLENA";

            return "DISPONIBLE";
        }
    
}
}

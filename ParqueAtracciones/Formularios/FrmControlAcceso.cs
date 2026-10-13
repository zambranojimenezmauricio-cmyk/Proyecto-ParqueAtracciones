using ParqueAtracciones.Controladores;
using ParqueAtracciones.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParqueAtracciones.Formularios
{
    public partial class FrmControlAcceso : Form

    {
        public FrmControlAcceso()
        {
            InitializeComponent();
            cboAtraccion.DropDownStyle =
        ComboBoxStyle.DropDownList;

            txtCapacidad.ReadOnly = true;
            txtOcupacion.ReadOnly = true;
            txtEstado.ReadOnly = true;

            dgvControlAcceso.ReadOnly = true;
            dgvControlAcceso.AllowUserToAddRows = false;
            dgvControlAcceso.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            timerSeguridad.Start();
            CargarAtracciones();
            MostrarControl();
        }

        private void CargarAtracciones()
        {
            cboAtraccion.DataSource = null;

            cboAtraccion.DisplayMember = "Nombre";
            cboAtraccion.ValueMember = "Id";

            cboAtraccion.DataSource =
                TListaAtracciones.listaAtracciones.ToList();

            cboAtraccion.SelectedIndex = -1;
        }
        private static System.Collections.Generic.Dictionary<int, int>
           ocupaciones = new System.Collections.Generic.Dictionary<int, int>();

        private static System.Collections.Generic.Dictionary<int, DateTime>
            horasIngreso = new System.Collections.Generic.Dictionary<int, DateTime>();

        public static int ObtenerOcupacion(int idAtraccion)
        {
            if (ocupaciones.ContainsKey(idAtraccion))
            {
                return ocupaciones[idAtraccion];
            }

            return 0;
        }

        private bool TieneAverias(int idAtraccion)
        {
            return TListaAverias.CRA.Averias.Any(a =>
                a.IdAtraccion == idAtraccion &&
                a.Estado != "REPARADA");
        }


        private void MostrarControl()
        {
            var datos = TListaAtracciones.listaAtracciones
                .Select(a => new
                {
                    a.ID,
                    a.nombre,
                    a.capacidad,
                    Ocupacion = ocupaciones.ContainsKey(a.ID)
                        ? ocupaciones[a.ID] : 0,
                    Estado = TieneAverias(a.ID)
                        ? "BLOQUEADA" : "DISPONIBLE"
                })
                .ToList();

            dgvControlAcceso.DataSource = null;
            dgvControlAcceso.DataSource = datos;
        }


        private void FrmControlAcceso_Load(object sender, EventArgs e)
        {

        }

        private void cboAtraccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Atraccion a = cboAtraccion.SelectedItem as Atraccion;

            if (a == null)
            {
                txtCapacidad.Clear();
                txtOcupacion.Clear();
                txtEstado.Clear();
                return;
            }

            txtCapacidad.Text = a.capacidad.ToString();

            int ocupacion = ocupaciones.ContainsKey(a.ID)
                ? ocupaciones[a.ID] : 0;

            txtOcupacion.Text = ocupacion.ToString();

            txtEstado.Text = TieneAverias(a.ID)
                ? "BLOQUEADA" : "DISPONIBLE";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Atraccion a = cboAtraccion.SelectedItem as Atraccion;

            if (a == null)
            {
                MessageBox.Show("Seleccione una atracción.");
                return;
            }

            int cantidad;

            if (!int.TryParse(txtCantidad.Text, out cantidad)
                || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            if (TieneAverias(a.ID))
            {
                MessageBox.Show(
                    "No se permite el ingreso. Atracción con averías.");
                return;
            }

            int actuales = ocupaciones.ContainsKey(a.ID)
                ? ocupaciones[a.ID] : 0;

            if (cantidad > a.capacidad - actuales)
            {
                MessageBox.Show(
                    "No hay capacidad suficiente.");
                return;
            }

            ocupaciones[a.ID] = actuales + cantidad;

            if (actuales == 0)
            {
                horasIngreso[a.ID] = DateTime.Now;
            }



            MessageBox.Show("Ingreso registrado correctamente.");

            txtCantidad.Clear();
            ActualizarPantalla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Atraccion a = cboAtraccion.SelectedItem as Atraccion;

            if (a == null)
            {
                MessageBox.Show("Seleccione una atracción.");
                return;
            }

            int cantidad;

            if (!int.TryParse(txtCantidad.Text, out cantidad)
                || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            int actuales = ocupaciones.ContainsKey(a.ID)
                ? ocupaciones[a.ID] : 0;

            if (cantidad > actuales)
            {
                MessageBox.Show(
                    "No pueden salir más pasajeros de los registrados.");
                return;
            }

            ocupaciones[a.ID] = actuales - cantidad;

            if (ocupaciones[a.ID] == 0)
            {
                horasIngreso.Remove(a.ID);
            }


            MessageBox.Show("Salida registrada correctamente.");

            txtCantidad.Clear();
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            cboAtraccion_SelectedIndexChanged(this, EventArgs.Empty);
            MostrarControl();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int? idSeleccionado =
        cboAtraccion.SelectedItem is Atraccion a
        ? (int?)a.ID : null;

            CargarAtracciones();

            if (idSeleccionado.HasValue)
                cboAtraccion.SelectedValue = idSeleccionado.Value;

            ActualizarPantalla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            cboAtraccion.SelectedIndex = -1;

            txtCapacidad.Clear();
            txtOcupacion.Clear();
            txtEstado.Clear();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            cboAtraccion.SelectedIndex = -1;

            txtCapacidad.Clear();
            txtOcupacion.Clear();
            txtEstado.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerSeguridad_Tick(object sender, EventArgs e)
        {
            foreach (var registro in horasIngreso.ToList())
            {
                int idAtraccion = registro.Key;
                DateTime horaIngreso = registro.Value;

                double minutos =
                    (DateTime.Now - horaIngreso).TotalMinutes;

                int pasajeros = ObtenerOcupacion(idAtraccion);

                if (pasajeros > 0 && minutos >= 0.2)
                {
                    horasIngreso.Remove(idAtraccion);

                    MessageBox.Show(
                        "ALERTA DE SEGURIDAD\n\n" +
                        "La atracción con ID " + idAtraccion +
                        " lleva más de 5 minutos con pasajeros.",
                        "ADVERTENCIA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }
    }
}

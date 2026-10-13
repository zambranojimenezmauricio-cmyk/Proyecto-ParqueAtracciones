using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParqueAtracciones.Entidades;
using ParqueAtracciones.Controladores;

namespace ParqueAtracciones.Formularios
{
    public partial class FrmAtracciones : Form
    {
        public FrmAtracciones()
        {
            InitializeComponent();
            cboTipo.Items.Add("Noria");
            cboTipo.Items.Add("Montaña Rusa");
            cboTipo.SelectedIndex = 0;

            dgvAtracciones.ReadOnly = true;
            dgvAtracciones.AllowUserToAddRows = false;
            dgvAtracciones.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            MostrarAtracciones();
        }
        private void MostrarAtracciones()
        {
            var datos = TListaAtracciones.listaAtracciones
                .Select(a => new
                {
                    a.ID,
                    a.nombre,
                    Tipo = a is Noria ? "Noria" : "Montaña Rusa",
                    a.calle,
                    a.capacidad,
                    Cantidad = a is Noria
                        ? ((Noria)a).NumeroVehiculos
                        : ((MontanaRusa)a).NumeroVagones,
                    Estado = a.Estado()
                })
                .ToList();

            dgvAtracciones.DataSource = null;
            dgvAtracciones.DataSource = datos;
        }
        private void Limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtCalle.Clear();
            txtCapacidad.Clear();
            txtCantidad.Clear();

            cboTipo.SelectedIndex = 0;
            txtId.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int id, capacidad, cantidad;

            if (!int.TryParse(txtId.Text, out id) ||
                !int.TryParse(txtCapacidad.Text, out capacidad) ||
                !int.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("Ingrese valores numéricos válidos.");
                return;
            }

            if (id <= 0 || capacidad <= 0 || cantidad <= 0 ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCalle.Text))
            {
                MessageBox.Show("Complete los datos correctamente.");
                return;
            }

            if (TListaAtracciones.Buscar(id) != -1)
            {
                MessageBox.Show("Ya existe una atracción con ese ID.");
                return;
            }

            Atraccion atraccion;

            if (cboTipo.Text == "Noria")
            {
                atraccion = new Noria(
                    id, txtNombre.Text, txtCalle.Text,
                    capacidad, cantidad);
            }
            else
            {
                atraccion = new MontanaRusa(
                    id, txtNombre.Text, txtCalle.Text,
                    capacidad, cantidad);
            }

            TListaAtracciones.Agregar(atraccion);

            MessageBox.Show("Atracción registrada correctamente.");
            MostrarAtracciones();
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("Ingrese un ID válido.");
                return;
            }

            int pos = TListaAtracciones.Buscar(id);

            if (pos == -1)
            {
                MessageBox.Show("Atracción no encontrada.");
                return;
            }

            Atraccion a = TListaAtracciones.Obtener(pos);

            txtNombre.Text = a.nombre;
            txtCalle.Text = a.calle;
            txtCapacidad.Text = a.capacidad.ToString();

            if (a is Noria)
            {
                cboTipo.Text = "Noria";
                txtCantidad.Text =
                    ((Noria)a).NumeroVehiculos.ToString();
            }
            else if (a is MontanaRusa)
            {
                cboTipo.Text = "Montaña Rusa";
                txtCantidad.Text =
                    ((MontanaRusa)a).NumeroVagones.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id, capacidad, cantidad;

            if (!int.TryParse(txtId.Text, out id) ||
                !int.TryParse(txtCapacidad.Text, out capacidad) ||
                !int.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("Ingrese datos numéricos válidos.");
                return;
            }

            int pos = TListaAtracciones.Buscar(id);

            if (pos == -1)
            {
                MessageBox.Show("Atracción no encontrada.");
                return;
            }

            Atraccion actual = TListaAtracciones.Obtener(pos);

            if (actual.personasActuales > 0 ||
                actual.averiasPendientes > 0)
            {
                MessageBox.Show(
                    "No se puede modificar una atracción con " +
                    "pasajeros o averías pendientes.");
                return;
            }

            if (capacidad <= 0 || cantidad <= 0 ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCalle.Text))
            {
                MessageBox.Show("Complete correctamente los datos.");
                return;
            }

            Atraccion nueva;

            if (cboTipo.Text == "Noria")
            {
                nueva = new Noria(id, txtNombre.Text,
                    txtCalle.Text, capacidad, cantidad);
            }
            else
            {
                nueva = new MontanaRusa(id, txtNombre.Text,
                    txtCalle.Text, capacidad, cantidad);
            }

            TListaAtracciones.Modificar(pos, nueva);

            MessageBox.Show("Atracción modificada correctamente.");
            MostrarAtracciones();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("Ingrese un ID válido.");
                return;
            }

            int pos = TListaAtracciones.Buscar(id);

            if (pos == -1)
            {
                MessageBox.Show("Atracción no encontrada.");
                return;
            }

            Atraccion a = TListaAtracciones.Obtener(pos);

            if (a.personasActuales > 0 ||
                a.averiasPendientes > 0)
            {
                MessageBox.Show(
                    "No se puede eliminar una atracción con " +
                    "pasajeros o averías pendientes.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea eliminar esta atracción?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                TListaAtracciones.Eliminar(pos);
                MostrarAtracciones();
                Limpiar();

                MessageBox.Show("Atracción eliminada.");
            }
        }

        private void dgvAtracciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
{
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow fila =
                    dgvAtracciones.Rows[e.RowIndex];

                txtId.Text = fila.Cells["Id"].Value.ToString();

                int id = int.Parse(txtId.Text);
                int pos = TListaAtracciones.Buscar(id);

                if (pos == -1)
                    return;

                Atraccion a = TListaAtracciones.Obtener(pos);

                txtNombre.Text = a.nombre;
                txtCalle.Text = a.calle;
                txtCapacidad.Text = a.capacidad.ToString();

                if (a is Noria)
                {
                    cboTipo.Text = "Noria";
                    txtCantidad.Text =
                        ((Noria)a).NumeroVehiculos.ToString();
                }
                else if (a is MontanaRusa)
                {
                    cboTipo.Text = "Montaña Rusa";
                    txtCantidad.Text =
                        ((MontanaRusa)a).NumeroVagones.ToString();
                }
            }
        }
    }
}
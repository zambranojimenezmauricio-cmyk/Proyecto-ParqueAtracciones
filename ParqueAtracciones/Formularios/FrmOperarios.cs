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
    public partial class FrmOperarios : Form
    {
        public FrmOperarios()
        {
            InitializeComponent();
            txtEstado.ReadOnly = true;
            txtEstado.Text = "DISPONIBLE";

            dgvOperarios.ReadOnly = true;
            dgvOperarios.AllowUserToAddRows = false;
            dgvOperarios.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            MostrarOperarios();
        }

        private void MostrarOperarios()
        {
            var datos = TListaOperarios.listaOperarios
                .Select(o => new
                {
                    o.Id,
                    o.Nombre,
                    o.Cedula,
                    Estado = o.Estado(),
                    o.AveriasAtendidas
                })
                .ToList();

            dgvOperarios.DataSource = null;
            dgvOperarios.DataSource = datos;
        }

        private void Limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtCedula.Clear();
            txtEstado.Text = "DISPONIBLE";
            txtId.Focus();
        }


        private void FrmOperarios_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtId.Text, out id) || id <= 0)
            {
                MessageBox.Show("Ingrese un ID válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (TListaOperarios.Buscar(id) != -1)
            {
                MessageBox.Show("Ya existe un operario con ese ID.");
                return;
            }

            Operario operario = new Operario(
                id,
                txtNombre.Text.Trim(),
                txtCedula.Text.Trim()
            );

            TListaOperarios.Agregar(operario);

            MessageBox.Show("Operario registrado correctamente.");
            MostrarOperarios();
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

            int pos = TListaOperarios.Buscar(id);

            if (pos == -1)
            {
                MessageBox.Show("Operario no encontrado.");
                return;
            }

            Operario o = TListaOperarios.Obtener(pos);

            txtNombre.Text = o.Nombre;
            txtCedula.Text = o.Cedula;
            txtEstado.Text = o.Estado();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("Ingrese un ID válido.");
                return;
            }

            int pos = TListaOperarios.Buscar(id);

            if (pos == -1)
            {
                MessageBox.Show("Operario no encontrado.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            Operario o = TListaOperarios.Obtener(pos);

            o.Nombre = txtNombre.Text.Trim();
            o.Cedula = txtCedula.Text.Trim();

            MessageBox.Show("Operario modificado correctamente.");
            MostrarOperarios();
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

            int pos = TListaOperarios.Buscar(id);

            if (pos == -1)
            {
                MessageBox.Show("Operario no encontrado.");
                return;
            }

            Operario o = TListaOperarios.Obtener(pos);

            if (!o.Disponible)
            {
                MessageBox.Show(
                    "No se puede eliminar un operario ocupado.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea eliminar este operario?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                TListaOperarios.Eliminar(pos);
                MostrarOperarios();
                Limpiar();

                MessageBox.Show("Operario eliminado correctamente.");
            }
        }

        private void dgvOperarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvOperarios.Rows[e.RowIndex];

            int id = Convert.ToInt32(
                fila.Cells["Id"].Value);

            int pos = TListaOperarios.Buscar(id);

            if (pos == -1)
                return;

            Operario o = TListaOperarios.Obtener(pos);

            txtId.Text = o.Id.ToString();
            txtNombre.Text = o.Nombre;
            txtCedula.Text = o.Cedula;
            txtEstado.Text = o.Estado();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}

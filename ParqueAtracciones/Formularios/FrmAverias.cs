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
    public partial class FrmAverias : Form
    {
        public FrmAverias()
        {
            InitializeComponent();
            cboAtraccion.DropDownStyle =
        ComboBoxStyle.DropDownList;

            cboComponente.DropDownStyle =
                ComboBoxStyle.DropDownList;

            dgvAverias.ReadOnly = true;
            dgvAverias.AllowUserToAddRows = false;
            dgvAverias.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            CargarAtracciones();

            MessageBox.Show(
                "Atracciones registradas: " +
                TListaAtracciones.listaAtracciones.Count
            );

            MostrarAverias();
        }


        private void CargarAtracciones()
        {
            cboAtraccion.DataSource = null;
            cboAtraccion.Items.Clear();

            var lista = TListaAtracciones.listaAtracciones.ToList();

            MessageBox.Show(
                "Atracciones encontradas: " + lista.Count
            );

            cboAtraccion.DisplayMember = "Nombre";
            cboAtraccion.ValueMember = "Id";
            cboAtraccion.DataSource = lista;

            cboAtraccion.SelectedIndex = -1;
        }


        private void MostrarAverias()
        {
            var datos = TListaAverias.CRA.Averias
                .Select(a => new
                {
                    a.Id,
                    a.IdAtraccion,
                    a.TipoComponente,
                    a.NumeroComponente,
                    a.Descripcion,
                    a.Fecha,
                    a.Estado,
                    Operario = a.OperarioAsignado == null
                        ? "SIN ASIGNAR"
                        : a.OperarioAsignado.Nombre
                })
                .ToList();

            dgvAverias.DataSource = null;
            dgvAverias.DataSource = datos;
        }

        private void cboAtraccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboComponente.Items.Clear();

            Atraccion a = cboAtraccion.SelectedItem
                as Atraccion;

            if (a is Noria)
                cboComponente.Items.Add("Vehículo");
            else if (a is MontanaRusa)
                cboComponente.Items.Add("Vagón");

            if (cboComponente.Items.Count > 0)
                cboComponente.SelectedIndex = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int id, numero;

            if (!int.TryParse(txtIdAveria.Text, out id) ||
                !int.TryParse(txtNumero.Text, out numero) ||
                id <= 0 || numero <= 0)
            {
                MessageBox.Show("Ingrese números válidos.");
                return;
            }

            Atraccion atraccion =
                cboAtraccion.SelectedItem as Atraccion;

            if (atraccion == null ||
                cboComponente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una atracción.");
                return;
            }

            int cantidad = atraccion is Noria
                ? ((Noria)atraccion).NumeroVehiculos
                : ((MontanaRusa)atraccion).NumeroVagones;

            if (numero > cantidad)
            {
                MessageBox.Show(
                    "El componente no existe en esta atracción.");
                return;
            }

            if (atraccion is MontanaRusa && numero == cantidad)
            {
                MessageBox.Show(
                    "El último vagón no tiene anclaje posterior.");
                return;
            }

            if (TListaAverias.Buscar(id) != -1)
            {
                MessageBox.Show("El ID de avería ya existe.");
                return;
            }

            bool duplicada = TListaAverias.CRA.Averias.Any(a =>
                a.IdAtraccion == atraccion.ID &&
                a.NumeroComponente == numero &&
                a.Estado != "REPARADA");

            if (duplicada)
            {
                MessageBox.Show(
                    "Este componente ya tiene una avería activa.");
                return;
            }

            Averia averia = new Averia(
                id,
                atraccion.ID,
                numero,
                cboComponente.Text,
                txtDescripcion.Text.Trim()
            );

            atraccion.RegistrarAveria();
            TListaAverias.CRA.RegistrarAveria(averia);

            MessageBox.Show(
                "Avería registrada. Estado: " + averia.Estado);

            MostrarAverias();
            Limpiar();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtIdAveria.Text, out id))
            {
                MessageBox.Show("Ingrese el ID de la avería.");
                return;
            }

            int pos = TListaAverias.Buscar(id);

            if (pos == -1)
            {
                MessageBox.Show("Avería no encontrada.");
                return;
            }

            Averia averia = TListaAverias.Obtener(pos);

            if (averia.Estado != "EN REPARACION")
            {
                MessageBox.Show(
                    "La avería no está en reparación.");
                return;
            }

            averia.FinalizarReparacion();

            int posAtraccion =
                TListaAtracciones.Buscar(averia.IdAtraccion);

            if (posAtraccion != -1)
            {
                Atraccion atraccion =
                    TListaAtracciones.Obtener(posAtraccion);

                atraccion.RepararAveria();
            }

            TListaAverias.CRA.AtenderPendientes();

            MostrarAverias();

            MessageBox.Show("Reparación finalizada correctamente.");
        }

        private void Limpiar()
        {
            txtIdAveria.Clear();
            txtNumero.Clear();
            txtDescripcion.Clear();

            cboAtraccion.SelectedIndex = -1;
            cboComponente.Items.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarAtracciones();

            TListaAverias.CRA.AtenderPendientes();

            MostrarAverias();

            MessageBox.Show("Averías actualizadas correctamente.");
        }
        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAverias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(
                dgvAverias.Rows[e.RowIndex].Cells["Id"].Value);

            txtIdAveria.Text = id.ToString();

            int pos = TListaAverias.Buscar(id);

            if (pos == -1)
                return;

            Averia a = TListaAverias.Obtener(pos);

            txtNumero.Text = a.NumeroComponente.ToString();
            txtDescripcion.Text = a.Descripcion;

            cboAtraccion.SelectedValue = a.IdAtraccion;
            cboComponente.Text = a.TipoComponente;
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnVerificarAnclaje_Click(object sender, EventArgs e)
        {
            Atraccion a = cboAtraccion.SelectedItem as Atraccion;

            if (a == null)
            {
                MessageBox.Show("Seleccione una atracción.");
                return;
            }

            if (cboAnclaje.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el estado del anclaje.");
                return;
            }

            if (!int.TryParse(txtNumero.Text, out int numero))
            {
                MessageBox.Show("Ingrese un número válido.");
                return;
            }

            bool seguro = cboAnclaje.Text == "SEGURO";

            try
            {
                if (a is Noria)
                {
                    Noria noria = (Noria)a;
                    noria.RegistrarAnclaje(numero, seguro);
                }
                else if (a is MontanaRusa)
                {
                    MontanaRusa montana = (MontanaRusa)a;
                    montana.RegistrarAnclaje(numero, seguro);
                }

                if (seguro)
                {
                    MessageBox.Show(
                        "Anclaje verificado correctamente.",
                        "SEGURIDAD",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                else
                {
                    bool existeAveria = TListaAverias.CRA.Averias.Any(
                        av => av.IdAtraccion == a.ID &&
                              av.NumeroComponente == numero &&
                              av.Estado != "REPARADA" &&
                              av.Descripcion == "Fallo de anclaje");

                    if (existeAveria)
                    {
                        MessageBox.Show(
                            "Este componente ya tiene una avería de anclaje activa.",
                            "AVISO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return;
                    }

                    int nuevoId = TListaAverias.CRA.Averias.Count == 0
                        ? 1
                        : TListaAverias.CRA.Averias.Max(av => av.Id) + 1;

                    string tipoComponente = a is Noria
                        ? "Vehículo"
                        : "Vagón";

                    Averia nuevaAveria = new Averia(
                        nuevoId,
                        a.ID,
                        numero,
                        tipoComponente,
                        "Fallo de anclaje"
                    );

                    TListaAverias.CRA.RegistrarAveria(nuevaAveria);

                    MessageBox.Show(
                        "¡PELIGRO! ANCLAJE DEFECTUOSO.\n\n" +
                        "Atracción: " + a.nombre + "\n" +
                        "Componente: " + tipoComponente + " " + numero + "\n\n" +
                        "Se registró automáticamente una avería.\n" +
                        "La atracción queda BLOQUEADA para nuevos ingresos.",
                        "ALERTA DE SEGURIDAD",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    MostrarAverias();
                }

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

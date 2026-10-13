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
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
            cboReporte.DropDownStyle =
        ComboBoxStyle.DropDownList;

            cboReporte.Items.Add("Reporte general del parque");
            cboReporte.SelectedIndex = 0;

            txtReporte.ReadOnly = true;
            txtReporte.BackColor = Color.White;
        }

        private void GenerarReporte()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("========================================");
            sb.AppendLine("       DIVERTIMENTO S.A.");
            sb.AppendLine("      Informe general del parque");
            sb.AppendLine("========================================");
            sb.AppendLine("Generado el: " + DateTime.Now.ToString("f", new System.Globalization.CultureInfo("es-ES")));
            sb.AppendLine();

            // 1. Atracciones
            sb.AppendLine("1. Atracciones registradas");
            sb.AppendLine("----------------------------------------");
            int totalAtr = TListaAtracciones.listaAtracciones.Count;
            sb.AppendLine($"Total: {totalAtr} {(totalAtr == 1 ? "atracción" : "atracciones")}");

            foreach (Atraccion a in TListaAtracciones.listaAtracciones)
            {
                sb.AppendLine($"Atracción [{a.ID}] — {a.nombre}");
                sb.AppendLine($"Tipo: {(a is Noria ? "Noria" : "Montaña rusa")}");
                sb.AppendLine($"Ubicación (calle): {a.calle}");
                sb.AppendLine($"Capacidad: {a.capacidad} pasajeros");
                sb.AppendLine("----------------------------------------");
            }

            // 2. Operarios
            sb.AppendLine();
            sb.AppendLine("2. Operarios registrados");
            sb.AppendLine("----------------------------------------");
            int totalOp = TListaOperarios.listaOperarios.Count;
            sb.AppendLine($"Total: {totalOp} {(totalOp == 1 ? "operario" : "operarios")}");

            foreach (Operario o in TListaOperarios.listaOperarios)
            {
                sb.AppendLine($"Operario [{o.Id}] — {o.Nombre} (Cédula: {o.Cedula})");
                sb.AppendLine($"Estado: {o.Estado()}");
                sb.AppendLine($"Averías atendidas: {o.AveriasAtendidas}");
                sb.AppendLine("----------------------------------------");
            }

            // 3. Averías
            sb.AppendLine();
            sb.AppendLine("3. Averías registradas");
            sb.AppendLine("----------------------------------------");
            int totalAve = TListaAverias.CRA.Averias.Count;
            sb.AppendLine($"Total: {totalAve} {(totalAve == 1 ? "avería" : "averías")}");

            foreach (Averia a in TListaAverias.CRA.Averias)
            {
                sb.AppendLine($"Avería [{a.Id}] en atracción {a.IdAtraccion}");
                sb.AppendLine($"Componente: {a.TipoComponente} — Nº: {a.NumeroComponente}");
                sb.AppendLine($"Descripción: {a.Descripcion}");
                sb.AppendLine($"Fecha reportada: {a.Fecha}");
                sb.AppendLine($"Estado: {a.Estado}");
                sb.AppendLine("Operario asignado: " +
                    (a.OperarioAsignado == null ? "SIN ASIGNAR" : a.OperarioAsignado.Nombre));
                sb.AppendLine("----------------------------------------");
            }

            // 4. Estadísticas
            sb.AppendLine();
            sb.AppendLine("4. Estadísticas generales");
            sb.AppendLine("----------------------------------------");
            sb.AppendLine($"Atracciones: {totalAtr}");
            sb.AppendLine($"Operarios: {totalOp}");
            sb.AppendLine($"Averías totales: {totalAve}");
            sb.AppendLine($"Reparaciones finalizadas: {TListaAverias.CRA.Averias.Count(a => a.Estado == "REPARADA")}");
            sb.AppendLine($"Averías pendientes: {TListaAverias.CRA.Averias.Count(a => a.Estado == "PENDIENTE")}\n");

            // 5. Control de acceso
            sb.AppendLine("5. Control de acceso");
            sb.AppendLine("----------------------------------------");

            int totalPasajeros = 0;

            foreach (Atraccion a in TListaAtracciones.listaAtracciones)
            {
                int ocupacion = FrmControlAcceso.ObtenerOcupacion(a.ID);
                totalPasajeros += ocupacion;

                bool bloqueada = TListaAverias.CRA.Averias.Any(av => av.IdAtraccion == a.ID && av.Estado != "REPARADA");

                sb.AppendLine($"{a.nombre} (ID {a.ID})");
                sb.AppendLine($"Capacidad: {a.capacidad} — Pasajeros ahora: {ocupacion}");
                sb.AppendLine($"Estado: {(bloqueada ? "BLOQUEADA" : "DISPONIBLE")}");
                sb.AppendLine("----------------------------------------");
            }

            sb.AppendLine();
            sb.AppendLine($"Total de pasajeros en el parque: {totalPasajeros}");

            sb.AppendLine("========================================");
            sb.AppendLine("           Fin del informe");
            sb.AppendLine("========================================");

            txtReporte.Text = sb.ToString();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarReporte();
            MessageBox.Show("Reporte generado correctamente.");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReporte.Text))
            {
                MessageBox.Show("Primero debe generar un reporte.");
                return;
            }

            using (SaveFileDialog guardar = new SaveFileDialog())
            {
                guardar.Filter = "Archivo de texto (*.txt)|*.txt";
                guardar.FileName = "Reporte_Divertimento.txt";

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(
                        guardar.FileName,
                        txtReporte.Text,
                        Encoding.UTF8);

                    MessageBox.Show("Reporte exportado correctamente.");
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

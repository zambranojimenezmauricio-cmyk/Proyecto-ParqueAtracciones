using ParqueAtracciones.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ParqueAtracciones
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
       "¿Desea salir del sistema?",
       "Confirmar salida",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bntAtracciones_Click(object sender, EventArgs e)
        {
            using (FrmAtracciones frm = new FrmAtracciones())
            {
                frm.ShowDialog();
            }
        }

        private void btnOperarios_Click(object sender, EventArgs e)
        {
            using (FrmOperarios frm = new FrmOperarios())
            {
                frm.ShowDialog();
            }
        }

        private void btnAverias_Click(object sender, EventArgs e)
        {
            using (FrmAverias frm = new FrmAverias())
            {
                frm.ShowDialog();
            }
        }

        private void btnControlAcceso_Click(object sender, EventArgs e)
        {
            using (FrmControlAcceso frm = new FrmControlAcceso())
            {
                frm.ShowDialog();
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            using (FrmReportes frm = new FrmReportes())
            {
                frm.ShowDialog();
            }
        }
    }
}
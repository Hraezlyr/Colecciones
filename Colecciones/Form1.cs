using Colecciones.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormInicio fm = new FormInicio();
            AbrirFormEnPanel(fm);

        }
        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.panelContenido.Controls.Count > 0)
                this.panelContenido.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(fh);
            this.panelContenido.Tag = fh;
            fh.Show();
        }



        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void BtnMaquinaria_Click(object sender, EventArgs e)
        {
            FormMaquinaria fm = new FormMaquinaria();
            AbrirFormEnPanel(fm);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FormInicio fm = new FormInicio();
            AbrirFormEnPanel(fm);
        }
    }
}

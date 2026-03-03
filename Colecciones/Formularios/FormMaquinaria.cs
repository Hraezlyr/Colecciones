using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecciones.Formularios
{
    public partial class FormMaquinaria : Form
    {
        public FormMaquinaria()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormRegistroMaquinaria frm = new FormRegistroMaquinaria();
            frm.ShowDialog();
        }
    }
}

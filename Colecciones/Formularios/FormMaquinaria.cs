using Colecciones.Clases;
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

        Maquinaria[] inventarioRecibido;
        int total;
        public FormMaquinaria(Maquinaria[] inventario, int contador)
        {
            InitializeComponent();
            inventarioRecibido = inventario;
            total = contador;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormRegistroMaquinaria frm = new FormRegistroMaquinaria();
            frm.ShowDialog();
        }
        
        private void FormMaquinaria_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < total; i++)
            {
                dgvMaquinaria.Rows.Add(
                    inventarioRecibido[i].CodigoInventario,
                    inventarioRecibido[i].Nombre,
                    inventarioRecibido[i].Modelo,
                    inventarioRecibido[i].Marca,
                    inventarioRecibido[i].AnioFabricacion,
                    inventarioRecibido[i].Estado
                );
            }
        }
    }
}

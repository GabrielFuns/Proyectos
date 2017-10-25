using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;

namespace Aplicacion
{
    public partial class frmNuevoC : Form
    {
        int tipo = 1;
        LogicaClass lc = new LogicaClass();
        public frmNuevoC()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            lc.Guardar(txtCliente.Text, txtTelefono.Text, "","","","","","", tipo);
        }
    }
}

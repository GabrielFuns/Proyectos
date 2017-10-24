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
    public partial class frmInicio : Form
    {
        LogicaClass lc = new LogicaClass();

        public frmInicio()
        {
            InitializeComponent();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregarC_Click(object sender, EventArgs e)
        {
            frmNuevoC f = new frmNuevoC();
            f.Show();

        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            frmInfo f = new frmInfo();
            f.Show();
        }
    }
}

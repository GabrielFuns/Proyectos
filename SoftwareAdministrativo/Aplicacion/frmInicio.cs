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
        int tipo = 1;
        string comand = "SP_Cargar";
        LogicaClass lc = new LogicaClass();

        public frmInicio()
        {
            InitializeComponent();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            frmNuevoC f = new frmNuevoC();
            f.Show();

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmInfo f = new frmInfo();
            f.Show();
        }
    }
}

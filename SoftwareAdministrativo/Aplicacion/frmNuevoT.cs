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
    public partial class frmNuevoT : Form
    {
        int tipo = 1;
        LogicaClass lc = new LogicaClass();
        public frmNuevoT()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string TipoTrabajo = "";
            if(RbArreglo.Checked == true)
            {
                TipoTrabajo = RbArreglo.Text;
            }
            else if (RbConfeccion.Checked == true)
            {
                TipoTrabajo = RbConfeccion.Text;
            }

            lc.Guardar("IDCliente", TipoTrabajo, TxtPedido.Text, TxtDetalle.Text, DtpRecibido.Text, DtpEntregar.Text, TxtEntrega.Text, TxtPrecio.Text, tipo);
        }
    }
}

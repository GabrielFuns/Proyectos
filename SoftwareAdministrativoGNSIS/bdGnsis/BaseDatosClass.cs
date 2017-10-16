using System.Data.SqlClient;
using lgGnsis;
using System.Data;
using System;

namespace bdGnsis
{
    public class BaseDatosClass
    {
        EntidadesClass.TbClientes _EntiC = new EntidadesClass.TbClientes();
        EntidadesClass.TbTrabajos _EntiT = new EntidadesClass.TbTrabajos();
        SqlConnection conn = new SqlConnection("server=DIEGO-PC\\SQLEXPRESS ; database=base1 ; integrated security = true");
        SqlCommand command;

        public void Cargar(int tipo)
        {
            try
            {
                using (conn)
                {
                    command = new SqlCommand("SP_Cargar", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo;
                    SqlDataReader lector = command.ExecuteReader();

                    switch (tipo)
                    {
                        case 1:
                            while (lector.Read())
                            {

                                _EntiC.ID = Convert.ToInt32(lector["ID"]);
                                _EntiC.Cliente = Convert.ToString(lector["Cliente"]);
                                _EntiC.Telefono = Convert.ToDouble(lector["Telefono"]);

                            }
                            break;
                        case 2:
                            while (lector.Read())
                            {
                                _EntiT.ID = Convert.ToInt32(lector["ID"]);
                                _EntiT.IDCliente = Convert.ToInt32(lector["IDCliente"]);
                                _EntiT.TipoTrabajo = Convert.ToString(lector["TipoTrabajo"]);
                                _EntiT.Pedido = Convert.ToString(lector["Pedido"]);
                                _EntiT.Detalle = Convert.ToString(lector["Detalle"]);
                                _EntiT.FechaRecepcion = Convert.ToDateTime(lector["FechaRecepcion"]);
                                _EntiT.FechaEntrega = Convert.ToDateTime(lector["FechaEntrega"]);
                                _EntiT.Entrega = Convert.ToDecimal(lector["Entrega"]);
                                _EntiT.Precio = Convert.ToDecimal(lector["Precio"]);
                            }
                            break;
                    }
                } 
            }
            catch (System.IO.IOException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "ERROR BD007");
            }
        }
    }
}

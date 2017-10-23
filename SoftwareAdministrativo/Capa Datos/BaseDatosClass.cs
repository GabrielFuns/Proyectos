using System.Data.SqlClient;
using Capa_Entidades;
using System.Configuration;
using System.Data;
using System;


namespace Capa_Datos
{
    public class BaseDatosClass
    {
        EntidadesClass.TbClientes _EntiC = new EntidadesClass.TbClientes();
        EntidadesClass.TbTrabajos _EntiT = new EntidadesClass.TbTrabajos();
        //"server=DIEGO-PC\\SQLEXPRESS ; database=base1 ; integrated security = true"
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ToString());
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
                System.Windows.Forms.MessageBox.Show(e.Message, "ERROR BD001");
            }
        }

        public void Actualizar (int tipo)
        {
            try
            {
                using (conn)
                {
                    command = new SqlCommand("SP_Actualizar", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo;


                    switch (tipo)
                    {
                        case 1:
                            command.Parameters.AddWithValue("@Cliente", _EntiC.Cliente);
                            command.Parameters.AddWithValue("@Telefono", _EntiC.Telefono);
                            command.ExecuteNonQuery();
                            break;
                        case 2:
                            command.Parameters.AddWithValue("@IDCliente", _EntiT.IDCliente);
                            command.Parameters.AddWithValue("@TipoTrabajo", _EntiT.TipoTrabajo);
                            command.Parameters.AddWithValue("@Pedido", _EntiT.Pedido);
                            command.Parameters.AddWithValue("@Detalle", _EntiT.Detalle);
                            command.Parameters.AddWithValue("@FechaRecepcion", _EntiT.FechaRecepcion);
                            command.Parameters.AddWithValue("@FechaEntrega", _EntiT.FechaEntrega);
                            command.Parameters.AddWithValue("@Entrega", _EntiT.Entrega);
                            command.Parameters.AddWithValue("@Precio", _EntiT.Precio);
                            command.ExecuteNonQuery();
                            break;
                    }
                }
            }
            catch (System.IO.IOException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "ERROR BD002");
            }
        }

        public void Eliminar(int tipo)
        {
            try
            {
                using (conn)
                {
                    command = new SqlCommand("Sp_Eliminar", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@Tipo", SqlDbType.Int).Value = tipo;

                    switch (tipo)
                    {
                        case 1:
                            command.Parameters.AddWithValue("@ID", _EntiC.ID);
                            command.ExecuteNonQuery();                      
                            break;
                        case 2:
                            command.Parameters.AddWithValue("@ID", _EntiT.ID);
                            command.ExecuteNonQuery();
                            break;
                    }
                }
            }
            catch (System.IO.IOException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "ERROR BD003");
            }
        }

        public void Guardar(int tipo)
        {
            try
            {
                using (conn)
                {
                    command = new SqlCommand("SP_Guardar", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@Tipo", SqlDbType.Int).Value = tipo;

                    switch (tipo)
                    {
                        case 1:
                            command.Parameters.AddWithValue("@Cliente", _EntiC.Cliente);
                            command.Parameters.AddWithValue("@Telefono", _EntiC.Telefono);
                            command.ExecuteNonQuery();
                            break;
                        case 2:
                            command.Parameters.AddWithValue("@IDCliente", _EntiT.IDCliente);
                            command.Parameters.AddWithValue("@TipoTrabajo", _EntiT.TipoTrabajo);
                            command.Parameters.AddWithValue("@Pedido", _EntiT.Pedido);
                            command.Parameters.AddWithValue("@Detalle", _EntiT.Detalle);
                            command.Parameters.AddWithValue("@FechaRecepcion", _EntiT.FechaRecepcion);
                            command.Parameters.AddWithValue("@FechaEntrega", _EntiT.FechaEntrega);
                            command.Parameters.AddWithValue("@Entrega", _EntiT.Entrega);
                            command.Parameters.AddWithValue("@Precio", _EntiT.Precio);
                            command.ExecuteNonQuery();
                            break;
                    }
                }
            }
            catch (System.IO.IOException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "ERROR BD004");
            }
        }

        //Prueba todo en uno

        public void OperacionesBD (int tipo, string comand)
        {
            using (conn)
            {
                command = new SqlCommand(comand, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Tipo", SqlDbType.Int).Value = tipo;

                switch (comand)
                {
                    case "SP_Cargar":
                        switch (tipo)
                        {
                            case 1:
                                SqlDataReader lector = command.ExecuteReader();
                                while (lector.Read())
                                {
                                    _EntiC.ID = Convert.ToInt32(lector["ID"]);
                                    _EntiC.Cliente = Convert.ToString(lector["Cliente"]);
                                    _EntiC.Telefono = Convert.ToDouble(lector["Telefono"]);
                                }
                                break;
                            case 2:
                                SqlDataReader lector1 = command.ExecuteReader();
                                while (lector1.Read())
                                {
                                    _EntiT.ID = Convert.ToInt32(lector1["ID"]);
                                    _EntiT.IDCliente = Convert.ToInt32(lector1["IDCliente"]);
                                    _EntiT.TipoTrabajo = Convert.ToString(lector1["TipoTrabajo"]);
                                    _EntiT.Pedido = Convert.ToString(lector1["Pedido"]);
                                    _EntiT.Detalle = Convert.ToString(lector1["Detalle"]);
                                    _EntiT.FechaRecepcion = Convert.ToDateTime(lector1["FechaRecepcion"]);
                                    _EntiT.FechaEntrega = Convert.ToDateTime(lector1["FechaEntrega"]);
                                    _EntiT.Entrega = Convert.ToDecimal(lector1["Entrega"]);
                                    _EntiT.Precio = Convert.ToDecimal(lector1["Precio"]);
                                }
                                break;
                        }
                        break;
                    case "SP_Guardar":
                        switch (tipo)
                        {
                            case 1:
                                command.Parameters.AddWithValue("@Cliente", _EntiC.Cliente);
                                command.Parameters.AddWithValue("@Telefono", _EntiC.Telefono);
                                command.ExecuteNonQuery();
                                break;
                            case 2:
                                command.Parameters.AddWithValue("@IDCliente", _EntiT.IDCliente);
                                command.Parameters.AddWithValue("@TipoTrabajo", _EntiT.TipoTrabajo);
                                command.Parameters.AddWithValue("@Pedido", _EntiT.Pedido);
                                command.Parameters.AddWithValue("@Detalle", _EntiT.Detalle);
                                command.Parameters.AddWithValue("@FechaRecepcion", _EntiT.FechaRecepcion);
                                command.Parameters.AddWithValue("@FechaEntrega", _EntiT.FechaEntrega);
                                command.Parameters.AddWithValue("@Entrega", _EntiT.Entrega);
                                command.Parameters.AddWithValue("@Precio", _EntiT.Precio);
                                command.ExecuteNonQuery();
                                break;
                        }
                        break;
                    case "SP_Actualizar":
                        switch (tipo)
                        {
                            case 1:
                                command.Parameters.AddWithValue("@Cliente", _EntiC.Cliente);
                                command.Parameters.AddWithValue("@Telefono", _EntiC.Telefono);
                                command.ExecuteNonQuery();
                                break;
                            case 2:
                                command.Parameters.AddWithValue("@IDCliente", _EntiT.IDCliente);
                                command.Parameters.AddWithValue("@TipoTrabajo", _EntiT.TipoTrabajo);
                                command.Parameters.AddWithValue("@Pedido", _EntiT.Pedido);
                                command.Parameters.AddWithValue("@Detalle", _EntiT.Detalle);
                                command.Parameters.AddWithValue("@FechaRecepcion", _EntiT.FechaRecepcion);
                                command.Parameters.AddWithValue("@FechaEntrega", _EntiT.FechaEntrega);
                                command.Parameters.AddWithValue("@Entrega", _EntiT.Entrega);
                                command.Parameters.AddWithValue("@Precio", _EntiT.Precio);
                                command.ExecuteNonQuery();
                                break;
                        }
                        break;
                    case "SP_Eliminar":
                        switch (tipo)
                        {
                            case 1:
                                command.Parameters.AddWithValue("@ID", _EntiC.ID);
                                command.ExecuteNonQuery();
                                break;
                            case 2:
                                command.Parameters.AddWithValue("@ID", _EntiT.ID);
                                command.ExecuteNonQuery();
                                break;
                        }
                        break;
                }
           

            }
        }

    }
}

using Capa_Datos;
using Capa_Entidades;

namespace Capa_Logica
{
    public class LogicaClass
    {
        BaseDatosClass _Bdclass = new BaseDatosClass();
        EntidadesClass.TbClientes _entcliente = new EntidadesClass.TbClientes();
        EntidadesClass.TbTrabajos _enttrabajo = new EntidadesClass.TbTrabajos();
        public void OperacionesCliente(int tipo, string comand)
        {
            _Bdclass.OperacionesBD(tipo, comand);
       
        }
        public void Guardar(string t1, string t2, string t3, string t4, string t5, string t6, string t7, string t8, int tipo)
        {
            string comand = "SP_Guardar";
            switch (tipo)
            {
                case 1:
                    _entcliente.Cliente = t1;
                    _entcliente.Telefono = double.Parse(t2);
                    _Bdclass.OperacionesBD(tipo, comand);
                    break;
                case 2:
                    _enttrabajo.IDCliente = int.Parse(t1);
                    _enttrabajo.TipoTrabajo = t2;
                    _enttrabajo.Pedido = t3;
                    _enttrabajo.Detalle = t4;
                    _enttrabajo.FechaRecepcion = t5;
                    _enttrabajo.FechaEntrega = t6;
                    _enttrabajo.Entrega = decimal.Parse(t7);
                    _enttrabajo.Precio = decimal.Parse(t8);
                    _Bdclass.OperacionesBD(tipo, comand);
                    break;
            }
            

        }
    }
    
}

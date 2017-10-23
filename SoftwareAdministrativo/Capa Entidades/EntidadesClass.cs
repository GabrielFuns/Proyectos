using System;

namespace Capa_Entidades
{
    public class EntidadesClass
    {
        public class TbClientes
        {
            public int ID { get; set; }
            public string Cliente { get; set; }
            public double Telefono { get; set; }
        }
        public class TbTrabajos
        {
            public int ID { get; set; }
            public int IDCliente { get; set; }
            public string TipoTrabajo { get; set; }
            public string Pedido { get; set; }
            public string Detalle { get; set; }
            public DateTime FechaRecepcion { get; set; }
            public DateTime FechaEntrega { get; set; }
            public decimal Entrega { get; set; }
            public decimal Precio { get; set; }
        }
       
    }
   
}

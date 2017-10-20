using System;

namespace Capa_Entidades
{
    public class EntidadesClass
    {
        public class TbClientes
        {
            public int ID { get; set; }
            public string Cliente { get; set; }

            /// <summary>
            /// Revisar
            /// </summary>
            public string Nombre
            {
                get
                {

                }
                set
                {
                    if (String.IsNullOrWhiteSpace(value))
                    {
                        throw new ValidationException("Debe proveerse un nombre.");
                    }
 
                }
            }
            /// <summary>
            /// Revisar
            /// </summary>
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
        /// <summary>
        /// Revisar
        /// </summary>
        public class ValidationException : System.Exception
        {
            public string FriendlyMessage { get; protected set; }

            public ValidationException(string friendlyMessage, System.Exception inner = null)
                : base("Error de validación.", inner)
            {
                FriendlyMessage = friendlyMessage;
            }
        }
        //Revisar
    }
   
}

using Capa_Datos;
using Aplicacion;
namespace Capa_Logica
{
    public class LogicaClass
    {
        BaseDatosClass _Bdclass = new BaseDatosClass();
        
        public void OperacionesCliente(int tipo)
        {
            _Bdclass.OperacionesBD(tipo, "String");
          
        }
    }
    
}

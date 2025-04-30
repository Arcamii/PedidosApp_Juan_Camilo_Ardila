using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp_Juan_Camilo_Ardila
{
    public static class EntregaFactory
    {
        public static IMetodoEntrega CrearEntrega(string tipoProducto, bool urgente, double peso)
        {
            if (tipoProducto == "Tecnología" && urgente)
                return new EntregaDron();
            else if (tipoProducto == "Accesorio" && peso < 2 && !urgente)
                return new EntregaBicicleta();
            else if (tipoProducto == "Accesorio")
                return new EntregaMoto();
            else if (tipoProducto == "Componente" || peso > 10)
                return new EntregaCamion();
            else
                return new EntregaMoto(); // valor por defecto
        }
    }
}

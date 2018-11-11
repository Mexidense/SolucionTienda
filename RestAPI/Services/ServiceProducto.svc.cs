using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RestAPI.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceProducto" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceProducto.svc o ServiceProducto.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceProducto : IServiceProducto
    {
        public void agregarProducto(int codigo, string nombre, int valor)
        {
            BDProductoEntities entities = new BDProductoEntities();

            PRODUCTO p = new PRODUCTO();
            p.NOMBRE = nombre;
            p.CODIGO = codigo;
            p.VALOR = valor;

            entities.PRODUCTO.Add(p);
            entities.SaveChanges();
        }
    }
}

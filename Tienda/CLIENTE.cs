//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tienda
{
    using System;
    using System.Collections.Generic;
    
    public partial class CLIENTE
    {
        public int RUT { get; set; }
        public string NOMBRE { get; set; }
        public int COMUNA_ID { get; set; }
    
        public virtual COMUNA COMUNA { get; set; }
    }
}
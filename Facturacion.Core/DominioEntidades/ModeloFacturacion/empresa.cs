//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DominioEntidades.ModeloFacturacion
{
    using System;
    using System.Collections.Generic;
    
    public partial class empresa
    {
        public long embi_empresa_id { get; set; }
        public string emvc_nombre_empresa { get; set; }
        public string emvc_sucursal_empresa { get; set; }
        public string emvc_nit_empresa { get; set; }
        public string emvc_direccion_empresa { get; set; }
        public string emvc_telefono_empresa { get; set; }
        public string emvc_cel_empresa { get; set; }
        public string lxvc_ciudad { get; set; }
        public System.DateTime emdt_fecha_registro { get; set; }
        public string emvc_user_registro { get; set; }
        public Nullable<System.DateTime> emdt_fecha_modif { get; set; }
        public string emvc_user_modif { get; set; }
        public bool embt_activo { get; set; }
    }
}

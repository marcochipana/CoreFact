using DominioEntidades.ModeloFacturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Credenciales
    {
        public static string AccessDenied = "NO TIENE PERMISO DE ACCESO AL SERVICIO";

        public static string NullCredentials = "LAS CREDENCIALES NO PUEDEN SER NULAS";

        public static bool Validate(CREDENCIALES objCredenciales)
        {
            if (objCredenciales == null)
            {
                throw new Exception(NullCredentials);
            }
            else
            {

                return true;
            }
        }
    }
}

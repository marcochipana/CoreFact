using DominioEntidades.ModeloFacturacion;
using DominioServicios.Administracion;
using PersistenciaModelo.ModeloFacturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenciaMetodos.Administracion
{
    public class CPersistenciaEmpresa : IDominioEmpresa
    {
        #region constructor instancia

        readonly db_facturacion_entities _context;
        public CPersistenciaEmpresa(db_facturacion_entities dbFacturacion)
        {
            _context = dbFacturacion;
        }

        #endregion

        public List<empresa> GetListEmpresaByNombre(string strNombreEmpresa, bool bolActivo)
        {
            try
            {
                List<empresa> query;
                if (strNombreEmpresa == null)
                {
                    query = _context.empresa.ToList()
                   .Select(sQuery => sQuery)
                   .Where(wQuery => wQuery.embt_activo == bolActivo)
                   .ToList();
                }
                else
                {
                    query = _context.empresa.ToList()
                   .Select(sQuery => sQuery)
                   .Where(wQuery => wQuery.emvc_nombre_empresa.Contains(strNombreEmpresa) && wQuery.embt_activo == bolActivo)
                   .ToList();
                }
               

                return query;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}

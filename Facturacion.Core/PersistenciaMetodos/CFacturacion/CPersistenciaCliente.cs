using DominioEntidades.ModeloFacturacion;
using DominioServicios.IFacturacion;
using PersistenciaModelo.ModeloFacturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenciaMetodos.CFacturacion
{
    public class CPersistenciaCliente : IDominioCliente
    {
        #region constructor instancia

        readonly db_facturacion_entities _context;
        public CPersistenciaCliente(db_facturacion_entities dbFacturacion)
        {
            _context = dbFacturacion;
        }

        #endregion

        public List<cliente> GetListClienteByPaterno(string strNombrePaterno)
        {
            try
            {
                var query = _context.cliente.ToList()
                    .Select(sQuery => sQuery)
                    .Where(wQuery => wQuery.clvc_apellido.Contains(strNombrePaterno))
                    .ToList();

                return query;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}

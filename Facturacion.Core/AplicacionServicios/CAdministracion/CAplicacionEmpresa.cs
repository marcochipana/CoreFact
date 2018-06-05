using DominioEntidades.ModeloFacturacion;
using DominioServicios.Administracion;
using PersistenciaMetodos.Administracion;
using PersistenciaModelo.ModeloFacturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionServicios.CAdministracion
{
    public class CAplicacionEmpresa
    {
        #region contructor instancia

        private readonly IDominioEmpresa _repositorioEmpresa;

        public CAplicacionEmpresa()
        {
            var dbContext = new db_facturacion_entities();
            _repositorioEmpresa = new CPersistenciaEmpresa(dbContext);
        }

        #endregion

        public List<empresa> GetListEmpresaByNombre(string strNombreEmpresa, bool bolActivo)
        {
            try
            {
                return _repositorioEmpresa.GetListEmpresaByNombre(strNombreEmpresa, bolActivo);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

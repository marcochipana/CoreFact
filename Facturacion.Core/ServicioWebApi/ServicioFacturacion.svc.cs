using AplicacionServicios.CAdministracion;
using AplicacionServicios.CFacturacion;
using Common;
using DominioEntidades.ModeloFacturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioWebApi
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicioFacturacion
    {
        private readonly CAplicacionProducto _aplicacionProducto = new CAplicacionProducto();
        private readonly CAplicacionCliente _aplicacionCliente = new CAplicacionCliente();
        private readonly CAplicacionDataBase _aplicacionDatabase = new CAplicacionDataBase();

        #region productos

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetProducto/{strProductoId}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public producto GetObjPersona(string strProductoId)
        {
            try
            {
                //Log.Inicio(objCredenciales);
                //if (Credenciales.Validate(objCredenciales))
                    return _aplicacionProducto.GetObjProductoByProductoId(Convert.ToInt32(strProductoId));
                throw new Exception(Credenciales.AccessDenied);
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }

        }

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetListProductos/{strNombreProducto}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public List<producto> GetListPersonasLikeNombre(string strNombreProducto)
        {
            try
            {
                return _aplicacionProducto.GetListProductosLikeNombre(strNombreProducto);
            }
            catch (Exception)
            {
                throw;
            }

        }

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetSpListProductos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public List<producto> GetSpListProductos()
        {
            try
            {
                return _aplicacionProducto.GetSpListProductos();
            }
            catch (Exception)
            {
                throw;
            }

        }

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/SaveProducto", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public int SaveProducto(producto objProducto)
        {
            try
            {
                return _aplicacionProducto.SaveProducto(objProducto);
            }
            catch (Exception)
            {
                throw;
            }

        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/UpdateProducto/{strProductoId}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public bool UpdateProducto(producto objProducto, string strProductoId)
        {
            try
            {
                objProducto.prin_producto_id = Convert.ToInt32(strProductoId);
                return _aplicacionProducto.UpdateProducto(objProducto);
            }
            catch (Exception)
            {
                throw;
            }

        }

        //[OperationContract]
        //[WebInvoke(Method = "DELETE", UriTemplate = "/Transaction/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //public bool DeleteTransaction(string id)
        //{
        //    //
        //    var persona = new personas();
        //    persona.nombre = "tes";
        //    persona.apellido = "test";
        //    return persona;
        //    return null;
        //}

        #endregion

        #region cliente

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetListClientes/{strPaterno}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public List<cliente> GetListClienteByPaterno(string strPaterno)
        {
            try
            {
                return _aplicacionCliente.GetListClienteByPaterno(strPaterno);
            }
            catch (Exception)
            {
                throw;
            }

        }

        #endregion

        #region Admin database

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/CreateCompany/{strCompanyName}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public bool CrearBaseDatos(string strCompanyName)
        {
            try
            {
                return _aplicacionDatabase.CrearBaseDatos(strCompanyName);
            }
            catch (Exception)
            {
                throw;
            }

        }

        #endregion

    }
}

using SispeServicios.Api.Ciudadano.RemoteModel;
using System.Dynamic;

namespace SispeServiciosApiCiudadano.Aplicacion.Utils
{
    static class UsuarioRemotoConvert
    {
        public static UsuarioRemote Usuario(UsuarioRemote remote, dynamic request, bool crear =true)
        {
           
            remote.idAplicacion = "0ce1e976-d33a-4ee0-ab86-672539614136";
            remote.nacionalidadId = "1";
            if (crear) { 
                remote.confirmPassword = request.Password;
            }
            
            remote.rol = "buscador";
            remote.cuentaVerificada = true;
            remote.direccion = (remote.direccion is null) ? new DireccionRemote() : remote.direccion;
            if (remote.direccion is not null)
            {               
                remote.direccion.paisId = request.PaisResidenciaId;
                remote.direccion.departamentoId = (request.DepartamentoResidenciaId == null)?"":request.DepartamentoResidenciaId;
                remote.direccion.municipioId = (request.MunicipioResidenciaId == null)?"": request.MunicipioResidenciaId;
                remote.direccion.localidadComunaId = (request.LocalidadComunaId == null)?0: request.LocalidadComunaId;
                remote.direccion.estado = (request.Estado == null)?"": request.Estado;
                remote.direccion.ciudad = (request.Ciudad == null)?"": request.Ciudad;
                remote.direccion.codigoPostal = request.CodigoPostal;
                remote.direccion.perteneceARural = request.PerteneceARural.ToString();
                remote.direccion.barrio = request.BarrioResidencia;
                remote.direccion.direccion = request.DireccionResidencia;
                remote.direccion.direccionComplemento = (remote.direccion is null) ? new List<DireccionComplementoRemote>(): remote.direccion.direccionComplemento;
                //foreach (var item in remote.direccion.direccionComplemento)
                //{
                //    var c = new DireccionComplementoRemote();
                //    c.direccionId = item.direccionId;
                //    c.complemento = item.complemento;
                //    c.complementoId= item.complementoId; 
                //    c.complementoNombre = item.complementoNombre;  
                //    remote.direccion.direccionComplemento.Add(c);
                //}
            }
            return remote;
        }
    }
}

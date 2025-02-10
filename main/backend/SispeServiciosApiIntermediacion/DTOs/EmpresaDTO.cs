using SispeServicios.Api.Intermediacion.Modelo;

namespace SispeServicios.Api.Intermediacion.DTOs
{

    public class EmpresaBaseDTO
    {
        public int TipoDocumentoId { get; set; }
        public string? NumeroDocumento { get; set; }

    }

    public class EmpresaDTO : EmpresaBaseDTO
    {
        public int Id { get; set; }
        public string? RazonSocial { get; set; }
    }

    public class EmpresaDetalleDTO : EmpresaBaseDTO
    {
        public int Id { get; set; }
        public int TipoDocumentoId { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? RazonSocial { get; set; }
        public List<EmpresaSedeDetalleDTO>? Sedes { get; set; }
    }


    public class EmpresaSedeDTO
    {
        public int Id { get; set; }
        public int EmpresaId { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
    }

    public class EmpresaSedeDetalleDTO
    {
        public int Id { get; set; }
        public EmpresaDTO? Empresa { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public List<EmpresaSedeResponsableDTO>? Usuarios { get; set; }
    }

    public class EmpresaSedeResponsableDTO{
        //public bool EsPrincipal { get; set; }
        public Guid Id { get; set; }
        public int TipoDocumentoId { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }

        private string? correoElectronico;
        public string? CorreoElectronico
        {
            get
            {


                string[] separada = correoElectronico.Split('@');
                int inicio = 3; //Caracteres al inicio de la cadena que dejamos visibles
                int final = 3; //Caracteres al final de la cadena que dejamos visibles
                int longitud;
                if (separada[0].Length > inicio + final)
                    longitud = separada[0].Length - final - inicio;
                else
                    longitud = 1;

                separada[0] = separada[0].Remove(inicio, longitud).Insert(inicio, new string('*', longitud));
                return String.Join("@", separada);
            }
            set
            {
                correoElectronico = value;
            }
        }
    }

    public class EmpresaUsuarioDTO
    {
        public Guid Id { get; set; }
        public int TipoDocumentoId { get; set; }
        public int EmpresaId { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }

        private string? correoElectronico;
        public string? CorreoElectronico {
            get {

                
                string[] separada = correoElectronico.Split('@');
                int inicio = 1; //Caracteres al inicio de la cadena que dejamos visibles
                int final = 2; //Caracteres al final de la cadena que dejamos visibles
                int longitud;
                if (separada[0].Length > inicio + final)
                    longitud = separada[0].Length - final - inicio;
                else
                    longitud = 1;

                separada[0] = separada[0].Remove(inicio, longitud).Insert(inicio, new string('*', longitud));
                return String.Join("@", separada);                             
            }
            set {
                correoElectronico = value;
            }
        }

    }
}

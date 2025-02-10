using Xphera.Library.Common.Entities.Interfaces.Events;

namespace SispeServiciosEventos.Queue.v1
{
    public class SendQueueEvent : IDomainEvent
    {
        public string? IdCiudadano { get; set; }
        public string? IdVacante { get; set; }
        public Guid IdEjecucion { get; set; }
        public List<ExternalRequestBodyDto> ExternalRequestBodyDto { get; set; }
    }
    public class ExternalRequestBodyDto
    {
        public string Tabla { get; set; } = default!;
        public RegistroDto Registro { get; set; } = default!;
    }

    public class RegistroDto
    {
        public string Id { get; set; } = default!;
        public string Proceso { get; set; } = default!;
    }
}

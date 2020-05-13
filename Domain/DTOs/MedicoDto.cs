using Domain.Entities;


namespace Domain.DTOs {

    public class MedicoDto {
        public string MedicoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public int EspecialidadId { get; set; }
    }
}
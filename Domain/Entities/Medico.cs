using System.ComponentModel.DataAnnotations;


namespace Domain.Entities {

    public class Medico {
        public int MedicoId { get; set; }
        [StringLengthAttribute(64)]
        [Required]
        public string Nombre { get; set; }
        [StringLengthAttribute(64)]
        [Required]
        public string Apellido { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public int EspecialidadId { get; set; }
        public Especialidad Especialidades { get; set; }
    }
}
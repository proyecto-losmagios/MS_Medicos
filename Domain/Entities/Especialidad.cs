using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace Domain.Entities {

    public class Especialidad {
        public int EspecialidadId { get; set; }
        public string Codigo { get; set; }
        [StringLengthAttribute(128)]
        public string Nombre { get; set; }

        public ICollection<Medico> Medicos { get; set; }
    }
}
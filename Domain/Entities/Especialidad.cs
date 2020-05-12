using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


/*
Link con especialidades modelo:
https://wiki.itcsoluciones.com/index.php/C%C3%B3digos_de_Especialidades_XML
*/

namespace Domain.Entities {

    public class Especialidad {
        public int EspecialidadId { get; set; }
        [StringLengthAttribute(8)]
        [Required]
        public string Codigo { get; set; }
        [StringLengthAttribute(128)]
        [Required]
        public string Nombre { get; set; }

        public ICollection<Medico> Medicos { get; set; }
    }
}
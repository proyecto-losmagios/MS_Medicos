using System.Collections.Generic;
using Domain.DTOs;


namespace Domain.Queries {

    public interface IEspecialidadQuery {
        List<EspecialidadDto> SearchEspecialidad(string q); 
    }

}
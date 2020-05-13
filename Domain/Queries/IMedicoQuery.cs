using System.Collections.Generic;
using Domain.DTOs;


namespace Domain.Queries {

    public interface IMedicoQuery {
        List<MedicoDto> SearchMedico(string q); 
    }

}
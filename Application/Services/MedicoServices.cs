using Domain.Commands;
using Domain.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Queries;


namespace Application.Services {

    public interface IMedicoServices {
        Medico CreateMedico(MedicoDto medico);
        List<MedicoDto> SearchMedico(string q);
    }

    public class MedicoServices : IMedicoServices {

        private readonly IGenericsRepository _repository;
        private readonly IMedicoQuery _query;

        public MedicoServices(IGenericsRepository repository, IMedicoQuery query) {
            _repository = repository;
            _query = query;
            
        }

        public Medico CreateMedico(MedicoDto medico) {
            var entity = new Medico {
                Nombre = medico.Nombre,
                Apellido = medico.Apellido,
                Email = medico.Email,
                EspecialidadId = medico.EspecialidadId

            };

            _repository.Add<Medico>(entity);

            return entity;
        }
               
        public List<MedicoDto> SearchMedico(string q) {
           return  _query.SearchMedico(q);
        }
    }
}

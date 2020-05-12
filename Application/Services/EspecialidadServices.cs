using Domain.Commands;
using Domain.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Queries;


namespace Application.Services {

    public interface IEspecialidadServices {
        Especialidad CreateEspecialidad(EspecialidadDto especialidad);
        List<EspecialidadDto> SearchEspecialidad(string q);
    }

    public class EspecialidadServices : IEspecialidadServices {

        private readonly IGenericsRepository _repository;
        private readonly IEspecialidadQuery _query;

        public EspecialidadServices(IGenericsRepository repository, IEspecialidadQuery query) {
            _repository = repository;
            _query = query;
            
        }

        public Especialidad CreateEspecialidad(EspecialidadDto especialidad) {
            var entity = new Especialidad {
                Codigo = especialidad.Codigo,
                Nombre = especialidad.Nombre
            };

            _repository.Add<Especialidad>(entity);

            return entity;
        }
               
        public List<EspecialidadDto> SearchEspecialidad(string q) {
           return  _query.SearchEspecialidad(q);
        }
    }
}

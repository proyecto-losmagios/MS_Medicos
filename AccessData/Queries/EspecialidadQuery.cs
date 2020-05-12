
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Domain.DTOs;
using Domain.Queries;


namespace AccessData.Queries {

    public class EspecialidadQuery : IEspecialidadQuery {

        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public EspecialidadQuery(IDbConnection connection, Compiler sqlKataCompiler) {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public List<EspecialidadDto> SearchEspecialidad(string search_q) {
            var db = new QueryFactory(connection, sqlKataCompiler);

            var query = db.Query("Especialidades")
                .Select("EspecialidadId",
                        "Codigo",
                        "Nombre")
                .When(!string.IsNullOrWhiteSpace(search_q), q => q
                    .WhereLike("Codigo", $"%{search_q}%")
                    .OrWhereLike("Nombre", $"%{search_q}%")
                    );

            var result = query.Get<EspecialidadDto>();

            return result.ToList();
        }

    }
}

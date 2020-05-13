
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Domain.DTOs;
using Domain.Queries;


namespace AccessData.Queries {

    public class MedicoQuery : IMedicoQuery {

        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public MedicoQuery(IDbConnection connection, Compiler sqlKataCompiler) {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public List<MedicoDto> SearchMedico(string search_q) {
            var db = new QueryFactory(connection, sqlKataCompiler);

            var query = db.Query("Medicos")
                .Select("MedicoId",
                        "Nombre",
                        "Apellido",
                        "Email",
                        "EspecialidadId")
                .When(!string.IsNullOrWhiteSpace(search_q), q => q
                    .WhereLike("Nombre", $"%{search_q}%")
                    .OrWhereLike("Apellido", $"%{search_q}%")
                    );

            var result = query.Get<MedicoDto>();

            return result.ToList();
        }

    }
}

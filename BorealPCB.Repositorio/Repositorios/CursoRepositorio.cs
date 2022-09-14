using BorealPCB.Dominio.Funcionarios;
using BorealPCB.Repositorio.Conexao;
using Dapper;
using System.Collections.Generic;

namespace BorealPCB.Repositorio.Repositorios
{
    public class CursoRepositorio
    {
        public DapperContext _dapper { get; set; }

        public CursoRepositorio()
        {
            _dapper = new DapperContext();
        }

        public IEnumerable<Curso> Todos()
        {
            using (var connection = _dapper.CreateConnection())
            {
                return connection.Query<Curso>("SELECT * FROM curso");
            }
        }
    }
}

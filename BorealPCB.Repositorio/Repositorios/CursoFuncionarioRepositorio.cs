using BorealPCB.Dominio.Funcionarios;
using BorealPCB.Repositorio.Conexao;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorealPCB.Repositorio.Repositorios
{
    public class CursoFuncionarioRepositorio
    {
        public DapperContext _dapper { get; set; }

        public CursoFuncionarioRepositorio()
        {
            _dapper = new DapperContext();
        }

        public IEnumerable<CursoFuncionario> Todos()
        {
            using (var connection = _dapper.CreateConnection())
            {
                return connection.Query<CursoFuncionario>("SELECT * FROM curso_funcionario");
            }
        }

        public IEnumerable<CursoFuncionario> PorFuncionario(int matricula)
        {
            using (var connection = _dapper.CreateConnection())
            {
                return connection.Query<CursoFuncionario>(@"
                    SELECT cod_curso,
	                       (SELECT descricao FROM sc090_pcb.curso WHERE sc090_pcb.curso.cod_curso = sc090_pcb.curso_funcionario.cod_curso) as descricao,
                           matricula, 
                           pontuacao, 
                           data_conclusao 
                    FROM sc090_pcb.curso_funcionario
                    WHERE matricula = @matricula;",
                    new { matricula });
            }
        }
    }
}

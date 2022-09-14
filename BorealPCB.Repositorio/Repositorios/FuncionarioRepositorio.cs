using BorealPCB.Dominio.Funcionarios;
using BorealPCB.Repositorio.Conexao;
using Dapper;
using System;
using System.Collections.Generic;

namespace BorealPCB.Repositorio.Repositorios
{
    public class FuncionarioRepositorio
    {
        public DapperContext _dapper { get; set; }

        public FuncionarioRepositorio()
        {
            _dapper = new DapperContext();
        }

        public IEnumerable<Funcionario> Todos()
        {
            using (var connection = _dapper.CreateConnection())
            {
                return connection.Query<Funcionario>("SELECT * FROM funcionario");
            }
        }

        public Funcionario Obter(int funcionarioMatricula)
        {
            using (var connection = _dapper.CreateConnection())
            {
                return connection.QueryFirstOrDefault<Funcionario>("SELECT * FROM funcionario WHERE matricula = @funcionarioMatricula", new { funcionarioMatricula });
            }
        }
    }
}

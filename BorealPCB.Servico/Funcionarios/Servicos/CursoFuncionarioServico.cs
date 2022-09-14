using BorealPCB.Dominio.Funcionarios;
using BorealPCB.Repositorio.Repositorios;
using BorealPCB.Servico.Funcionarios.Interfaces;
using System.Collections.Generic;

namespace BorealPCB.Servico.Funcionarios.Servicos
{
    public class CursoFuncionarioServico : ICursoFuncionarioServico
    {
        public CursoFuncionarioRepositorio _repositorio { get; set; }

        public CursoFuncionarioServico()
        {
            _repositorio = new CursoFuncionarioRepositorio();
        }

        public IEnumerable<CursoFuncionario> Todos()
        {
            return _repositorio.Todos();
        }

        public IEnumerable<CursoFuncionario> PorFuncionario(int matricula)
        {
            return _repositorio.PorFuncionario(matricula);
        }
    }
}

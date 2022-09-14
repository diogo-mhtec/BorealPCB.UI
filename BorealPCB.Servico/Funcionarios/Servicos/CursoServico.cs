using BorealPCB.Dominio.Funcionarios;
using BorealPCB.Repositorio.Repositorios;
using BorealPCB.Servico.Funcionarios.Interfaces;
using System.Collections.Generic;

namespace BorealPCB.Servico.Funcionarios.Servicos
{
    public class CursoServico : ICursoServico
    {
        public CursoRepositorio _repositorio { get; set; }

        public CursoServico()
        {
            _repositorio = new CursoRepositorio();
        }

        public IEnumerable<Curso> Todos()
        {
            return _repositorio.Todos();
        }
    }
}

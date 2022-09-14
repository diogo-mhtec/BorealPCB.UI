using BorealPCB.Dominio.Funcionarios;
using BorealPCB.Repositorio.Repositorios;
using BorealPCB.Servico.Funcionarios.Interfaces;
using System.Collections.Generic;

namespace BorealPCB.Servico.Funcionarios.Servicos
{
    public class FuncionarioServico : IFuncionarioServico
    {
        public FuncionarioRepositorio _repositorio { get; set; }

        public FuncionarioServico()
        {
            _repositorio = new FuncionarioRepositorio();
        }

        public IEnumerable<Funcionario> Todos()
        {
            return _repositorio.Todos();
        }

        public Funcionario Obter(int funcionarioMatricula)
        {
            return _repositorio.Obter(funcionarioMatricula);            
        }
    }
}

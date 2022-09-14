using BorealPCB.Dominio.Funcionarios;
using System.Collections.Generic;

namespace BorealPCB.Servico.Funcionarios.Interfaces
{
    public interface IFuncionarioServico
    {
        IEnumerable<Funcionario> Todos();
        Funcionario Obter(int funcionarioMatricula);
    }
}

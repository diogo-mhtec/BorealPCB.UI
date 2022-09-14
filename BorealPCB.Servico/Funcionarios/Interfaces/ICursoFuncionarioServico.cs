using BorealPCB.Dominio.Funcionarios;
using System.Collections.Generic;

namespace BorealPCB.Servico.Funcionarios.Interfaces
{
    public interface ICursoFuncionarioServico
    {
        IEnumerable<CursoFuncionario> Todos();
        IEnumerable<CursoFuncionario> PorFuncionario(int matricula);
    }
}

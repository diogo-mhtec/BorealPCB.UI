using BorealPCB.Dominio.Funcionarios;
using System.Collections.Generic;

namespace BorealPCB.Servico.Funcionarios.Interfaces
{
    public interface ICursoServico
    {
        IEnumerable<Curso> Todos();
    }
}

using Dapper.Contrib.Extensions;
using System;

namespace BorealPCB.Dominio.Funcionarios
{
    [Table("curso_funcionario")]
    public class CursoFuncionario
    {
        public int cod_curso { get; set; }
        [Computed]
        public string descricao { get; set; }
        public int matricula { get; set; }
        public int pontuacao { get; set; }
        public DateTime data_conclusao { get; set; }
    }
}

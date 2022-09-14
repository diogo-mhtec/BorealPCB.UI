using Dapper.Contrib.Extensions;

namespace BorealPCB.Dominio.Funcionarios
{
    [Table("curso")]
    public class Curso
    {
        public int cod_curso { get; set; }
        public string descricao { get; set; }
        public decimal carga_horaria { get; set; }
        public decimal ies_valido { get; set; }
        public int qtd_pontos { get; set; }
        public int qtd_pontos_ant { get; set; }
        public int cod_classificacao { get; set; }        
    }
}

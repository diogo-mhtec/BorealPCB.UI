using Dapper.Contrib.Extensions;
using System;

namespace BorealPCB.Dominio.Funcionarios
{
    [Table("funcionario")]
    public class Funcionario
    {
        public int matricula { get; set; }
        public string Nome { get; set; }
        public DateTime data_admissao { get; set; }
        public int cod_cargo { get; set; }
        public int cod_classe { get; set; }
        public int cod_step_titulo { get; set; }
        public int cod_escolaridade { get; set; }
        public decimal salario { get; set; }
        public int pontos_tempo_anterior { get; set; }
        public int tempo_experiencia { get; set; }
        public DateTime data_ult_promocao { get; set; }
        public int chefia { get; set; }
        public int horas_trabalhadas { get; set; }         
    }
}

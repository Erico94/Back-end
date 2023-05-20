using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Pessoal.Models
{
    [Table("Tarefas_Semanais")]
    public class SemanaModel
    {
        [Column("ID"), Key] public int Id { get; set; }
        [Column("NOME_TAREFA"), Required] public string Nome { get; set; }
        [Column("DATA_ADICAO"), Required] public DateTime Data_Adicao { get; set; }
        [Column("DIA_DA_SEMANA"), Required] public string Dia_Semana { get; set; }
    }
}

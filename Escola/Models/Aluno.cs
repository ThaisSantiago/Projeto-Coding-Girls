using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace Escola.Models
{
    public class Aluno

      {
        public int Id { get; set; }

        public string Nome { get; set; }



        [Column("Data_Nascimento")]
        public DateTime DataNascimento { get; set; }

        public char Sexo { get; set; }

        public int TurmaId { get; set; }

        public int TotalFaltas { get; set; }

        #region  Navigation Properties
        [JsonIgnore]
        public virtual Turma? Turma { get; set; }
        #endregion
    }
}

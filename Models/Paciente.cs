using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agendamento.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [MaxLength(100)]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [MaxLength(14)]
        [Display(Name = "CPF")]
        public string? Cpf { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório.")]
        [MaxLength(20)]
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório.")]
        [MaxLength(200)]
        [Display(Name = "Endereço")]
        public string? Endereco { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}

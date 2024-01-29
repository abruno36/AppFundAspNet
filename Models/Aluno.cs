using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiroApp.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser obrigatório!")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres!")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo {0} deve ser obrigatório!")]
        [DataType(DataType.DateTime, ErrorMessage = "O campo {0} está no formato invalido!")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser obrigatório!")]
        [StringLength(60, ErrorMessage = "O campo {0} precisa ter no máximo {1} caracteres!")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})$", ErrorMessage = "O campo {0} está com formato inválido - regex!")]
        //[EmailAddress(ErrorMessage = "O campo {0} está com formato inválido!")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo {0} deve ser obrigatório!")]
        [Display(Name = "Confirme o e-mail")]
        [Compare("Email", ErrorMessage = "Os emails informados devem ser iguais!")]
        [NotMapped]
        public string EmailConfirmacao { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo {0} deve ser obrigatório!")]
        [Range(1, 5, ErrorMessage = "O campo {0} deve estar entre 1 e 5!")]
        [Display(Name = "Avaliação")]
        public int Avaliacao { get; set; } = 0;

        public bool Ativo { get; set; } = false;


    }
}

using System.ComponentModel.DataAnnotations;

namespace Ex5_FormularioRazor_AT.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "Nome obrigatorio")]
        [MinLength(5, ErrorMessage = "Nome muito curto")]
        public string Nome { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email obrigatorio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Data Invalida")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(Usuario), nameof(ValidarDataDeNascimento))]
        public DateTime DataDeNascimento { get; set; }

        public static ValidationResult ValidarDataDeNascimento(DateTime dataDeNascimento, ValidationContext context)
        {
            if (dataDeNascimento.Date > DateTime.Now.Date)
            {
                return new ValidationResult("A data de nascimento não pode ser no futuro.");
            }
            return ValidationResult.Success;
        }
    }
}

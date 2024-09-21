using System.ComponentModel.DataAnnotations;

namespace Ex5_FormularioRazor_AT.Models
{
    public class Usuario
    {
        [Required]
        public string Nome { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataDeNascimento { get; set; }

        public static ValidationResult ValidarDaDeNascimento(DateTime dataDeNascimento, ValidationContext context)
        {
            if (dataDeNascimento > DateTime.Now)
            {
                return new ValidationResult("A data de nascimento não pode ser no futuro.");
            }
            return ValidationResult.Success;
        }
    }
}

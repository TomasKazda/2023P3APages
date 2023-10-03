using System.ComponentModel.DataAnnotations;

namespace _2023P3APages1.InputModels
{
    public class RegistraceIM
    {
        [Display(Name = "First Name")]
        public string Name { get; set; }
        
        [Required]
        [MinLength(1, ErrorMessage = "Min lenght is one character.")]
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        [Display(Name = "Shoe size")]
        [Range(14, 50)]
        public int ShoeSize { get; set; }
        
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        public bool IsAdult { get; set; }

        [Display(Name = "Pohlaví")]
        public Gendre Gendre { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace _2023P3APages1.InputModels
{
    public enum Gendre
    {
        [Display(Name = "Muž")]
        Man = 0,
        [Display(Name = "Žena")]
        Woman = 1,
        [Display(Name = "Cosi")]
        Other = 3
    }
}

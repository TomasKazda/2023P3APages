using _2023P3APages1.InputModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _2023P3APages1.Pages.Data
{
    public class IndexModel : PageModel
    {
        public string Text { get; set; } = "Ml��m";

        [BindProperty]
        public RegistraceIM RegistraceData { get; set; } = new RegistraceIM();

        public void OnGet()
        {

        }

        public void OnGetText(string txt, int? kolik)
        {
            Text = "Ahoj sv�te!";
            if (txt?.Length > 0) Text = txt + kolik.ToString();
        }

        //page handler = Cisla
        public void OnGetCisla(int cislo)
        {
            Text = $"��slo je {cislo}";
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                
                
                Console.WriteLine("Valid form");
                return RedirectToPage("/Index",new { text = "Ahoj" });
            }

            return Page();
        }
    }
}

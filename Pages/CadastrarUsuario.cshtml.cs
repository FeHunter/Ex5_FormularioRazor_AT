using Ex5_FormularioRazor_AT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ex5_FormularioRazor_AT.Pages
{
    public class CadastrarUsuarioModel : PageModel
    {
        public Usuario Usuario { get; set; }

        public void OnGet()
        {
        }
    }
}

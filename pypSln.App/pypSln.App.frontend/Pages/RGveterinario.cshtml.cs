using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pypSln.App.dominio;
using pypSln.App.persistencia;

//librerias opcionales
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pypSln.App.frontend.Pages
{
    public class veterinarioModel : PageModel
    {
        private readonly IFRVeterinario repositorioVeterinario;

        public veterinarioModel()
        {
            this.repositorioVeterinario = new RVeterinario(new pypSln.App.persistencia.appContext());
        }
        [BindProperty]
        public veterinario veterinarios { set; get; }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            repositorioVeterinario.AddVeterinario(veterinarios);
            return RedirectToPage("./Registro");
        }
    }
}

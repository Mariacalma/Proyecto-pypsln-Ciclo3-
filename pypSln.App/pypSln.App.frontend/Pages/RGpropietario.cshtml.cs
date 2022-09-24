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
    public class propietarioModel : PageModel
    {
        private readonly IFRPropietario repositorioPropietario;

        public propietarioModel()
        {
            this.repositorioPropietario = new RPropietario(new pypSln.App.persistencia.appContext());
        }
        [BindProperty]
        public propietario propietarios { set; get; }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            repositorioPropietario.AddPropietario(propietarios);
            return RedirectToPage("./Registro");
        }
    }
}

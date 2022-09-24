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
    public class ovinoModel : PageModel
    {
        private readonly IFROvino repositorioOvino;
        private readonly IFRPropietario repositorioPropietario;

        public ovinoModel()
        {
            this.repositorioOvino = new ROvino(new pypSln.App.persistencia.appContext());
            this.repositorioPropietario = new RPropietario(new pypSln.App.persistencia.appContext());
        }
        [BindProperty]
        public ovino ovinos { set; get; }
        public int IdPropietario { set; get; }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            repositorioOvino.AddOvino(ovinos);
            return RedirectToPage("./Registro");
        }
    }
}

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
    public class visitapypModel : PageModel
    {
        private readonly IFRVisitaPYP repositorioVisitaPYP;

        public visitapypModel()
        {
            this.repositorioVisitaPYP = new RVisitaPYP(new pypSln.App.persistencia.appContext());
        }
        [BindProperty]
        public visitapyp visitapyps { set; get; }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            repositorioVisitaPYP.AddVisitaPYP(visitapyps);
            return RedirectToPage("./index");
        }
    }
}

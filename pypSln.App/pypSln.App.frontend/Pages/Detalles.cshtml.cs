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
    public class DetalleHistrorialModel : PageModel

    {
        private readonly IFRVisitaPYP repositorioVisitaPYP;

        public visitapyp visitapyps { set; get; }
        public DetalleHistrorialModel()
        {
            this.repositorioVisitaPYP = new RVisitaPYP(new pypSln.App.persistencia.appContext());
        }
        public IActionResult OnGet(int idVisitaPYP)

        {

            visitapyps = repositorioVisitaPYP.GetVisitaPYP(idVisitaPYP);
            //Console.WriteLine(propietario.Nombres);
            if (visitapyps == null)
            {
                return RedirectToPage("./NoFound");
            }
            else
            {
                return Page();
            }
        }
    }
}

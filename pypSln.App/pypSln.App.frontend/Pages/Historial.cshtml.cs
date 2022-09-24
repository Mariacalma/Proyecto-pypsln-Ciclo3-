using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pypSln.App.dominio;
using pypSln.App.persistencia;
using Microsoft.AspNetCore.Authorization;
//librerias opcionales

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace pypSln.App.frontend.Pages
{
    public class ListaHistorialModel : PageModel
    {
        private readonly IFRVisitaPYP repositorioVisitaPYP;
        public IEnumerable<visitapyp> visitapyp{set;get;} 

        public ListaHistorialModel()
        {
            this.repositorioVisitaPYP = new RVisitaPYP(new pypSln.App.persistencia.appContext());
        }
        public void OnGet(string filtroBusqueda)
        {
            visitapyp=repositorioVisitaPYP.GetAllVisitaPYP();
        }
    }
}

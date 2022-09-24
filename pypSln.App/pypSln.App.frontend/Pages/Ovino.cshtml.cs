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
    public class ListaOvinoModel : PageModel
    {

        private readonly IFROvino repositorioOvino;
        public IEnumerable<ovino> ovino{set;get;} 

        public ListaOvinoModel()
        {
            this.repositorioOvino= new ROvino(new pypSln.App.persistencia.appContext());  
        }

        public void OnGet(string filtroBusqueda)
        {
            ovino=repositorioOvino.GetAllOvino();
        }
    }
}

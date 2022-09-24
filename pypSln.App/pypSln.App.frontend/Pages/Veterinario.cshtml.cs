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

namespace pypSln.App.presentacion.Pages
{
    public class ListaVeterinarioModel : PageModel
    {

        private readonly IFRVeterinario repositorioVeterinario;
        public IEnumerable<veterinario> veterinario{set;get;} 

        public ListaVeterinarioModel()
        {
            this.repositorioVeterinario= new RVeterinario(new pypSln.App.persistencia.appContext());  
        }

        public void OnGet(string filtroBusqueda)
        {
            veterinario=repositorioVeterinario.GetAllVeterinario();
        }
    }
}

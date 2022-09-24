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
    public class ListaPropietarioModel : PageModel
    {

        private readonly IFRPropietario repositorioPropietario;
        public IEnumerable<propietario> propietario{set;get;} 

        public ListaPropietarioModel()
        {
            this.repositorioPropietario= new RPropietario(new pypSln.App.persistencia.appContext());  
        }

        public void OnGet(string filtroBusqueda)
        {
            propietario=repositorioPropietario.GetAllPropietario();
        }
    }
}

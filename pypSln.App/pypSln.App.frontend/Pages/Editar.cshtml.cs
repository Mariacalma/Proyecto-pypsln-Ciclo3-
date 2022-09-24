
using Microsoft.AspNetCore.Mvc;
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
    public class EditarOvinoModel : PageModel
    {
        private readonly IFROvino repositorioOvino;
        [BindProperty]
        public ovino ovinos { set; get; }
        public EditarOvinoModel()
        {
            this.repositorioOvino = new ROvino(new pypSln.App.persistencia.appContext());
        }
        public IActionResult OnGet(int idovino)
        {
            ovinos = repositorioOvino.GetOvino(idovino);
            if (ovinos == null)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            ovinos = repositorioOvino.UpdateOvino(ovinos);
            //repositorioPropietario.DeletePropietario(propietario.IdPersona);
            return RedirectToPage("./Ovino");
        }
    }


    public class EditarVeterinarioModel : PageModel
    {
        private readonly IFRVeterinario repositorioVeterinario;
        [BindProperty]
        public veterinario veterinarios { set; get; }
        public EditarVeterinarioModel()
        {
            this.repositorioVeterinario = new RVeterinario(new pypSln.App.persistencia.appContext());
        }
        public IActionResult OnGet(int idveterinario)
        {
            veterinarios = repositorioVeterinario.GetVeterinario(idveterinario);
            if (veterinarios == null)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            veterinarios = repositorioVeterinario.UpdateVeterinario(veterinarios);
            //repositorioPropietario.DeletePropietario(propietario.IdPersona);
            return RedirectToPage("./veterinario");
        }

    }


    public class EditarPropietarioModel : PageModel
    {
        private readonly IFRPropietario repositorioPropietario;
        [BindProperty]
        public propietario propietarios { set; get; }
        public EditarPropietarioModel()
        {
            this.repositorioPropietario = new RPropietario(new pypSln.App.persistencia.appContext());
        }
        public IActionResult OnGet(int idpropietario)
        {
            propietarios = repositorioPropietario.GetPropietario(idpropietario);
            if (propietarios == null)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            propietarios = repositorioPropietario.UpdatePropietario(propietarios);
            //repositorioPropietario.DeletePropietario(propietario.IdPersona);
            return RedirectToPage("./propietario");
        }

    }

}





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
        public ovino ovino { set; get; }
        public EditarOvinoModel()
        {
            this.repositorioOvino = new ROvino(new cuidadoAnimal.App.persistencia.appContext());
        }
        public IActionResult OnGet(int idovino)
        {
            ovino = repositorioOvino.GetOvino(idovino);
            if (ovino == null)
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
            ovino = repositorioOvino.UpdateOvino(ovino);
            //repositorioPropietario.DeletePropietario(propietario.IdPersona);
            return RedirectToPage("./Ovino");
        }
    }


    public class EditarVeterinarioModel : PageModel
    {
        private readonly IFRVeterinario repositorioVeterinario;
        [BindProperty]
        public veterinario veterinario { set; get; }
        public EditarVeterinarioModel()
        {
            this.repositorioVeterinario = new RVeterinario(new cuidadoAnimal.App.persistencia.appContext());
        }
        public IActionResult OnGet(int idveterinario)
        {
            veterinario = repositorioVeterinario.GetVeterinario(idveterinario);
            if (veterinario == null)
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
            veterinario = repositorioVeterinario.UpdateVeterinario(veterinario);
            //repositorioPropietario.DeletePropietario(propietario.IdPersona);
            return RedirectToPage("./veterinario");
        }

    }


    public class EditarPropietarioModel : PageModel
    {
        private readonly IFRPropietario repositorioPropietario;
        [BindProperty]
        public propietario propietario { set; get; }
        public EditarPropietarioModel()
        {
            this.repositorioPropietario = new RPropietario(new cuidadoAnimal.App.persistencia.appContext());
        }
        public IActionResult OnGet(int idpropietario)
        {
            propietario = repositorioPropietario.GetPropietario(idpropietario);
            if (propietario == null)
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
            propietario = repositorioPropietario.UpdatePropietario(propietario);
            //repositorioPropietario.DeletePropietario(propietario.IdPersona);
            return RedirectToPage("./propietario");
        }

    }

}




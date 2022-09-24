using System;
using System.ComponentModel.DataAnnotations;

namespace pypSln.App.dominio{
	public class propietario{
        [Key]
        public int Id { get;set; }
        public string Nombre { get;set; }
        public string Apellidos { get;set; }
        public string Direccion { get;set; }
        public string Email { get;set; }
        public string Telefono { get;set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace pypSln.App.dominio{
	public class ovino{
        [Key]
        public int Id { get;set; }
        public int Id_Propietario { get;set; }
        public string Nombre { get;set; }
        public string color { get;set; }
        public string raza { get;set; }
        public string sexo { get;set; }
	}
}
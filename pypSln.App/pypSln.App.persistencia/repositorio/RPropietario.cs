

using System.Collections.Generic;  //libreria donde se definen las interfaces
using pypSln.App.dominio;
using System.Linq;


namespace pypSln.App.persistencia{
    public class RPropietario : IFRPropietario  {
        private readonly appContext _appContext;
        public RPropietario(appContext appContext) {
            _appContext = appContext;
        }
        propietario IFRPropietario.AddPropietario(propietario propietario) {
            var propietarioAdicionado = _appContext.propietarios.Add(propietario);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;
        }
        void IFRPropietario.DeletePropietario(int Idpropietario) {
            var propietarioEncontrado = _appContext.propietarios.FirstOrDefault(p => p.Id == Idpropietario);

            _appContext.propietarios.Remove(propietarioEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<propietario> IFRPropietario.GetAllPropietario() {
            return _appContext.propietarios;
        }
        propietario IFRPropietario.GetPropietario(int Idpropietario) {
            return _appContext.propietarios.FirstOrDefault(p => p.Id == Idpropietario);
        }
        propietario IFRPropietario.UpdatePropietario(propietario propietario) {
            var propietarioEncontrado = _appContext.propietarios.FirstOrDefault(p => p.Id == propietario.Id);
            if (propietarioEncontrado != null) {
                propietarioEncontrado.Id = propietario.Id;
                propietarioEncontrado.Nombre = propietario.Nombre;
                propietarioEncontrado.Apellidos = propietario.Apellidos;
                propietarioEncontrado.Direccion = propietario.Direccion;
                propietarioEncontrado.Email = propietario.Email;
                propietarioEncontrado.Telefono = propietario.Telefono;
                _appContext.SaveChanges();
            }
            return propietarioEncontrado;
        }
    }
}
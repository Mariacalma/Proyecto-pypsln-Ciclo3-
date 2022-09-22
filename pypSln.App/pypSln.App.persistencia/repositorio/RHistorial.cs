

using System.Collections.Generic;  //libreria donde se definen las interfaces
using pypSln.App.dominio;
using System.Linq;


namespace pypSln.App.persistencia{
    public class RHistorial : IFRHistorial  {
        private readonly appContext _appContext;
        public RHistorial(appContext appContext) {
            _appContext = appContext;
        }
        historiaClinica IFRHistorial.AddHistorial(historiaClinica historial) {
            var historialAdicionado = _appContext.historiaClinicas.Add(historial);
            _appContext.SaveChanges();
            return historialAdicionado.Entity;
        }
        void IFRHistorial.DeleteHistorial(int idhistorial) {
            var historialEncontrado = _appContext.historiaClinicas.FirstOrDefault(p => p.Id == idhistorial);

            _appContext.historiaClinicas.Remove(historialEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<historiaClinica> IFRHistorial.GetAllHistorial() {
            return _appContext.historiaClinicas;
        }
        historiaClinica IFRHistorial.GetHistorial(int Idhistorial) {
            return _appContext.historiaClinicas.FirstOrDefault(p => p.Id == Idhistorial);
        }
        historiaClinica IFRHistorial.UpdateHistorial(historiaClinica historial) {
            var historialEncontrado = _appContext.historiaClinicas.FirstOrDefault(p => p.Id == historial.Id);
            if (historialEncontrado != null) {
                historialEncontrado.Id = historial.Id;
                historialEncontrado.Id_registro = historial.Id_registro;
                historialEncontrado.Id_propietario = historial.Id_propietario;
                historialEncontrado.Id_ovino = historial.Id_ovino;
                historialEncontrado.Id_veterinario = historial.Id_veterinario;
                historialEncontrado.Fecha_registro = historial.Fecha_registro;
                historialEncontrado.Recomendaciones = historial.Recomendaciones;
                historialEncontrado.Formula = historial.Formula;
                _appContext.SaveChanges();
            }
            return historialEncontrado;
        }
    }
}
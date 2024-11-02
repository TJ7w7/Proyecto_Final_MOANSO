using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogDivisionesAdministrativas
    {
        #region sigleton
        private static readonly LogDivisionesAdministrativas _instancia = new LogDivisionesAdministrativas();
        public static LogDivisionesAdministrativas Instancia
        {
            get { return _instancia; }
        }
        #endregion Singleton

        // Método para obtener los nombres
        public List<string> ObtenerNombres()
        {
            return DatDivisionesAdministrativas.Instancia.ObtenerNombres();
        }
        public int ObtenerCodigoDeArea(string nombre)
        {
            return DatDivisionesAdministrativas.Instancia.ObtenerCodigoDeArea(nombre);
        }
    }
}

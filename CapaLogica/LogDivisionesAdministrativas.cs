using CapaDatos;
using CapaEntidad;
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

        public List<EntDivisionesAdministrativas> ObtenerDivisionesAdministrativas()
        {
            return DatDivisionesAdministrativas.Instancia.ObtenerDivisionesAdministrativas();
        }

        public bool CambiarEstadoDivision(int id, bool nuevoEstado)
        {
            return DatDivisionesAdministrativas.Instancia.CambiarEstadoDivision(id, nuevoEstado);
        }

        public string ObtenerNombreDivisionPorId(int idDivision)
        {
            return DatDivisionesAdministrativas.Instancia.ObtenerNombreDivisionPorId(idDivision);
        }
    }
}

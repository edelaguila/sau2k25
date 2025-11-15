using Capa_Modelo_ActividadesARubrica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_ActividadesARubrica;

namespace Capa_Controlador_ActividadesARubrica
{
    public class controlador
    {

        private readonly sentencias sn = new sentencias();

        // ============================
        // GUARDAR (INSERT)
        // ============================
        public void guardarAsignacion(int idActividad, int idRubrica)
        {
            sn.insertarActividadRubrica(idActividad, idRubrica);
        }

        // ============================
        // ACTUALIZAR
        // ============================
        public void actualizarAsignacion(int id, int idActividad, int idRubrica)
        {
            sn.actualizarActividadRubrica(id, idActividad, idRubrica);
        }

        // ============================
        // ELIMINAR (ESTADO = 0)
        // ============================
        public void eliminarAsignacion(int id)
        {
            sn.eliminarActividadRubrica(id);
        }

        // ============================
        // BUSCAR POR ID
        // ============================
        public DataTable buscarAsignacion(int id)
        {
            return sn.obtenerAsignacionPorId(id);
        }

        // ============================
        // MOSTRAR TODAS LAS ASIGNACIONES
        // ============================
        public DataTable cargarAsignaciones()
        {
            return sn.obtenerAsignaciones();
        }

        // ============================
        // CARGAR ACTIVIDADES PARA COMBOBOX
        // ============================
        public DataTable cargarActividades()
        {
            return sn.obtenerActividades();
        }

        // ============================
        // CARGAR RUBRICAS PARA COMBOBOX
        // ============================
        public DataTable cargarRubricas()
        {
            return sn.obtenerRubricas();
        }

        // BUSCAR
        public DataTable buscarAsignacion(string texto)
        {
            return sn.buscarAsignacion(texto);
        }

    }
}

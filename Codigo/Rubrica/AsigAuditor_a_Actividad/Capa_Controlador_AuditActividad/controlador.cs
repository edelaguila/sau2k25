using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Modelo_AuditActividad;

namespace Capa_Controlador_AuditActividad
{
    public class controlador
    {
        private sentencias c_Sentencias;
        public controlador()
        {
            c_Sentencias = new sentencias();
        }

        // Llenar ComboBox
        public void cargarAsignaciones(ComboBox box)
        {
            DataTable dt = c_Sentencias.obtenerAsignaciones();
            box.DataSource = dt;
            box.SelectedIndex = -1;              // ninguno seleccionado al inicio
        }

        public object getNextId()
        {
            int nextId = c_Sentencias.getIdAsignacion();
            nextId++;
            return nextId.ToString();
        }

        public void cargarAuditores(ComboBox box)
        {
            DataTable dt = c_Sentencias.obtenerAuditores();
            box.DataSource = dt;
            box.DisplayMember = "nombre_auditor";  // nombre que se mostrará en el ComboBox
            box.ValueMember = "Pk_id_auditor";       // valor que se guardará
            box.SelectedIndex = -1;              // ninguno seleccionado al inicio
        }

        public void cargarEstado(ComboBox box)
        {
            DataTable dt = c_Sentencias.obtenerEstados();
            box.DataSource = dt;
            box.DisplayMember = "estado_asignacion";  // nombre que se mostrará en el ComboBox
            box.ValueMember = "Pk_id_estado_asignacion";       // valor que se guardará
            box.SelectedIndex = -1;              // ninguno seleccionado al inicio
        }

        public void cargarActividades(ComboBox box)
        {
            DataTable dt = c_Sentencias.obtenerActividades();
            box.DataSource = dt;
            box.DisplayMember = "nombre_actividad";  // nombre que se mostrará en el ComboBox
            box.ValueMember = "Pk_id_actividad_proyecto";       // valor que se guardará
            box.SelectedIndex = -1;              // ninguno seleccionado al inicio
        }

        public DataTable obtenerAsignaciones()
        {
            return c_Sentencias.obtenerAsignaciones();
        }

        public void guardar_movimientoAsignacion(int idAsignacion, int idAuditor, int idEstado, int idActividad, string nombreAsignacion, string descripcion)
        {
            c_Sentencias.registrarmovimientoAsignacion(idAsignacion, idAuditor, idEstado, idActividad, nombreAsignacion, descripcion);
        }

        public void modificar_movimientoAsignacion(int idAsignacion, int idAuditor, int idEstado, int idActividad, string nombreAsignacion, string descripcion)
        {
            c_Sentencias.modificarmovimientoAsignacion(idAsignacion, idAuditor, idEstado, idActividad, nombreAsignacion, descripcion);
        }

        public void eliminarAsignacion(int idAsignacion)
        {
            c_Sentencias.eliminarAsignacion(idAsignacion);
        }
    }
}

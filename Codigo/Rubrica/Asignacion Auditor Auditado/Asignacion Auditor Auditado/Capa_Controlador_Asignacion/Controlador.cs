using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_AsignacionAud;

namespace Capa_Controlador_Asignacion
{
    public class Controlador
    {
        private readonly Sentencia sn = new Sentencia();

        // Método para obtener proyectos activos
        public DataTable ObtenerProyectosActivos()
        {
            try
            {
                return sn.ObtenerProyectosActivos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en controlador al obtener proyectos: " + ex.Message);
            }
        }

        // Método para obtener auditores por proyecto
        public DataTable ObtenerAuditoresPorProyecto(int idProyecto)
        {
            try
            {
                return sn.ObtenerAuditoresPorProyecto(idProyecto);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en controlador al obtener auditores: " + ex.Message);
            }
        }

        // Método para obtener auditados por proyecto
        public DataTable ObtenerAuditadosPorProyecto(int idProyecto)
        {
            try
            {
                return sn.ObtenerAuditadosPorProyecto(idProyecto);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en controlador al obtener auditados: " + ex.Message);
            }
        }

        // Método para obtener actividades por proyecto
        public DataTable ObtenerActividadesPorProyecto(int idProyecto)
        {
            try
            {
                return sn.ObtenerActividadesPorProyecto(idProyecto);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en controlador al obtener actividades: " + ex.Message);
            }
        }

        // Método para insertar asignación
        public bool InsertarAsignacion(int idAuditor, int idAuditado, int idActividad, int idProyecto)
        {
            try
            {
                // Validar que todos los IDs sean válidos
                if (idAuditor <= 0 || idAuditado <= 0 || idActividad <= 0 || idProyecto <= 0)
                {
                    throw new Exception("Todos los campos son obligatorios");
                }
                return sn.InsertarAsignacion(idAuditor, idAuditado, idActividad, idProyecto);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en controlador al insertar asignación: " + ex.Message);
            }
        }

        // Método para obtener todas las asignaciones
        public DataTable ObtenerAsignaciones()
        {
            try
            {
                return sn.ObtenerAsignaciones();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en controlador al obtener asignaciones: " + ex.Message);
            }
        }
    }
}

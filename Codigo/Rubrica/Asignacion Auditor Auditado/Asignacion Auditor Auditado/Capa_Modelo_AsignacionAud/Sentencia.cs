using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Globalization;

namespace Capa_Modelo_AsignacionAud
{
    public class Sentencia
    {
        Conexion cn = new Conexion();

        // Método para obtener proyectos activos
        public DataTable ObtenerProyectosActivos()
        {
            DataTable dt = new DataTable();
            OdbcConnection conn = cn.conexion();
            try
            {
                string sql = "SELECT Pk_id_proyecto, nombre_proyecto FROM tbl_proyecto WHERE estado = 1 ORDER BY nombre_proyecto";
                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(dt);
            }
            catch (OdbcException ex)
            {
                throw new Exception("Error al obtener proyectos: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }
            return dt;
        }

        // Método para obtener auditores por proyecto
        public DataTable ObtenerAuditoresPorProyecto(int idProyecto)
        {
            DataTable dt = new DataTable();
            OdbcConnection conn = cn.conexion();
            try
            {
                string sql = "SELECT Pk_id_auditor, nombre_auditor FROM tbl_auditor WHERE Fk_id_proyecto = ? AND Estado = 'A' ORDER BY nombre_auditor";
                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.Add("?", OdbcType.Int).Value = idProyecto;
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (OdbcException ex)
            {
                throw new Exception("Error al obtener auditores: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }
            return dt;
        }

        // Método para obtener auditados por proyecto
        public DataTable ObtenerAuditadosPorProyecto(int idProyecto)
        {
            DataTable dt = new DataTable();
            OdbcConnection conn = cn.conexion();
            try
            {
                string sql = "SELECT Pk_id_auditado, nombre_auditado FROM tbl_auditados WHERE Fk_id_proyecto = ? AND estado = 1 ORDER BY nombre_auditado";
                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.Add("?", OdbcType.Int).Value = idProyecto;
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (OdbcException ex)
            {
                throw new Exception("Error al obtener auditados: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }
            return dt;
        }

        // Método para obtener actividades por proyecto
        public DataTable ObtenerActividadesPorProyecto(int idProyecto)
        {
            DataTable dt = new DataTable();
            OdbcConnection conn = cn.conexion();
            try
            {
                string sql = "SELECT Pk_id_actividad_proyecto, nombre_actividad FROM tbl_actividades_proyecto WHERE Fk_id_proyecto = ? AND estado = 1 ORDER BY nombre_actividad";
                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.Add("?", OdbcType.Int).Value = idProyecto;
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (OdbcException ex)
            {
                throw new Exception("Error al obtener actividades: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }
            return dt;
        }

        // Método para insertar asignación auditor-auditado
        public bool InsertarAsignacion(int idAuditor, int idAuditado, int idActividad, int idProyecto)
        {
            OdbcConnection conn = cn.conexion();
            bool resultado = false;
            try
            {
                string sql = "INSERT INTO tbl_asignacion_auditor_auditado (Fk_id_auditor, Fk_id_auditado, Fk_id_proyecto, Fk_id_actividad_proyecto, Fk_id_estado_asignacion, fecha_asignacion, estado) VALUES (?, ?, ?, ?, 1, CURRENT_TIMESTAMP, 1)";
                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.Add("?", OdbcType.Int).Value = idAuditor;
                cmd.Parameters.Add("?", OdbcType.Int).Value = idAuditado;
                cmd.Parameters.Add("?", OdbcType.Int).Value = idProyecto;
                cmd.Parameters.Add("?", OdbcType.Int).Value = idActividad;
                
                int filasAfectadas = cmd.ExecuteNonQuery();
                resultado = filasAfectadas > 0;
            }
            catch (OdbcException ex)
            {
                throw new Exception("Error al insertar asignación: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }
            return resultado;
        }

        // Método para obtener todas las asignaciones con información relacionada
        public DataTable ObtenerAsignaciones()
        {
            DataTable dt = new DataTable();
            OdbcConnection conn = cn.conexion();
            try
            {
                string sql = @"SELECT 
                    aaa.Pk_id_asignacion_auditor_auditado,
                    p.nombre_proyecto,
                    aud.nombre_auditor,
                    audt.nombre_auditado,
                    ap.nombre_actividad,
                    ea.estado_asignacion,
                    aaa.fecha_asignacion,
                    aaa.fecha_finalizacion,
                    aaa.observaciones
                FROM tbl_asignacion_auditor_auditado aaa
                INNER JOIN tbl_proyecto p ON aaa.Fk_id_proyecto = p.Pk_id_proyecto
                INNER JOIN tbl_auditor aud ON aaa.Fk_id_auditor = aud.Pk_id_auditor
                INNER JOIN tbl_auditados audt ON aaa.Fk_id_auditado = audt.Pk_id_auditado
                LEFT JOIN tbl_actividades_proyecto ap ON aaa.Fk_id_actividad_proyecto = ap.Pk_id_actividad_proyecto
                LEFT JOIN tbl_estado_asignacion ea ON aaa.Fk_id_estado_asignacion = ea.Pk_id_estado_asignacion
                WHERE aaa.estado = 1
                ORDER BY aaa.fecha_asignacion DESC";
                
                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(dt);
            }
            catch (OdbcException ex)
            {
                throw new Exception("Error al obtener asignaciones: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }
            return dt;
        }
    }
}

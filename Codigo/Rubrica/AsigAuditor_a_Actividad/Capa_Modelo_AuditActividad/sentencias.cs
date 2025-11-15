using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Modelo_AuditActividad
{
    public class sentencias
    {
        private conexion cn = new conexion();
        public DataTable obtenerAsignaciones()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection connection = cn.Conexion())
            {
                string query = @"SELECT a.Pk_id_asignacion, b.nombre_auditor, c.estado_asignacion,
                d.nombre_actividad, a.nombre_asignacion, a.fecha_asignacion, a.descripcion
                FROM tbl_asignacion a
                JOIN tbl_auditor b ON b.Pk_id_auditor = a.Fk_id_auditor
                JOIN tbl_estado_asignacion c ON c.Pk_id_estado_asignacion = a.Fk_id_estado_asignacion
                JOIN tbl_actividades_proyecto d ON d.Pk_id_actividad_proyecto = a.Fk_id_actividad_proyecto
                ORDER BY a.Pk_id_asignacion DESC";
                using (OdbcDataAdapter da = new OdbcDataAdapter(query, connection))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public int getIdAsignacion()
        {
            int idAsignacion = 0;
            string squery = "SELECT max(Pk_id_asignacion) FROM tbl_asignacion";
            try
            {
                using (OdbcCommand cmd = new OdbcCommand(squery, cn.Conexion()))
                {
                    idAsignacion = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nIniciando ingreso de registros de asignaciones.");
            }
            return idAsignacion;
        }

        public DataTable obtenerAuditores()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection connection = cn.Conexion())
            {
                string query = @"SELECT Pk_id_auditor, nombre_auditor, telefono_auditor, email_auditor, carnet_auditor, Estado, 
Fk_id_perfil_auditor, Fk_id_proyecto
                             FROM tbl_auditor";
                using (OdbcDataAdapter da = new OdbcDataAdapter(query, connection))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable obtenerEstados()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection connection = cn.Conexion())
            {
                string query = @"SELECT Pk_id_estado_asignacion, estado_asignacion
                             FROM tbl_estado_asignacion";
                using (OdbcDataAdapter da = new OdbcDataAdapter(query, connection))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable obtenerActividades()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection connection = cn.Conexion())
            {
                string query = @"SELECT Pk_id_actividad_proyecto, Fk_id_proyecto, nombre_actividad, descripcion
                             FROM tbl_actividades_proyecto";
                using (OdbcDataAdapter da = new OdbcDataAdapter(query, connection))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public void registrarmovimientoAsignacion(int idAsignacion, int idAuditor, int idEstado, int idActividad, string nombreAsignacion, string descripcion)
        {
            OdbcConnection connection = cn.Conexion();
            if (connection == null)
            {
                MessageBox.Show("No se pudo conectar a la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string query_guardar_movimientoAsignacion = @"INSERT INTO tbl_asignacion 
                (Pk_id_asignacion, Fk_id_auditor, Fk_id_estado_asignacion, Fk_id_actividad_proyecto,
                nombre_asignacion, fecha_asignacion, descripcion)
                VALUES
                (?, ?, ?, ?, ?, CURDATE(), ?)";
                OdbcCommand cmd = new OdbcCommand(query_guardar_movimientoAsignacion, connection);
                cmd.Parameters.AddWithValue("@Pk_id_asignacion", idAsignacion);
                cmd.Parameters.AddWithValue("@Fk_id_auditor", idAuditor);
                cmd.Parameters.AddWithValue("@Fk_id_estado_asignacion", idEstado);
                cmd.Parameters.AddWithValue("@Fk_id_actividad_proyecto", idActividad);
                cmd.Parameters.AddWithValue("@nombre_asignacion", nombreAsignacion);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar registrar la asignación" + ex.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { cn.Conexion(); }
        }

        public void modificarmovimientoAsignacion(int idAsignacion, int idAuditor, int idEstado, int idActividad, string nombreAsignacion, string descripcion)
        {
            OdbcConnection connection = cn.Conexion();
            if (connection == null)
            {
                MessageBox.Show("No se pudo conectar a la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string query_modificar_movimientoAsignacion = @"UPDATE tbl_asignacion 
                SET Fk_id_auditor = ?, Fk_id_estado_asignacion = ?, Fk_id_actividad_proyecto = ?,
                nombre_asignacion = ?, fecha_asignacion = CURDATE(), descripcion = ? WHERE Pk_id_asignacion = ?";
                OdbcCommand cmd = new OdbcCommand(query_modificar_movimientoAsignacion, connection);
                cmd.Parameters.AddWithValue("@Pk_id_asignacion", idAsignacion);
                cmd.Parameters.AddWithValue("@Fk_id_auditor", idAuditor);
                cmd.Parameters.AddWithValue("@Fk_id_estado_asignacion", idEstado);
                cmd.Parameters.AddWithValue("@Fk_id_actividad_proyecto", idActividad);
                cmd.Parameters.AddWithValue("@nombre_asignacion", nombreAsignacion);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar modificar la asignación" + ex.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { cn.Conexion(); }
        }

        public void eliminarAsignacion(int idAsignacion)
        {
            OdbcConnection connection = cn.Conexion();
            if (connection == null)
            {
                MessageBox.Show("No se pudo conectar a la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string query_eliminar_movimientoAsignacion = @"DELETE FROM tbl_asignacion WHERE Pk_id_asignacion = ?";
                using (OdbcCommand cmd = new OdbcCommand(query_eliminar_movimientoAsignacion, connection))
                {
                    cmd.Parameters.AddWithValue("", idAsignacion);

                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show("Asignación eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la asignación con el ID especificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar eliminar la asignación" + ex.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { cn.Conexion(); }
        }
    }
}

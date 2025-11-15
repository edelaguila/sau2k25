using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;


namespace Capa_Modelo_ActividadesARubrica
{
    public class sentencias
    {
            Conexion cn = new Conexion();

            // ============================
            // INSERTAR
            // ============================
            public void insertarActividadRubrica(int idActividad, int idRubrica)
            {
                try
                {
                    string sql = "INSERT INTO tbl_actividad_rubrica (fk_id_actividad_proyecto, fk_id_rubrica, estado) VALUES (?, ?, 1);";

                    using (OdbcConnection conn = cn.conexion())
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("fk_id_actividad_proyecto", idActividad);
                        cmd.Parameters.AddWithValue("fk_id_rubrica", idRubrica);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR EN INSERT: " + ex.Message);
                }
            }

            // ============================
            // ACTUALIZAR
            // ============================
            public void actualizarActividadRubrica(int id, int idActividad, int idRubrica)
            {
                try
                {
                    string sql = "UPDATE tbl_actividad_rubrica SET fk_id_actividad_proyecto = ?, fk_id_rubrica = ? WHERE pk_id_actividad_rubrica = ?;";

                    using (OdbcConnection conn = cn.conexion())
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("fk_id_actividad_proyecto", idActividad);
                        cmd.Parameters.AddWithValue("fk_id_rubrica", idRubrica);
                        cmd.Parameters.AddWithValue("pk_id_actividad_rubrica", id);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR EN UPDATE: " + ex.Message);
                }
            }

            // ============================
            // ELIMINAR (CAMBIO DE ESTADO)
            // ============================
            public void eliminarActividadRubrica(int id)
            {
                try
                {
                    string sql = "UPDATE tbl_actividad_rubrica SET estado = 0 WHERE pk_id_actividad_rubrica = ?;";

                    using (OdbcConnection conn = cn.conexion())
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("pk_id_actividad_rubrica", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR EN DELETE (ESTADO): " + ex.Message);
                }
            }

            // ============================
            // CONSULTAR POR ID
            // ============================
            public DataTable obtenerAsignacionPorId(int id)
            {
                DataTable dt = new DataTable();
                try
                {
                    string sql = @"SELECT pk_id_actividad_rubrica, fk_id_actividad_proyecto, fk_id_rubrica, estado
                               FROM tbl_actividad_rubrica
                               WHERE pk_id_actividad_rubrica = ?;";

                    using (OdbcConnection conn = cn.conexion())
                    using (OdbcDataAdapter da = new OdbcDataAdapter(sql, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("pk_id_actividad_rubrica", id);
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR SELECT POR ID: " + ex.Message);
                }

                return dt;
            }

            // ============================
            // CONSULTAR TODOS (JOIN)
            // ============================
            public DataTable obtenerAsignaciones()
            {
                DataTable dt = new DataTable();

                try
                {
                    string sql = @"
                SELECT 
                    ar.pk_id_actividad_rubrica AS ID,
                    ap.nombre_actividad AS Actividad,
                    r.nombre_rubrica AS Rubrica,
                    ar.estado AS Estado
                FROM tbl_actividad_rubrica ar
                INNER JOIN tbl_actividades_proyecto ap 
                    ON ar.fk_id_actividad_proyecto = ap.Pk_id_actividad_proyecto
                INNER JOIN tbl_rubrica r 
                    ON ar.fk_id_rubrica = r.Pk_id_rubrica
                WHERE ar.estado = 1;";

                    using (OdbcConnection conn = cn.conexion())
                    using (OdbcDataAdapter da = new OdbcDataAdapter(sql, conn))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR SELECT GENERAL: " + ex.Message);
                }

                return dt;
            }

            // ============================
            // OBTENER ACTIVIDADES COMBOBOX
            // ============================
            public DataTable obtenerActividades()
            {
                DataTable dt = new DataTable();

                try
                {
                    string sql = "SELECT Pk_id_actividad_proyecto, nombre_actividad FROM tbl_actividades_proyecto WHERE estado = 1;";

                    using (OdbcConnection conn = cn.conexion())
                    using (OdbcDataAdapter da = new OdbcDataAdapter(sql, conn))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR OBTENER ACTIVIDADES: " + ex.Message);
                }

                return dt;
            }

            // ============================
            // OBTENER RUBRICAS COMBOBOX
            // ============================
            public DataTable obtenerRubricas()
            {
                DataTable dt = new DataTable();

                try
                {
                    string sql = "SELECT Pk_id_rubrica, nombre_rubrica FROM tbl_rubrica WHERE estado = 1;";

                    using (OdbcConnection conn = cn.conexion())
                    using (OdbcDataAdapter da = new OdbcDataAdapter(sql, conn))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR OBTENER RUBRICAS: " + ex.Message);
                }

                return dt;
            }
        // ============================================================
        // BUSCAR ASIGNACIONES POR NOMBRE DE ACTIVIDAD O RÚBRICA
        // ============================================================
        public DataTable buscarAsignacion(string texto)
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = @"
        SELECT 
            ar.pk_id_actividad_rubrica AS ID,
            ap.nombre_actividad AS Actividad,
            r.nombre_rubrica AS Rubrica,
            ar.estado AS Estado
        FROM tbl_actividad_rubrica ar
        INNER JOIN tbl_actividades_proyecto ap 
            ON ar.fk_id_actividad_proyecto = ap.Pk_id_actividad_proyecto
        INNER JOIN tbl_rubrica r 
            ON ar.fk_id_rubrica = r.Pk_id_rubrica
        WHERE ar.estado = 1
        AND (
              ap.nombre_actividad LIKE ?
              OR r.nombre_rubrica LIKE ?
            );";

                using (OdbcConnection conn = cn.conexion())
                using (OdbcDataAdapter da = new OdbcDataAdapter(sql, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("param1", "%" + texto + "%");
                    da.SelectCommand.Parameters.AddWithValue("param2", "%" + texto + "%");

                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR EN BÚSQUEDA: " + ex.Message);
            }

            return dt;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Capa_Modelo_Cali_Act
{
    public class Sentencias
    {
        Conexion con = new Conexion();

        //////// 1) “obtener datos de una tabla”  ////////
        public OdbcDataAdapter llenarTbl(string sTabla)
        {
            string sSql = "SELECT * FROM " + sTabla + ";"; // usa nombre tal cual
            OdbcDataAdapter da = new OdbcDataAdapter(sSql, con.conexion());
            return da;
        }


        public OdbcDataAdapter llenarTblCalificacionActividadConNombre()
        {
            string sSql = @"
        SELECT 
            ps.pk_id_nota_actividad,
            ps.fk_auditado,
            ps.fk_auditor,
            ps.fk_actividad,
            p.nombre_auditado AS nombre_auditado,
            s.nombre_auditor AS nombre_auditor,
            t.nombre_actividad AS nombre_actividad,
            ps.nota
        FROM nota_actividad ps
        INNER JOIN tbl_auditados p ON ps.fk_auditado = p.pk_id_auditado
        INNER JOIN tbl_auditor s ON ps.fk_auditor = s.pk_id_auditor
        INNER JOIN tbl_actividades_proyecto t ON ps.fk_actividad = t.pk_id_actividad_proyecto;
    ";

            OdbcDataAdapter da = new OdbcDataAdapter(sSql, con.conexion());
            return da;
        }

        public OdbcDataAdapter LlenarCombo(string nombreTabla, string nombreColumna, string idColumna)
        {
            string sql = $"SELECT {idColumna}, {nombreColumna} FROM {nombreTabla};";
            OdbcDataAdapter da = new OdbcDataAdapter(sql, con.conexion());
            return da;
        }

        public int pro_insertar_nota_actividad(Cali_Act ps)
        {
            string sSql = @"INSERT INTO nota_actividad(fk_auditado, fk_auditor, fk_actividad, nota) VALUES(?, ?, ?, ?);";

            try
            {
                using (OdbcConnection cn = con.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sSql, cn))
                {
                    cmd.Parameters.Add("@fk_auditado", OdbcType.Int).Value = ps.iNombreAuditado;
                    cmd.Parameters.Add("@fk_auditor", OdbcType.Int).Value = ps.iNombreAuditor;
                    cmd.Parameters.Add("@fk_actividad", OdbcType.Int).Value = ps.iNombreActividad;
                    cmd.Parameters.Add("@nota", OdbcType.Int).Value = ps.iNotaActividad;

                    return cmd.ExecuteNonQuery(); // devuelve número de filas afectadas
                }
            }
            catch (OdbcException ex)
            {
                // Manejo de duplicados
                if (ex.Message.Contains("Duplicate entry"))
                {
                    MessageBox.Show(
                        "No se puede guardar: el auditado ya tiene nota.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show($"Error al insertar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return 0; // indica que no se insertó nada
            }
        }

        public int pro_actualizar_nota_actividad(Cali_Act ps)
        {
            string sSql = @"UPDATE nota_actividad
                    SET fk_auditado = ?, fk_auditado = ?, fk_actividad = ?, nota = ?
                    WHERE pk_id_nota_actividad = ?;";

            using (OdbcConnection cn = con.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sSql, cn))
            {
                // Orden de parámetros = orden de los '?'
                cmd.Parameters.Add("@fk_auditado", OdbcType.Int).Value = (int)ps.iNombreAuditado;
                cmd.Parameters.Add("@fk_auditor", OdbcType.Int).Value = (int)ps.iNombreAuditor;
                cmd.Parameters.Add("@fk_actividad", OdbcType.Int).Value = (int)ps.iNombreActividad;
                cmd.Parameters.Add("@nota", OdbcType.Int).Value = (int)ps.iNotaActividad;
                cmd.Parameters.Add("@id", OdbcType.Int).Value = ps.iId;

                return cmd.ExecuteNonQuery();
            }

        }

        public int pro_eliminar_nota_actividad(int iId)
        {
            string sSql = "DELETE FROM nota_actividad WHERE pk_id_nota_actividad = ?;";
            using (OdbcConnection cn = con.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sSql, cn))
            {
                cmd.Parameters.AddWithValue("@p1", iId);
                return cmd.ExecuteNonQuery();
            }
        }

        public OdbcDataAdapter fun_buscar_nota_actividad(string sTexto)
        {
            string sSql = $@"
    SELECT 
        ps.pk_id_nota_actividad,
        ps.fk_auditado,
        ps.fk_auditor,
        ps.fk_actividad,
        p.nombre_auditado AS nombre_auditado,
        s.nombre_auditor AS nombre_auditor,
        t.nombre_actividad AS nombre_actividad,
        ps.nota
    FROM nota_actividad ps
    INNER JOIN tbl_auditados p ON ps.fk_auditado = p.pk_id_auditado
    INNER JOIN tbl_auditor s ON ps.fk_auditor = s.pk_id_auditor
    INNER JOIN tbl_actividades_proyecto t ON ps.fk_actividad = t.pk_id_actividad_proyecto
    WHERE t.nombre_actividad LIKE '%{sTexto.Replace("'", "''")}%'
    ORDER BY t.nombre_actividad;
    ";

            return new OdbcDataAdapter(sSql, con.conexion());
        }



    }
}

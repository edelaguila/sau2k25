using System;
using System.Collections.Generic;
using System.Data.Odbc;

namespace Capa_Modelo
{
    public class Sentencias
    {
        conexion cn = new conexion();

        // ---------------------- OBTENER ASIGNACIONES -------------------------
        public OdbcDataAdapter ObtenerAsignaciones()
        {
            string query = @"SELECT 
                                a.Pk_id_auditado,
                                p.nombre_proyecto,
                                a.nombre_auditado,
                                a.cargo_o_area,
                                a.correo,
                                a.telefono,
                                a.observaciones
                             FROM tbl_auditados a
                             INNER JOIN tbl_proyecto p ON a.Fk_id_proyecto = p.Pk_id_proyecto";

            OdbcDataAdapter da = new OdbcDataAdapter(query, cn.conectar());
            return da;
        }

        // ---------------------- OBTENER PROYECTOS -------------------------
        public List<string[]> ObtenerProyectos()
        {
            List<string[]> lista = new List<string[]>();
            string query = "SELECT Pk_id_proyecto, nombre_proyecto FROM tbl_proyecto";

            OdbcConnection con = cn.conectar();
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new string[]
                {
                    reader["Pk_id_proyecto"].ToString(),
                    reader["nombre_proyecto"].ToString()
                });
            }

            reader.Close();
            con.Close();

            return lista;
        }

        // ---------------------- INSERTAR -------------------------
        public int InsertarAuditado(int proyecto, string nombre, string cargo, string correo, string tel, string obs)
        {
            string query = @"INSERT INTO tbl_auditados
                            (Fk_id_proyecto, nombre_auditado, cargo_o_area, correo, telefono, observaciones)
                            VALUES (?,?,?,?,?,?)";

            OdbcConnection con = cn.conectar();
            OdbcCommand cmd = new OdbcCommand(query, con);

            cmd.Parameters.Add("@proyecto", OdbcType.Int).Value = proyecto;
            cmd.Parameters.Add("@nombre", OdbcType.VarChar).Value = nombre;
            cmd.Parameters.Add("@cargo", OdbcType.VarChar).Value = cargo;
            cmd.Parameters.Add("@correo", OdbcType.VarChar).Value = correo;
            cmd.Parameters.Add("@tel", OdbcType.VarChar).Value = tel;
            cmd.Parameters.Add("@obs", OdbcType.Text).Value = obs;

            int result = cmd.ExecuteNonQuery();
            con.Close();

            return result;
        }

        // ---------------------- ELIMINAR -------------------------
        public int EliminarAuditado(int id)
        {
            string query = "DELETE FROM tbl_auditados WHERE Pk_id_auditado = ?";

            OdbcConnection con = cn.conectar();
            OdbcCommand cmd = new OdbcCommand(query, con);
            cmd.Parameters.Add("@id", OdbcType.Int).Value = id;

            int result = cmd.ExecuteNonQuery();
            con.Close();

            return result;
        }

        // ---------------------- EDITAR -------------------------
        public int EditarAuditado(int id, int proyecto, string nombre, string cargo, string correo, string tel, string obs)
        {
            string query = @"UPDATE tbl_auditados 
                             SET Fk_id_proyecto=?, nombre_auditado=?, cargo_o_area=?, 
                                 correo=?, telefono=?, observaciones=?
                             WHERE Pk_id_auditado=?";

            OdbcConnection con = cn.conectar();
            OdbcCommand cmd = new OdbcCommand(query, con);

            cmd.Parameters.Add("@proyecto", OdbcType.Int).Value = proyecto;
            cmd.Parameters.Add("@nombre", OdbcType.VarChar).Value = nombre;
            cmd.Parameters.Add("@cargo", OdbcType.VarChar).Value = cargo;
            cmd.Parameters.Add("@correo", OdbcType.VarChar).Value = correo;
            cmd.Parameters.Add("@tel", OdbcType.VarChar).Value = tel;
            cmd.Parameters.Add("@obs", OdbcType.Text).Value = obs;
            cmd.Parameters.Add("@id", OdbcType.Int).Value = id;

            int result = cmd.ExecuteNonQuery();
            con.Close();

            return result;
        }
    }
}

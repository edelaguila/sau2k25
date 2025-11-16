using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo;

namespace Capa_Controlador
{
    public class Logica
    {
        Sentencias sent = new Sentencias();

        public DataTable CargarAsignaciones()
        {
            OdbcDataAdapter da = sent.ObtenerAsignaciones();
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public List<string[]> ObtenerProyectos()
        {
            return sent.ObtenerProyectos();
        }

        public bool Insertar(int proyecto, string nombre, string cargo, string correo, string tel, string obs)
        {
            return sent.InsertarAuditado(proyecto, nombre, cargo, correo, tel, obs) > 0;
        }

        public bool Editar(int id, int proyecto, string nombre, string cargo, string correo, string tel, string obs)
        {
            return sent.EditarAuditado(id, proyecto, nombre, cargo, correo, tel, obs) > 0;
        }

        public bool Eliminar(int id)
        {
            return sent.EliminarAuditado(id) > 0;
        }
    }
}

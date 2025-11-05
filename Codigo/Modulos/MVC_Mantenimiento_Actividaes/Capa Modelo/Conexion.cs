using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo
{
    public class Conexion
    {
        // Método para abrir la conexión ODBC con el origen de datos "Auditoria"
        public OdbcConnection conexion()
        {
            OdbcConnection conexion = new OdbcConnection("Dsn=Auditoria");

            try
            {
                conexion.Open();
                Console.WriteLine("Conexión establecida correctamente.");
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("No se pudo establecer conexión con la base de datos: " + ex.Message);
            }

            return conexion;
        }

        // Método para cerrar la conexión
        public void desconexion(OdbcConnection conexion)
        {
            try
            {
                conexion.Close();
                Console.WriteLine("Conexión cerrada correctamente.");
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }
}

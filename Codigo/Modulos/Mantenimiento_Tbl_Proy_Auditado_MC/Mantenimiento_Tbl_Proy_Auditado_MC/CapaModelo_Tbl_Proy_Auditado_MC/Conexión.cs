using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaModelo_Tbl_Proy_Auditado_MC
{
    public class Conexion
    {
        public OdbcConnection conexion()
        {
            OdbcConnection conexion = new OdbcConnection("Dsn = Auditoria");

            try
            {
                conexion.Open();
                //return conectar;
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se pudo establecer conexión con la base de datos");
                //return null;
            }
            return conexion;
        }


        public void desconexion(OdbcConnection conexion)
        {
            try
            {
                conexion.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se pudo conectar");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_AuditActividad
{
    public class conexion
    {
        public OdbcConnection Conexion()
        {
            OdbcConnection conexion = new OdbcConnection("Dsn=Auditoria");
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (OdbcException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}

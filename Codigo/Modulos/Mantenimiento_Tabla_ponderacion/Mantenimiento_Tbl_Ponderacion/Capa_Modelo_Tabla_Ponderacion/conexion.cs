﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
namespace Capa_Modelo_Tabla_Ponderacion
{
    public class conexion
    {
        public OdbcConnection conectar()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=Auditoria");

            try
            {
                conectar.Open();
                return conectar;
            }
            catch (OdbcException ex)
            {

                Console.WriteLine("No conecto la Base de Datos ", ex);
                return null;
            }
        }
    }
}

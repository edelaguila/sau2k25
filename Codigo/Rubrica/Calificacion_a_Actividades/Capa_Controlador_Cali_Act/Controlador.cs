using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Cali_Act;
using System.Data.Odbc;
using System.Data;

namespace Capa_Controlador_Cali_Act
{
    public class Controlador
    {
        private readonly Sentencias sn = new Sentencias();
        public DataTable llenarTbl(string sTabla)
        {
            OdbcDataAdapter da = sn.llenarTbl(sTabla);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable obtenerCalificacionActividadConNombre()
        {
            OdbcDataAdapter da = sn.llenarTblCalificacionActividadConNombre();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable pro_LlenarCombo(string nombreTabla, string nombreColumna, string idColumna)
        {
            DataTable dt = new DataTable();
            sn.LlenarCombo(nombreTabla, nombreColumna, idColumna).Fill(dt);
            return dt;
        }

        public bool pro_guardar(Cali_Act p) => fun_validar(p) && sn.pro_insertar_nota_actividad(p) > 0;
        public bool pro_actualizar(Cali_Act p) => p.iId > 0 && fun_validar(p) && sn.pro_actualizar_nota_actividad(p) > 0;
        public bool pro_eliminar(int iId) => iId > 0 && sn.pro_eliminar_nota_actividad(iId) > 0;
        private bool fun_validar(Cali_Act p)
        {
            if (p.iNombreActividad == 0) return false;
            return true;
        }

        public DataTable fun_buscar_nota_actividad(string sTexto)
        {
            var da = sn.fun_buscar_nota_actividad(sTexto ?? "");
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

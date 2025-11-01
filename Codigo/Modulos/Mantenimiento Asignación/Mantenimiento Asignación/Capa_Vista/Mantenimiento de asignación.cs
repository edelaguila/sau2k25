using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista
{
    public partial class Mantenimiento_de_asignación : Form
    {
        string idUsuario;

        public Mantenimiento_de_asignación()
        {
            InitializeComponent();
            string[] alias = { "Pk_id_asignacion", "Fk_id_auditor", "Fk_id_estado_asignacion", "Fk_id_actividad_proyecto", "nombre_asignacion", "fecha_asignacion", "fecha_finalizacion", "descripcion", "evidencia", "observaciones", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#B4D2F0"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("tbl_asignacion");
            navegador1.ObtenerIdAplicacion("10009");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("");
            navegador1.AsignarComboConTabla("tbl_auditor", "Pk_id_auditor", "Fk_id_auditor", 1);
            navegador1.AsignarComboConTabla("tbl_estado_asignacion", "Pk_id_estado_asignacion", "Fk_id_estado_asignacion", 2);
            navegador1.AsignarComboConTabla("tbl_actividades_proyecto", "Pk_id_actividad_proyecto", "Fk_id_actividad_proyecto", 3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Tabla_Ponderacion
{
    public partial class Frm_Mantenimiento_Tabla_Ponderacion : Form
    {

        String idUsuario;
        public Frm_Mantenimiento_Tabla_Ponderacion()
        {
            InitializeComponent();

            //   string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            // Prueba con la tabla inicial/
            string[] alias = { "Pk_id_ponderacion", "Fk_id_auditado ", "Fk_id_cronograma", " Fk_id_rubrica", "Fk_id_criterio", " Fk_id_escala", "calificacion_porcentaje", "calificacion_ponderada", "comentarios_auditor", "fecha_evaluacion", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#B4D2F0"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("tbl_tabla_ponderacion");
            navegador1.ObtenerIdAplicacion("10006"); // codigo de tabla ponderacion
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Tabla Ponderación");

            //navegador1.AsignarComboConTabla("tbl_auditado", "Pk_id_auditado", "Fk_id_auditado", 1);
                
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}

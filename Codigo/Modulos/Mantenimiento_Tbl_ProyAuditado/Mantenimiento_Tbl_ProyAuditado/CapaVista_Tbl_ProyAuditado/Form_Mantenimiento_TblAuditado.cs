using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Tbl_ProyAuditado
{
    public partial class Form_Mantenimiento_TblAuditado : Form
    {
        String idUsuario;
        public Form_Mantenimiento_TblAuditado()
        {
            InitializeComponent();
            string[] alias =
           {
                "Pk_id_auditor_proyecto",
                "Fk_id_auditor",
                "Fk_id_proyecto",
                "rol_en_proyecto",
                "fecha_asignacion",
                "observaciones",
                "estado"
            };

            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#9FA8DA"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.ObtenerIdAplicacion("10004"); // Codigo de la Tbl_Proyecto_Auditado 10004
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1"); // ID de ayuda
            navegador1.AsignarTabla("tbl_proyecto_auditado");
            navegador1.AsignarNombreForm("Tabla Proyecto Auditado");

            //navegador1.AsignarComboConTabla("tbl_proyecto", "Pk_id_proyecto", "Fk_id_proyecto", 1);
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
        }
    }
}

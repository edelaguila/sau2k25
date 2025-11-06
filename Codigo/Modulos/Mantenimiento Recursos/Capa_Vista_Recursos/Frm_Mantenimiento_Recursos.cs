using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Recursos
{
    public partial class Frm_Mantenimiento_Recursos : Form
    {
        string idUsuario;
        public Frm_Mantenimiento_Recursos(string idUsuario)
        {
            InitializeComponent(); 

            string[] alias = { "Pk_id_recurso", "Fk_id_proyecto", "nombre_recurso", "tipo_recurso", "cantidad", "fecha_registro", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#B4D2F0"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("tbl_recursos");
            navegador1.ObtenerIdAplicacion("10008");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("");

            navegador1.AsignarComboConTabla("tbl_proyecto", "Pk_id_proyecto", "Fk_id_proyecto", 1);
        }
    }
}

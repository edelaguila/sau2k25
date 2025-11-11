using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoProyecto
{
    public partial class Frm_Proyecto : Form
    {
        public Frm_Proyecto(string idUsuario)
        {
            InitializeComponent();
            string[] alias = { "Pk_id_proyecto", "nombre_proyecto", "descripcion", "fecha_inicio", "fecha_fin",
                "objetivo" , "estado", "Fk_id_proyecto_estado"};
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.ObtenerIdAplicacion("10002");
            //navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarTabla("tbl_proyecto");
            navegador1.AsignarNombreForm("10002 Mantenimiento Proyecto");

            navegador1.AsignarComboConTabla("tbl_proyecto_estado", "Pk_id_proyecto_estado", "nombre_estado", 1);
            //navegador1.AsignarComboConTabla("tbl****", "Pk_id_****", "*****", 1);
            ///**************************************************/

            ///************Se muestre en el dgv los nombres y no los numeros*******/

            navegador1.AsignarForaneas("tbl_proyecto_estado", "nombre_estado", "Fk_id_proyecto_estado", "Pk_id_proyecto_estado");
            //navegador1.AsignarForaneas("tbl_proyecto", "nombre_proyecto", "Fk_id_proyecto", "Pk_id_proyecto");
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_Load_1(object sender, EventArgs e)
        {

        }

        private void navegador2_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Auditados : Form
    {
        public Auditados(string idUsuario)
        {
            InitializeComponent();

            string[] alias = {
            "Pk_id_auditado",
            "Fk_id_proyecto",
            "nombre_auditado",
            "cargo_o_area",
            "correo",
            "telefono",
            "observaciones",
            "estado"
    };

            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.ObtenerIdAplicacion("10005");
            navegador1.ObtenerIdUsuario(idUsuario);

            navegador1.AsignarTabla("tbl_auditados");
            navegador1.AsignarNombreForm("Mantenimiento de Auditados");

            navegador1.AsignarComboConTabla("tbl_proyecto", "Pk_id_proyecto", "nombre_proyecto", 1);
        }
    }
}

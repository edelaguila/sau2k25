using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjecucionNav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string idUsuario = "admin";
            /// Marco Alejandro Monroy*/
            /*Prueba con navegador*/
            string[] alias = { "pk_registro_horas", "horas_mes", "horas_cantidad_horas", "fk_clave_empleado", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#B4D2F0"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("tbl_horas_extra");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("AyudaAsistencia");
            navegador1.AsignarReporte("empleados"); /*Nuevo*/
            navegador1.AsignarNombreForm("Horas Extra");
        }
    }
}

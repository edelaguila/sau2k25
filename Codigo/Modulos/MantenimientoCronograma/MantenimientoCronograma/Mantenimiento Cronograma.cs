using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoCronograma
{
    public partial class Mantenimiento_Cronograma : Form
    {
        public Mantenimiento_Cronograma(string idUsuario)
        {
            InitializeComponent();

            // 🔹 Alias: deben coincidir exactamente con los nombres de los TextBox o ComboBox del formulario
            string[] alias = {
    "Pk_id_cronograma",
    "Fk_id_planificacion",
    "Fk_id_actividad_proyecto",
    "nombre_tarea",
    "descripcion",
    "fecha_inicio",
    "fecha_fin",
    "responsable_tarea",
    "estado_tarea",
    "observaciones",
    "estado"
};

            
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.ObtenerIdAplicacion("10003");
            navegador1.ObtenerIdUsuario(idUsuario);

            
            navegador1.AsignarTabla("tbl_cronograma");
            navegador1.AsignarNombreForm("Mantenimiento de Cronograma");

            navegador1.AsignarComboConTabla("tbl_planificacion", "Pk_id_planificacion", "nombre_plan", 1);
            navegador1.AsignarComboConTabla("tbl_actividades_proyecto", "Pk_id_actividad_proyecto", "nombre_actividad", 1);

            

            

        }
    }
}

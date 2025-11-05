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
        public partial class Mantenimiento_Actividades : Form
        {
            string idUsuario;

            public Mantenimiento_Actividades()
            {
                InitializeComponent();

                // Alias de los campos según la estructura de la tabla
                string[] alias =
                {
                "Pk_id_actividad_proyecto",
                "Fk_id_proyecto",
                "nombre_actividad",
                "descripcion",
                "observaciones",
                "estado"
            };

                // Configuración del navegador
                navegador1.AsignarAlias(alias);
                navegador1.AsignarSalida(this);
                navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#AED581")); // verde claro, puedes cambiar el color
                navegador1.AsignarColorFuente(Color.Black);

                // Identificadores del formulario y ayuda
                navegador1.ObtenerIdAplicacion("10007"); // Código interno para esta tabla
                navegador1.ObtenerIdUsuario(idUsuario);
                navegador1.AsignarAyuda("1"); // ID de ayuda (puedes cambiarlo si usas otro)
                navegador1.AsignarTabla("tbl_actividades_proyecto");
                navegador1.AsignarNombreForm("Mantenimiento de Actividades del Proyecto");

                // Relación con la tabla de proyectos (FK)
                //navegador1.AsignarComboConTabla("tbl_proyecto", "Pk_id_proyecto", "Fk_id_proyecto", 1);
            }

            private void navegador1_Load(object sender, EventArgs e)
            {
                // Aquí puedes cargar configuraciones adicionales al iniciar el formulario si es necesario
            }
        }
    }


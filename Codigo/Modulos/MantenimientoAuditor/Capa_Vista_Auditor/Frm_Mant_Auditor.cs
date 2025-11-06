using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Auditor
{
    public partial class Frm_Mant_Auditor : Form
    {
        public Frm_Mant_Auditor(string idUsuario)
        {
            InitializeComponent();

            //            / Prueba con tabla creada por mi /
            /// El primero campo debe ser auto incremental not null */
            /// Debe ir siempre el campo de estaod con 1 predeterminamdamente */
            //string[] alias = { "id", "nombre", "genero", "estado" };
            //navegador1.AsignarAlias(alias);
            //navegador1.AsignarSalida(this);
            //navegador1.AsignarColorFondo(Color.CadetBlue);
            //navegador1.AsignarColorFuente(Color.Black);
            //navegador1.AsignarTabla("Videojuegos");
            //navegador1.ObtenerIdAplicacion("3000");
            //navegador1.ObtenerIdUsuario(idUsuario);
            //navegador1.AsignarAyuda("1");
            //navegador1.AsignarNombreForm("Videojuegos");
            /*/


            ///**Con tabla que tenga comboboxs foraneas **********/
            string[] alias = {
                "Pk_id_auditor", "nombre_auditor", "telefono_auditor", "email_auditor", "carnet_auditor",
                "estado" ,"Fk_id_perfil_auditor","Fk_id_proyecto"};
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.ObtenerIdAplicacion("10001");
            //navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarTabla("tbl_auditor");

            ///*Valores foraneos en Combobox*/
            ///

            /*Table: tbl_perfil_auditor
    Columns:
    Pk_id_perfil_auditor int PK
    nombre_perfil varchar(50) 
    descripcion_perfil text
    estado tinyint(1)*/

            /*Table: tbl_proyecto
Columns:
Pk_id_proyecto int PK 
Fk_id_proyecto_estado int 
nombre_proyecto varchar(100) 
descripcion text 
fecha_inicio date 
fecha_fin date 
objetivo text 
estado tinyint(1)*/

            navegador1.AsignarComboConTabla("tbl_perfil_auditor", "Pk_id_perfil_auditor", "nombre_perfil", 1);
            navegador1.AsignarComboConTabla("tbl_proyecto", "Pk_id_proyecto", "nombre_proyecto", 1);
            ////

            ///*Se muestre en el dgv los nombres y no los numeros/

            navegador1.AsignarForaneas("tbl_perfil_auditor", "nombre_perfil", "Fk_id_perfil_auditor", "Pk_id_perfil_auditor");
            navegador1.AsignarForaneas("tbl_proyecto", "nombre_proyecto", "Fk_id_proyecto", "Pk_id_proyecto");

            ///*/

        }
    }
}

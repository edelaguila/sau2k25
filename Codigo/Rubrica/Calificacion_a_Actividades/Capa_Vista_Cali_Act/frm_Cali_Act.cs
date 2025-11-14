using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Modelo_Cali_Act;
using Capa_Controlador_Cali_Act;
using System.Data.Odbc;

namespace Capa_Vista_Cali_Act
{
    public partial class frm_Cali_Act : Form
    {
        Controlador cn = new Controlador();
        private readonly string sTabla = "nota_actividad";
        private readonly ToolTip toolTip1 = new ToolTip(); // NUEVO
        public frm_Cali_Act()
        {

            InitializeComponent();
            fun_limpiar();
            Txt_Id.Enabled = false;
            // Tabla
            Dgv_CaliAct.AutoGenerateColumns = true;
            Dgv_CaliAct.ReadOnly = true;
            Dgv_CaliAct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Eventos de validación de entrada
            Txt_Buscar.KeyPress += Txt_Buscar_KeyPress_SoloLetras;
            Cmb_Auditado.KeyPress += Txt_Buscar_KeyPress_SoloLetras;

            // Eventos de tabla
            Dgv_CaliAct.CellClick += Dgv_CaliAct_CellClick;

            // NUEVO: cuando el cuadro de búsqueda queda vacío, recargar todo
            Txt_Buscar.TextChanged += Txt_Buscar_TextChanged;

            // NUEVO: ToolTips de botones (se pueden mover al Load si prefieres)
            toolTip1.SetToolTip(Btn_Nuevo, "Preparar formulario para una nueva calificación");
            toolTip1.SetToolTip(Btn_Guardar, "Guardar una calificación nueva");
            toolTip1.SetToolTip(Btn_Editar, "Modificar la nota seleccionada");
            toolTip1.SetToolTip(Btn_Buscar, "Buscar calificación");
            toolTip1.SetToolTip(Btn_Eliminar, "Eliminar el calificación");
            toolTip1.SetToolTip(Btn_Cancelar, "Cancelar operación y limpiar formulario");

            CargarCombos();
        }

        private void CargarCombos()
        {
            try
            {
                // Cargar ComboBox 
                Cmb_Auditado.DataSource = cn.pro_LlenarCombo("tbl_auditados", "nombre_auditado", "pk_id_auditado");
                Cmb_Auditado.DisplayMember = "nombre_auditado";
                Cmb_Auditado.ValueMember = "pk_id_auditado";
                Cmb_Auditado.SelectedIndex = -1;

                // Cargar ComboBox 
                Cmb_Auditor.DataSource = cn.pro_LlenarCombo("tbl_auditor", "nombre_auditor", "pk_id_auditor");
                Cmb_Auditor.DisplayMember = "nombre_auditor";
                Cmb_Auditor.ValueMember = "pk_id_auditor";
                Cmb_Auditor.SelectedIndex = -1;

                // Cargar ComboBox 
                Cmb_Actividad.DataSource = cn.pro_LlenarCombo("tbl_actividades_proyecto", "nombre_actividad", "pk_id_actividad_proyecto");
                Cmb_Actividad.DisplayMember = "nombre_actividad";
                Cmb_Actividad.ValueMember = "pk_id_actividad_proyecto";
                Cmb_Actividad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los ComboBox:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Solo números enteros para sesiones
        private void Txt_Sesiones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return; // Permitir backspace, delete, etc.

            if (!char.IsDigit(e.KeyChar))
                e.Handled = true; // Bloquear todo excepto números
        }


        private void Txt_Buscar_KeyPress_SoloLetras(object sender, KeyPressEventArgs e)
        {
            bool esControl = char.IsControl(e.KeyChar);
            bool esLetra = char.IsLetter(e.KeyChar);
            bool esEspacio = char.IsWhiteSpace(e.KeyChar);

            if (!(esControl || esLetra || esEspacio))
                e.Handled = true; // bloquea números, símbolos, etc.
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            // NUEVO: si se limpia el texto, restaurar todos los registros
            if (string.IsNullOrWhiteSpace(Txt_Buscar.Text))
            {
                actualizardatagriew();
            }
        }

        private void Dgv_CaliAct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || Dgv_CaliAct.CurrentRow == null) return;

            var r = Dgv_CaliAct.Rows[e.RowIndex];

            Txt_Id.Text = Convert.ToString(r.Cells["pk_id_nota_actividad"].Value);
            Cmb_Auditado.Text = Convert.ToString(r.Cells["fk_auditado"].Value);
            Cmb_Auditor.Text = Convert.ToString(r.Cells["fk_auditor"].Value);
            Cmb_Actividad.Text = Convert.ToString(r.Cells["fk_actividad"].Value);
            Txt_Nota.Text = Convert.ToString(r.Cells["fk_actividad"].Value);

            // Pasa a modo edición (habilita Actualizar/Eliminar y deshabilita Guardar)
            fun_estado_edicion(true);
        }

        private void fun_estado_edicion(bool bActivo)
        {
            Cmb_Auditado.Enabled = bActivo;
            Cmb_Auditor.Enabled = bActivo;
            Cmb_Actividad.Enabled = bActivo;
            Txt_Nota.Enabled = bActivo;

            // Botones según modo
            Btn_Guardar.Enabled = bActivo && string.IsNullOrWhiteSpace(Txt_Id.Text);
            Btn_Editar.Enabled = bActivo && !string.IsNullOrWhiteSpace(Txt_Id.Text);
            Btn_Eliminar.Enabled = bActivo && !string.IsNullOrWhiteSpace(Txt_Id.Text);
        }

        public void actualizardatagriew()
        {
            try
            {
                // ✅ Usar el método correcto que incluye las columnas FK
                DataTable dt = cn.obtenerCalificacionActividadConNombre();
                Dgv_CaliAct.DataSource = dt;

                // ✅ Verificar que las columnas existen antes de configurarlas
                if (Dgv_CaliAct.Columns.Contains("pk_id_nota_actividad"))
                    Dgv_CaliAct.Columns["pk_id_nota_actividad"].Visible = false;

                if (Dgv_CaliAct.Columns.Contains("fk_auditado"))
                    Dgv_CaliAct.Columns["fk_auditado"].Visible = false;

                if (Dgv_CaliAct.Columns.Contains("fk_auditor"))
                    Dgv_CaliAct.Columns["fk_auditor"].Visible = false;

                if (Dgv_CaliAct.Columns.Contains("fk_actividad"))
                    Dgv_CaliAct.Columns["fk_actividad"].Visible = false;

                if (Dgv_CaliAct.Columns.Contains("nota"))
                    Dgv_CaliAct.Columns["nota"].Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fun_limpiar()
        {
            Txt_Id.Clear();
            Cmb_Auditado.SelectedIndex = -1;
            Cmb_Auditor.SelectedIndex = -1;
            Cmb_Actividad.SelectedIndex = -1;
            Txt_Nota.Clear();

            // Regresa a modo lectura
            fun_estado_edicion(false);

            // NUEVO: al limpiar, también reiniciamos la grilla completa
            actualizardatagriew();
        }

        //------------------------------------BOTONES-------------------------------------

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            fun_limpiar();
            fun_estado_edicion(true);
            Cmb_Auditado.Focus();
        }

         // ✅ MEJORADO: Validaciones completas
        private bool fun_validar_obligatorios()
        {
            // 1. Validar que se seleccionó un auditado
            if (Cmb_Auditado.SelectedValue == null ||
                string.IsNullOrWhiteSpace(Cmb_Auditado.Text))
            {
                MessageBox.Show("Debe seleccionar un Auditado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cmb_Auditado.Focus();
                return false;
            }

            // 2. Validar que el ID del auditado sea válido
            int idAuditado;
            if (!int.TryParse(Cmb_Auditado.SelectedValue.ToString(), out idAuditado) || idAuditado <= 0)
            {
                MessageBox.Show("El auditado no es valido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cmb_Auditado.Focus();
                return false;
            }

            // 3. Validar que se seleccionó un auditor
            if (Cmb_Auditor.SelectedValue == null ||
                string.IsNullOrWhiteSpace(Cmb_Auditor.Text))
            {
                MessageBox.Show("Debe seleccionar un auditor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cmb_Auditor.Focus();
                return false;
            }

            // 4. Validar que el ID del auditor sea válido
            int idAuditor;
            if (!int.TryParse(Cmb_Auditor.SelectedValue.ToString(), out idAuditor) || idAuditor <= 0)
            {
                MessageBox.Show("El auditor seleccionado no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cmb_Auditor.Focus();
                return false;
            }

              // 5. Validar que se seleccionó una actividad
            if (Cmb_Actividad.SelectedValue == null ||
                string.IsNullOrWhiteSpace(Cmb_Actividad.Text))
            {
                MessageBox.Show("Debe seleccionar una actividad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cmb_Actividad.Focus();
                return false;
            }

            // 6. Validar que el ID del auditor sea válido
            int idActividad;
            if (!int.TryParse(Cmb_Actividad.SelectedValue.ToString(), out idActividad) || idActividad <= 0)
            {
                MessageBox.Show("La actividad seleccionado no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cmb_Actividad.Focus();
                return false;
            }

            // 7. Validar ntoa no vacío
            if (string.IsNullOrWhiteSpace(Txt_Nota.Text))
            {
                MessageBox.Show("La nota es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Nota.Focus();
                return false;
            }

            // 8. Validar que la nota sea entero válido
            int nota;
            if (!int.TryParse(Txt_Nota.Text.Trim(), out nota))
            {
                MessageBox.Show("La nota debe ser un número entero (ejemplo: 1, 2, 3...).",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Nota.Focus();
                Txt_Nota.SelectAll();
                return false;
            }

            // 9. Validar que nota sea positivo
            if (nota <= 0)
            {
                MessageBox.Show("La nota debe ser mayor a 0.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Nota.Focus();
                Txt_Nota.SelectAll();
                return false;
            }

            // 8. Validar que la nota no sea excesivo
            if (nota > 100)
            {
                MessageBox.Show("La nota no puede ser mayor a 100.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Nota.Focus();
                Txt_Nota.SelectAll();
                return false;
            }

            return true;
        }

        private Cali_Act fun_capturar()
        {
            try
            {
                return new Cali_Act
                {
                    iId = string.IsNullOrWhiteSpace(Txt_Id.Text)
                           ? 0
                           : int.Parse(Txt_Id.Text),

                    iNombreAuditado = Cmb_Auditado.SelectedValue == null
                           ? 0
                           : Convert.ToInt32(Cmb_Auditado.SelectedValue),

                    iNombreAuditor = Cmb_Auditor.SelectedValue == null
                           ? 0
                           : Convert.ToInt32(Cmb_Auditor.SelectedValue),

                    iNombreActividad = Cmb_Actividad.SelectedValue == null
                           ? 0
                           : Convert.ToInt32(Cmb_Actividad.SelectedValue),

                    iNotaActividad = string.IsNullOrWhiteSpace(Txt_Nota.Text)
                           ? 0
                           : int.Parse(Txt_Nota.Text.Trim())
                };
            }
            catch (FormatException)
            {
                MessageBox.Show("Error al capturar los datos. Verifica que la nota sea válida.",
                    "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Error al capturar los datos de los ComboBox. Asegúrate de seleccionar valores válidos.",
                    "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al capturar datos:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private bool fun_busqueda_valida()
        {
            string s = Txt_Buscar.Text.Trim();
            if (string.IsNullOrWhiteSpace(s))
            {
                MessageBox.Show("Ingresa un nombre para buscar.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_Buscar.Focus();
                return false;
            }

            // Verifica que todos los caracteres sean letras o espacios
            foreach (char c in s)
            {
                if (!(char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("La búsqueda solo admite letras y espacios.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txt_Buscar.Focus();
                    return false;
                }
            }
            return true;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

            try
            {
                // Validación estricta
                if (!fun_validar_obligatorios())
                    return;

                // Capturar datos
                var ps = fun_capturar();

                // Verificar captura exitosa
                if (ps == null)
                {
                    MessageBox.Show("No se pudieron capturar los datos correctamente.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Guardar
                if (cn.pro_guardar(ps))
                {
                    MessageBox.Show("Nota asignada correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizardatagriew();
                    fun_limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la asignación de nota. Verifica los datos.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (OdbcException ex)
            {
                if (ex.Message.Contains("Duplicate entry") || ex.Message.Contains("duplicate key"))
                {
                    MessageBox.Show("Esta actividad ya está asignada a un auditor.",
                        "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ex.Message.Contains("foreign key"))
                {
                    MessageBox.Show("Error de integridad: El auditor, auditado o actividad no existe.",
                        "Error de referencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Error de base de datos:\n{ex.Message}",
                        "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_Id.Text))
                {
                    MessageBox.Show("Selecciona un registro a actualizar.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Validación estricta
                if (!fun_validar_obligatorios())
                    return;

                // Confirmación
                var conf = MessageBox.Show("¿Deseas modificar la nota asignada a la actividad?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (conf != DialogResult.Yes)
                    return;

                // Capturar datos
                var ps = fun_capturar();

                // Verificar captura exitosa
                if (ps == null)
                {
                    MessageBox.Show("No se pudieron capturar los datos correctamente.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar
                if (cn.pro_actualizar(ps))
                {
                    MessageBox.Show("Nota asignada a actividad actualizado correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizardatagriew();
                    fun_limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la asignación.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (OdbcException ex)
            {
                if (ex.Message.Contains("Duplicate entry") || ex.Message.Contains("duplicate key"))
                {
                    MessageBox.Show("Esta actividad ya está asignada a otro paquete.",
                        "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ex.Message.Contains("foreign key"))
                {
                    MessageBox.Show("Error de integridad: El auditado, auditor o actividad seleccionado no existe.",
                        "Error de referencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Error de base de datos:\n{ex.Message}",
                        "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar búsqueda
                if (!fun_busqueda_valida())
                    return;

                // Buscar
                DataTable dt = cn.fun_buscar_nota_actividad(Txt_Buscar.Text.Trim());

                if (dt != null && dt.Rows.Count > 0)
                {
                    Dgv_CaliAct.DataSource = dt;

                    // Actualizar encabezados
                    if (Dgv_CaliAct.Columns.Contains("pk_id_nota_actividad"))
                        Dgv_CaliAct.Columns["pk_id_nota_actividad"].HeaderText = "ID";
                    if (Dgv_CaliAct.Columns.Contains("fk_auditado"))
                        Dgv_CaliAct.Columns["fk_auditado"].Visible = false;
                    if (Dgv_CaliAct.Columns.Contains("fk_auditor"))
                        Dgv_CaliAct.Columns["fk_auditor"].Visible = false;
                    if (Dgv_CaliAct.Columns.Contains("fk_actividad"))
                        Dgv_CaliAct.Columns["fk_actividad"].Visible = false;
                    if (Dgv_CaliAct.Columns.Contains("nombre_auditado"))
                        Dgv_CaliAct.Columns["nombre_auditado"].HeaderText = "Auditado";
                    if (Dgv_CaliAct.Columns.Contains("nombre_auditor"))
                        Dgv_CaliAct.Columns["nombre_auditor"].HeaderText = "Auditor";
                    if (Dgv_CaliAct.Columns.Contains("nombre_actividad"))
                        Dgv_CaliAct.Columns["nombre_actividad"].HeaderText = "Actividad";
                    if (Dgv_CaliAct.Columns.Contains("nota"))
                        Dgv_CaliAct.Columns["nota"].HeaderText = "Nota";

                    MessageBox.Show($"Se encontraron {dt.Rows.Count} resultado(s).",
                        "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados.",
                        "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizardatagriew(); // Restaurar todos los datos
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Id.Text)) return;

            int iId = int.Parse(Txt_Id.Text);

            if (MessageBox.Show("¿Eliminar la nota asignada a la actividad seleccionado?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (cn.pro_eliminar(iId))
                    {
                        MessageBox.Show("Nota asignada a actividad eliminada.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizardatagriew();
                        fun_limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (System.Data.Odbc.OdbcException ex)
                {
                    if (ex.Message.Contains("foreign key") || ex.Message.Contains("Cannot delete or update"))
                    {
                        MessageBox.Show("No se puede eliminar esta nota asignada a actividad porque esta relacionada con otra tabla.",
                                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            fun_limpiar();
        }
    }
}

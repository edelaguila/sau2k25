using Capa_Controlador_ActividadesARubrica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Capa_Vista_ActividadesARubrica
{
    public partial class frm_Act_a_Rubricas : Form
    {
        controlador cn = new controlador();
        private readonly ToolTip toolTip1 = new ToolTip(); // NUEVO
        public frm_Act_a_Rubricas()
        {
            InitializeComponent();

            fun_limpiar();
            Txt_Id.Enabled = false;

            // Tabla
            Dgv_ActRub.AutoGenerateColumns = true;
            Dgv_ActRub.ReadOnly = true;
            Dgv_ActRub.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Eventos
            Dgv_ActRub.CellClick += Dgv_ActRub_CellClick;

            // ToolTips
            toolTip1.SetToolTip(Btn_Nuevo, "Preparar formulario para nueva asignación");
            toolTip1.SetToolTip(Btn_Guardar, "Guardar asignación");
            toolTip1.SetToolTip(Btn_Editar, "Editar asignación seleccionada");
            toolTip1.SetToolTip(Btn_Eliminar, "Eliminar asignación");
            toolTip1.SetToolTip(Btn_Cancelar, "Cancelar y limpiar formulario");

            CargarCombos();
        }

        // ============================================================
        // COMBOS
        // ============================================================
        private void CargarCombos()
        {
            try
            {
                // ACTIVIDADES
                Cmb_Actividad.DataSource = cn.cargarActividades();
                Cmb_Actividad.DisplayMember = "nombre_actividad";
                Cmb_Actividad.ValueMember = "Pk_id_actividad_proyecto";
                Cmb_Actividad.SelectedIndex = -1;

                // RUBRICAS
                Cmb_Rubrica.DataSource = cn.cargarRubricas();
                Cmb_Rubrica.DisplayMember = "nombre_rubrica";
                Cmb_Rubrica.ValueMember = "Pk_id_rubrica";
                Cmb_Rubrica.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combos: " + ex.Message);
            }
        }


        // ============================================================
        // CARGAR TABLA
        // ============================================================
        public void actualizarDatagrid()
        {
            try
            {
                DataTable dt = cn.cargarAsignaciones();
                Dgv_ActRub.DataSource = dt;

                if (Dgv_ActRub.Columns.Contains("ID"))
                    Dgv_ActRub.Columns["ID"].Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tabla: " + ex.Message);
            }
        }

        // ============================================================
        // LIMPIAR
        // ============================================================
        private void fun_limpiar()
        {
            Txt_Id.Clear();
            Cmb_Actividad.SelectedIndex = -1;
            Cmb_Rubrica.SelectedIndex = -1;

            fun_estado_edicion(false);
            actualizarDatagrid();
        }

        // ============================================================
        // MODO EDICIÓN
        // ============================================================
        private void fun_estado_edicion(bool bActivo)
        {
            Cmb_Actividad.Enabled = bActivo;
            Cmb_Rubrica.Enabled = bActivo;

            Btn_Guardar.Enabled = bActivo && string.IsNullOrWhiteSpace(Txt_Id.Text);
            Btn_Editar.Enabled = bActivo && !string.IsNullOrWhiteSpace(Txt_Id.Text);
            Btn_Eliminar.Enabled = bActivo && !string.IsNullOrWhiteSpace(Txt_Id.Text);
        }

        // ============================================================
        // VALIDACIÓN
        // ============================================================
        private bool fun_validar()
        {
            if (Cmb_Actividad.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una actividad.", "Validación");
                Cmb_Actividad.Focus();
                return false;
            }

            if (Cmb_Rubrica.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una rúbrica.", "Validación");
                Cmb_Rubrica.Focus();
                return false;
            }

            return true;
        }

        // ============================================================
        // SELECCIONAR REGISTRO
        // ============================================================
        private void Dgv_ActRub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || Dgv_ActRub.CurrentRow == null) return;

            var r = Dgv_ActRub.Rows[e.RowIndex];

            Txt_Id.Text = Convert.ToString(r.Cells["ID"].Value);
            Cmb_Actividad.Text = Convert.ToString(r.Cells["Actividad"].Value);
            Cmb_Rubrica.Text = Convert.ToString(r.Cells["Rubrica"].Value);

            fun_estado_edicion(true);
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            fun_limpiar();
            fun_estado_edicion(true);
            Cmb_Actividad.Focus();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!fun_validar())
                return;

            try
            {
                int act = Convert.ToInt32(Cmb_Actividad.SelectedValue);
                int rub = Convert.ToInt32(Cmb_Rubrica.SelectedValue);

                cn.guardarAsignacion(act, rub);

                MessageBox.Show("Asignación guardada correctamente.");
                fun_limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Id.Text))
            {
                MessageBox.Show("Seleccione un registro.");
                return;
            }

            if (!fun_validar())
                return;

            try
            {
                int id = Convert.ToInt32(Txt_Id.Text);
                int act = Convert.ToInt32(Cmb_Actividad.SelectedValue);
                int rub = Convert.ToInt32(Cmb_Rubrica.SelectedValue);

                cn.actualizarAsignacion(id, act, rub);

                MessageBox.Show("Asignación actualizada.");
                fun_limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string texto = Txt_Buscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Ingrese un texto para buscar.", "Búsqueda",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                DataTable dt = cn.buscarAsignacion(texto);

                if (dt.Rows.Count > 0)
                {
                    Dgv_ActRub.DataSource = dt;
                    MessageBox.Show($"{dt.Rows.Count} resultado(s) encontrado(s).",
                        "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron coincidencias.",
                        "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Restaurar todo
                    actualizarDatagrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Id.Text)) return;

            int id = int.Parse(Txt_Id.Text);

            if (MessageBox.Show("¿Eliminar asignación?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cn.eliminarAsignacion(id);
                    MessageBox.Show("Asignación eliminada.");
                    fun_limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            fun_limpiar();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Buscar.Text))
            {
                actualizarDatagrid();
            }
        }
    }
}

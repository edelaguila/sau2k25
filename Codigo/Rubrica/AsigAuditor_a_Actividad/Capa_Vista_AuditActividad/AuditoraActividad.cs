using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_AuditActividad
{
    public partial class AuditoraActividad : Form
    {
        Capa_Controlador_AuditActividad.controlador capaControlador_movimiento = new Capa_Controlador_AuditActividad.controlador();

        public AuditoraActividad()
        {
            InitializeComponent();
            IniciarFormulario();
        }

        private void IniciarFormulario()
        {
            // Cargar ComboBox
            capaControlador_movimiento.cargarAuditores(cmb_idauditor);
            capaControlador_movimiento.cargarEstado(cmb_idestado);
            capaControlador_movimiento.cargarActividades(cmb_idactividad);
            txt_idasignacion.Text = capaControlador_movimiento.getNextId().ToString();

            // Cargar historial de movimientos
            CargarAsignaciones();
        }

        private void CargarAsignaciones()
        {
            DataTable dt = capaControlador_movimiento.obtenerAsignaciones();
            dgv_asignacion.DataSource = dt;
        }

        private void LimpiarCampos()
        {
            cmb_idactividad.SelectedIndex = -1;
            cmb_idauditor.SelectedIndex = -1;
            cmb_idestado.SelectedIndex = -1;
            txt_idasignacion.Clear();
            txt_descripcion.Clear();
            txt_nombreasignacion.Clear();
            IniciarFormulario();
        }

        private void dgv_asignacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgv_asignacion.Rows[e.RowIndex];
                txt_idasignacion.Text = fila.Cells["Pk_id_asignacion"].Value?.ToString();
                cmb_idauditor.Text = fila.Cells["nombre_auditor"].Value?.ToString();
                cmb_idestado.Text = fila.Cells["estado_asignacion"].Value?.ToString();
                cmb_idactividad.Text = fila.Cells["nombre_actividad"].Value?.ToString();
                txt_nombreasignacion.Text = fila.Cells["nombre_asignacion"].Value?.ToString();
                dtp_fecha.Text = fila.Cells["fecha_asignacion"].Value?.ToString();
                txt_descripcion.Text = fila.Cells["descripcion"].Value?.ToString();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_idactividad.SelectedIndex == -1 || cmb_idauditor.SelectedIndex == -1 || cmb_idestado.SelectedIndex == -1 || txt_idasignacion.Text == "" || txt_nombreasignacion.Text == "" || txt_descripcion.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los datos.");
                    return;
                }

                int idAsignacion = Convert.ToInt32(txt_idasignacion.Text);
                int idAuditor = Convert.ToInt32(cmb_idauditor.SelectedValue);
                int idEstado = Convert.ToInt32(cmb_idestado.SelectedValue);
                int idActividad = Convert.ToInt32(cmb_idactividad.SelectedValue);
                string nombreAsignacion = txt_nombreasignacion.Text;
                string descripcion = txt_descripcion.Text;
                capaControlador_movimiento.guardar_movimientoAsignacion(idAsignacion, idAuditor, idEstado, idActividad, nombreAsignacion, descripcion);
                MessageBox.Show("Se registró la asignación");
                CargarAsignaciones();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error " + ex.Message);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_idactividad.SelectedIndex == -1 || cmb_idauditor.SelectedIndex == -1 || cmb_idestado.SelectedIndex == -1 || txt_idasignacion.Text == "" || txt_nombreasignacion.Text == "" || txt_descripcion.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los datos.");
                    return;
                }

                int idAsignacion = Convert.ToInt32(txt_idasignacion.Text);
                int idAuditor = Convert.ToInt32(cmb_idauditor.SelectedValue);
                int idEstado = Convert.ToInt32(cmb_idestado.SelectedValue);
                int idActividad = Convert.ToInt32(cmb_idactividad.SelectedValue);
                string nombreAsignacion = txt_nombreasignacion.Text;
                string descripcion = txt_descripcion.Text;
                capaControlador_movimiento.modificar_movimientoAsignacion(idAsignacion, idAuditor, idEstado, idActividad, nombreAsignacion, descripcion);
                MessageBox.Show("Se modificó la asignación");
                CargarAsignaciones();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (txt_idasignacion.Text == "")
            {
                MessageBox.Show("Seleccione una asignación de la lista");
                return;
            }

            int idAsignacion = Convert.ToInt32(txt_idasignacion.Text);

            DialogResult result = MessageBox.Show(
                "¿Está seguro que desea eliminar esta asignación?",
                "Eliminar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    capaControlador_movimiento.eliminarAsignacion(idAsignacion);
                    MessageBox.Show("Asignación eliminada correctamente.");
                    CargarAsignaciones();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Asignacion;

namespace Capa_Vista_AsignacionAud
{
    public partial class Form1 : Form
    {
        private Controlador controlador;

        public Form1()
        {
            InitializeComponent();
            controlador = new Controlador();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarProyectos();
            CargarAsignaciones();
        }

        // Método para cargar proyectos activos
        private void CargarProyectos()
        {
            try
            {
                DataTable dt = controlador.ObtenerProyectosActivos();
                
                // Deshabilitar temporalmente el evento para evitar problemas al establecer el DataSource
                Cbo_Proyecto.SelectedIndexChanged -= Cbo_Proyecto_SelectedIndexChanged;
                
                Cbo_Proyecto.DataSource = dt;
                Cbo_Proyecto.DisplayMember = "nombre_proyecto";
                Cbo_Proyecto.ValueMember = "Pk_id_proyecto";
                Cbo_Proyecto.SelectedIndex = -1;
                
                // Rehabilitar el evento
                Cbo_Proyecto.SelectedIndexChanged += Cbo_Proyecto_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proyectos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Rehabilitar el evento en caso de error
                Cbo_Proyecto.SelectedIndexChanged += Cbo_Proyecto_SelectedIndexChanged;
            }
        }

        // Evento cuando se selecciona un proyecto
        private void Cbo_Proyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Proyecto.SelectedIndex >= 0 && Cbo_Proyecto.SelectedItem != null)
            {
                int idProyecto = 0;
                
                // Obtener el valor del DataRowView
                DataRowView row = Cbo_Proyecto.SelectedItem as DataRowView;
                if (row != null)
                {
                    idProyecto = Convert.ToInt32(row["Pk_id_proyecto"]);
                    CargarAuditores(idProyecto);
                    CargarAuditados(idProyecto);
                    CargarActividades(idProyecto);
                }
            }
            else
            {
                LimpiarCombosDependientes();
            }
        }

        // Método para cargar auditores por proyecto
        private void CargarAuditores(int idProyecto)
        {
            try
            {
                DataTable dt = controlador.ObtenerAuditoresPorProyecto(idProyecto);
                Cbo_Auditor.DataSource = null;
                Cbo_Auditor.Items.Clear();
                
                if (dt != null && dt.Rows.Count > 0)
                {
                    Cbo_Auditor.DataSource = dt;
                    Cbo_Auditor.DisplayMember = "nombre_auditor";
                    Cbo_Auditor.ValueMember = "Pk_id_auditor";
                    Cbo_Auditor.Enabled = true;
                    Cbo_Auditor.SelectedIndex = -1;
                }
                else
                {
                    Cbo_Auditor.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar auditores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cbo_Auditor.Enabled = false;
            }
        }

        // Método para cargar auditados por proyecto
        private void CargarAuditados(int idProyecto)
        {
            try
            {
                DataTable dt = controlador.ObtenerAuditadosPorProyecto(idProyecto);
                Cbo_Auditado.DataSource = null;
                Cbo_Auditado.Items.Clear();
                
                if (dt != null && dt.Rows.Count > 0)
                {
                    Cbo_Auditado.DataSource = dt;
                    Cbo_Auditado.DisplayMember = "nombre_auditado";
                    Cbo_Auditado.ValueMember = "Pk_id_auditado";
                    Cbo_Auditado.Enabled = true;
                    Cbo_Auditado.SelectedIndex = -1;
                }
                else
                {
                    Cbo_Auditado.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar auditados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cbo_Auditado.Enabled = false;
            }
        }

        // Método para cargar actividades por proyecto
        private void CargarActividades(int idProyecto)
        {
            try
            {
                DataTable dt = controlador.ObtenerActividadesPorProyecto(idProyecto);
                Cbo_Actividad.DataSource = null;
                Cbo_Actividad.Items.Clear();
                
                if (dt != null && dt.Rows.Count > 0)
                {
                    Cbo_Actividad.DataSource = dt;
                    Cbo_Actividad.DisplayMember = "nombre_actividad";
                    Cbo_Actividad.ValueMember = "Pk_id_actividad_proyecto";
                    Cbo_Actividad.Enabled = true;
                    Cbo_Actividad.SelectedIndex = -1;
                }
                else
                {
                    Cbo_Actividad.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar actividades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cbo_Actividad.Enabled = false;
            }
        }

        // Método para limpiar combos dependientes
        private void LimpiarCombosDependientes()
        {
            Cbo_Auditor.DataSource = null;
            Cbo_Auditor.Items.Clear();
            Cbo_Auditor.Enabled = false;

            Cbo_Auditado.DataSource = null;
            Cbo_Auditado.Items.Clear();
            Cbo_Auditado.Enabled = false;

            Cbo_Actividad.DataSource = null;
            Cbo_Actividad.Items.Clear();
            Cbo_Actividad.Enabled = false;
        }

        // Evento del botón Guardar
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que todos los campos estén seleccionados
                if (Cbo_Proyecto.SelectedIndex < 0 || Cbo_Proyecto.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un proyecto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cbo_Proyecto.Focus();
                    return;
                }

                if (Cbo_Auditor.SelectedIndex < 0 || Cbo_Auditor.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un auditor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cbo_Auditor.Focus();
                    return;
                }

                if (Cbo_Auditado.SelectedIndex < 0 || Cbo_Auditado.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un auditado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cbo_Auditado.Focus();
                    return;
                }

                if (Cbo_Actividad.SelectedIndex < 0 || Cbo_Actividad.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una actividad", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cbo_Actividad.Focus();
                    return;
                }

                // Obtener los valores seleccionados
                DataRowView rowProyecto = Cbo_Proyecto.SelectedItem as DataRowView;
                DataRowView rowAuditor = Cbo_Auditor.SelectedItem as DataRowView;
                DataRowView rowAuditado = Cbo_Auditado.SelectedItem as DataRowView;
                DataRowView rowActividad = Cbo_Actividad.SelectedItem as DataRowView;

                if (rowProyecto == null || rowAuditor == null || rowAuditado == null || rowActividad == null)
                {
                    MessageBox.Show("Error al obtener los valores seleccionados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idProyecto = Convert.ToInt32(rowProyecto["Pk_id_proyecto"]);
                int idAuditor = Convert.ToInt32(rowAuditor["Pk_id_auditor"]);
                int idAuditado = Convert.ToInt32(rowAuditado["Pk_id_auditado"]);
                int idActividad = Convert.ToInt32(rowActividad["Pk_id_actividad_proyecto"]);

                // Insertar la asignación
                bool resultado = controlador.InsertarAsignacion(idAuditor, idAuditado, idActividad, idProyecto);

                if (resultado)
                {
                    MessageBox.Show("Asignación guardada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarAsignaciones(); // Recargar las asignaciones en el DataGridView
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la asignación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar asignación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para cargar asignaciones en el DataGridView
        private void CargarAsignaciones()
        {
            try
            {
                DataTable dt = controlador.ObtenerAsignaciones();
                Dgv_Asigandos.DataSource = dt;
                
                // Configurar columnas del DataGridView
                if (Dgv_Asigandos.Columns.Count > 0)
                {
                    // Ocultar la columna del ID si existe
                    if (Dgv_Asigandos.Columns["Pk_id_asignacion_auditor_auditado"] != null)
                    {
                        Dgv_Asigandos.Columns["Pk_id_asignacion_auditor_auditado"].Visible = false;
                    }
                    
                    // Ajustar ancho de columnas automáticamente
                    Dgv_Asigandos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    
                    // Configurar encabezados de columnas en español
                    if (Dgv_Asigandos.Columns["nombre_proyecto"] != null)
                    {
                        Dgv_Asigandos.Columns["nombre_proyecto"].HeaderText = "Proyecto";
                    }
                    if (Dgv_Asigandos.Columns["nombre_auditor"] != null)
                    {
                        Dgv_Asigandos.Columns["nombre_auditor"].HeaderText = "Auditor";
                    }
                    if (Dgv_Asigandos.Columns["nombre_auditado"] != null)
                    {
                        Dgv_Asigandos.Columns["nombre_auditado"].HeaderText = "Auditado";
                    }
                    if (Dgv_Asigandos.Columns["nombre_actividad"] != null)
                    {
                        Dgv_Asigandos.Columns["nombre_actividad"].HeaderText = "Actividad";
                    }
                    if (Dgv_Asigandos.Columns["estado_asignacion"] != null)
                    {
                        Dgv_Asigandos.Columns["estado_asignacion"].HeaderText = "Estado";
                    }
                    if (Dgv_Asigandos.Columns["fecha_asignacion"] != null)
                    {
                        Dgv_Asigandos.Columns["fecha_asignacion"].HeaderText = "Fecha Asignación";
                    }
                    if (Dgv_Asigandos.Columns["fecha_finalizacion"] != null)
                    {
                        Dgv_Asigandos.Columns["fecha_finalizacion"].HeaderText = "Fecha Finalización";
                    }
                    if (Dgv_Asigandos.Columns["observaciones"] != null)
                    {
                        Dgv_Asigandos.Columns["observaciones"].HeaderText = "Observaciones";
                    }
                    
                    // Hacer que el DataGridView sea de solo lectura
                    Dgv_Asigandos.ReadOnly = true;
                    Dgv_Asigandos.AllowUserToAddRows = false;
                    Dgv_Asigandos.AllowUserToDeleteRows = false;
                    Dgv_Asigandos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar asignaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para limpiar los campos después de guardar
        private void LimpiarCampos()
        {
            Cbo_Proyecto.SelectedIndex = -1;
            LimpiarCombosDependientes();
        }
    }
}

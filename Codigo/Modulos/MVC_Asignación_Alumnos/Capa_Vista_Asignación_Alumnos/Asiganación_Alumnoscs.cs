using Capa_Controlador;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_Vista_Asignación_Alumnos
{
    public partial class Asiganación_Alumnoscs : Form
    {
        Logica logica = new Logica();
        int idSeleccionado = -1;

        public Asiganación_Alumnoscs()
        {
            InitializeComponent();
            CargarProyectos();
            CargarTabla();
        }

        // ---------------------------------------------------------
        // CARGAR PROYECTOS AL COMBOBOX
        // ---------------------------------------------------------
        private void CargarProyectos()
        {
            // ⚠ REEMPLAZAR: comboBoxProyecto por el nombre real de tu ComboBox
            var combo = comboProyecto;

            combo.Items.Clear();
            foreach (var item in logica.ObtenerProyectos())
            {
                combo.Items.Add(new
                {
                    Text = item[1],
                    Value = item[0]
                });
            }

            combo.DisplayMember = "Text";
            combo.ValueMember = "Value";
        }

        // ---------------------------------------------------------
        // CARGAR DATOS AL DATAGRID
        // ---------------------------------------------------------
        private void CargarTabla()
        {
            dataGridView1.DataSource = logica.CargarAsignaciones();
        }

        // ---------------------------------------------------------
        // INSERTAR (button1)
        // ---------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // ⚠ REEMPLAZAR: comboBoxProyecto por tu ComboBox real
                var combo = comboProyecto;

                int idProyecto = Convert.ToInt32((combo.SelectedItem as dynamic).Value);

                // ⚠ Cambiar estos nombres por tus TextBox reales:
                string nombre = textBoxNombre.Text;
                string cargo = textBoxCargo.Text;
                string correo = textBoxCorreo.Text;
                string telefono = textBoxTelefono.Text;
                string observaciones = textBoxObser.Text;

                bool ok = logica.Insertar(idProyecto, nombre, cargo, correo, telefono, observaciones);

                if (ok)
                {
                    MessageBox.Show("Registro insertado correctamente.");
                    CargarTabla();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
        }

        // ---------------------------------------------------------
        // SELECCIONAR FILA DEL GRID
        // ---------------------------------------------------------
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            idSeleccionado = Convert.ToInt32(row.Cells["Pk_id_auditado"].Value);

            // ⚠ Cambiar por tus TextBox reales:
            textBoxNombre.Text = row.Cells["nombre_auditado"].Value.ToString();
            textBoxCargo.Text = row.Cells["cargo_o_area"].Value.ToString();
            textBoxCorreo.Text = row.Cells["correo"].Value.ToString();
            textBoxTelefono.Text = row.Cells["telefono"].Value.ToString();
            textBoxObser.Text = row.Cells["observaciones"].Value.ToString();
        }

        // ---------------------------------------------------------
        // EDITAR (button2)
        // ---------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un registro primero.");
                return;
            }

            try
            {
                // ⚠ REEMPLAZAR: comboBoxProyecto por el nombre real:
                var combo = comboProyecto;
                int idProyecto = Convert.ToInt32((combo.SelectedItem as dynamic).Value);

                // ⚠ Cambiar estos nombres:
                string nombre = textBoxNombre.Text;
                string cargo = textBoxCargo.Text;
                string correo = textBoxCorreo.Text;
                string telefono = textBoxTelefono.Text;
                string observaciones = textBoxObser.Text;

                bool ok = logica.Editar(idSeleccionado, idProyecto, nombre, cargo, correo, telefono, observaciones);

                if (ok)
                {
                    MessageBox.Show("Registro editado correctamente.");
                    CargarTabla();
                }
                else
                {
                    MessageBox.Show("No se pudo editar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
        }

        // ---------------------------------------------------------
        // ELIMINAR (button3)
        // ---------------------------------------------------------
        private void button3_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un registro primero.");
                return;
            }

            try
            {
                bool ok = logica.Eliminar(idSeleccionado);

                if (ok)
                {
                    MessageBox.Show("Registro eliminado.");
                    CargarTabla();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                comboProyecto.Text = dataGridView1.Rows[e.RowIndex]
                             .Cells["Pk_id_auditado"].Value.ToString();
            }

        }
    }
}


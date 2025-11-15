
namespace Capa_Vista_AuditActividad
{
    partial class AuditoraActividad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_asignacion = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_idactividad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_idestado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_idauditor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombreasignacion = new System.Windows.Forms.TextBox();
            this.lbl_mantenimientoequipos = new System.Windows.Forms.Label();
            this.txt_idasignacion = new System.Windows.Forms.TextBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_asignacion
            // 
            this.dgv_asignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_asignacion.Location = new System.Drawing.Point(27, 331);
            this.dgv_asignacion.Name = "dgv_asignacion";
            this.dgv_asignacion.Size = new System.Drawing.Size(707, 250);
            this.dgv_asignacion.TabIndex = 64;
            this.dgv_asignacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_asignacion_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(340, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 22);
            this.label7.TabIndex = 60;
            this.label7.Text = "Descripción";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(478, 184);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(256, 54);
            this.txt_descripcion.TabIndex = 59;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Enabled = false;
            this.dtp_fecha.Location = new System.Drawing.Point(534, 144);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(340, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 22);
            this.label6.TabIndex = 57;
            this.label6.Text = "Fecha Asignación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(340, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 22);
            this.label5.TabIndex = 56;
            this.label5.Text = "Nombre Asignación";
            // 
            // cmb_idactividad
            // 
            this.cmb_idactividad.FormattingEnabled = true;
            this.cmb_idactividad.Location = new System.Drawing.Point(164, 220);
            this.cmb_idactividad.Name = "cmb_idactividad";
            this.cmb_idactividad.Size = new System.Drawing.Size(121, 21);
            this.cmb_idactividad.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 22);
            this.label4.TabIndex = 54;
            this.label4.Text = "ID Actividad";
            // 
            // cmb_idestado
            // 
            this.cmb_idestado.FormattingEnabled = true;
            this.cmb_idestado.Location = new System.Drawing.Point(164, 184);
            this.cmb_idestado.Name = "cmb_idestado";
            this.cmb_idestado.Size = new System.Drawing.Size(121, 21);
            this.cmb_idestado.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 52;
            this.label3.Text = "ID Estado";
            // 
            // cmb_idauditor
            // 
            this.cmb_idauditor.FormattingEnabled = true;
            this.cmb_idauditor.Location = new System.Drawing.Point(164, 148);
            this.cmb_idauditor.Name = "cmb_idauditor";
            this.cmb_idauditor.Size = new System.Drawing.Size(121, 21);
            this.cmb_idauditor.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 50;
            this.label1.Text = "ID Auditor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 48;
            this.label2.Text = "ID Asignación";
            // 
            // txt_nombreasignacion
            // 
            this.txt_nombreasignacion.Location = new System.Drawing.Point(534, 108);
            this.txt_nombreasignacion.Name = "txt_nombreasignacion";
            this.txt_nombreasignacion.Size = new System.Drawing.Size(200, 20);
            this.txt_nombreasignacion.TabIndex = 47;
            // 
            // lbl_mantenimientoequipos
            // 
            this.lbl_mantenimientoequipos.AutoSize = true;
            this.lbl_mantenimientoequipos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mantenimientoequipos.ForeColor = System.Drawing.Color.Black;
            this.lbl_mantenimientoequipos.Location = new System.Drawing.Point(252, 16);
            this.lbl_mantenimientoequipos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mantenimientoequipos.Name = "lbl_mantenimientoequipos";
            this.lbl_mantenimientoequipos.Size = new System.Drawing.Size(266, 32);
            this.lbl_mantenimientoequipos.TabIndex = 46;
            this.lbl_mantenimientoequipos.Text = "Auditor a Actividad";
            // 
            // txt_idasignacion
            // 
            this.txt_idasignacion.Location = new System.Drawing.Point(164, 108);
            this.txt_idasignacion.Name = "txt_idasignacion";
            this.txt_idasignacion.ReadOnly = true;
            this.txt_idasignacion.Size = new System.Drawing.Size(121, 20);
            this.txt_idasignacion.TabIndex = 65;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = global::Capa_Vista_AuditActividad.Properties.Resources.borrar12;
            this.btn_eliminar.Location = new System.Drawing.Point(407, 264);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(35, 35);
            this.btn_eliminar.TabIndex = 63;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = global::Capa_Vista_AuditActividad.Properties.Resources.editar11;
            this.btn_modificar.Location = new System.Drawing.Point(330, 264);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(35, 35);
            this.btn_modificar.TabIndex = 62;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::Capa_Vista_AuditActividad.Properties.Resources.guardar13;
            this.btn_guardar.Location = new System.Drawing.Point(258, 264);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(35, 35);
            this.btn_guardar.TabIndex = 61;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // AuditoraActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 593);
            this.Controls.Add(this.txt_idasignacion);
            this.Controls.Add(this.dgv_asignacion);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_idactividad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_idestado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_idauditor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombreasignacion);
            this.Controls.Add(this.lbl_mantenimientoequipos);
            this.Name = "AuditoraActividad";
            this.Text = "Auditor a Actividad";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_asignacion;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_idactividad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_idestado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_idauditor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombreasignacion;
        private System.Windows.Forms.Label lbl_mantenimientoequipos;
        private System.Windows.Forms.TextBox txt_idasignacion;
    }
}
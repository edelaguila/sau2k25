
namespace Capa_Vista_Cali_Act
{
    partial class frm_Cali_Act
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cali_Act));
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Txt_Buscar = new System.Windows.Forms.TextBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Lbl_NombreAuditado = new System.Windows.Forms.Label();
            this.Lbl_NombreActividad = new System.Windows.Forms.Label();
            this.Lbl_NombreAuditar = new System.Windows.Forms.Label();
            this.Lbl_Nota = new System.Windows.Forms.Label();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Cmb_Auditado = new System.Windows.Forms.ComboBox();
            this.Cmb_Auditor = new System.Windows.Forms.ComboBox();
            this.Cmb_Actividad = new System.Windows.Forms.ComboBox();
            this.Txt_Nota = new System.Windows.Forms.TextBox();
            this.Dgv_CaliAct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CaliAct)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(241, 34);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(355, 24);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Asignar Calificación a Actividades";
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Nuevo.BackgroundImage")));
            this.Btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nuevo.Location = new System.Drawing.Point(47, 72);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(64, 68);
            this.Btn_Nuevo.TabIndex = 1;
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.Location = new System.Drawing.Point(257, 114);
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(201, 20);
            this.Txt_Buscar.TabIndex = 7;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.BackgroundImage")));
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Location = new System.Drawing.Point(117, 72);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(64, 68);
            this.Btn_Guardar.TabIndex = 8;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Editar.BackgroundImage")));
            this.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Editar.Location = new System.Drawing.Point(187, 72);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(64, 68);
            this.Btn_Editar.TabIndex = 9;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.BackgroundImage")));
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Location = new System.Drawing.Point(464, 72);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(64, 68);
            this.Btn_Buscar.TabIndex = 10;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.BackgroundImage")));
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Location = new System.Drawing.Point(532, 72);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(64, 68);
            this.Btn_Eliminar.TabIndex = 11;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.BackgroundImage")));
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Location = new System.Drawing.Point(602, 72);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(64, 68);
            this.Btn_Cancelar.TabIndex = 12;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Buscar.Location = new System.Drawing.Point(324, 90);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(61, 21);
            this.Lbl_Buscar.TabIndex = 13;
            this.Lbl_Buscar.Text = "Buscar";
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id.Location = new System.Drawing.Point(49, 201);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(30, 21);
            this.Lbl_Id.TabIndex = 14;
            this.Lbl_Id.Text = "Id:";
            // 
            // Lbl_NombreAuditado
            // 
            this.Lbl_NombreAuditado.AutoSize = true;
            this.Lbl_NombreAuditado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NombreAuditado.Location = new System.Drawing.Point(49, 241);
            this.Lbl_NombreAuditado.Name = "Lbl_NombreAuditado";
            this.Lbl_NombreAuditado.Size = new System.Drawing.Size(185, 21);
            this.Lbl_NombreAuditado.TabIndex = 15;
            this.Lbl_NombreAuditado.Text = "Nombre del Auditado:";
            // 
            // Lbl_NombreActividad
            // 
            this.Lbl_NombreActividad.AutoSize = true;
            this.Lbl_NombreActividad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NombreActividad.Location = new System.Drawing.Point(49, 320);
            this.Lbl_NombreActividad.Name = "Lbl_NombreActividad";
            this.Lbl_NombreActividad.Size = new System.Drawing.Size(203, 21);
            this.Lbl_NombreActividad.TabIndex = 16;
            this.Lbl_NombreActividad.Text = "Nombre de la Actividad:";
            // 
            // Lbl_NombreAuditar
            // 
            this.Lbl_NombreAuditar.AutoSize = true;
            this.Lbl_NombreAuditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NombreAuditar.Location = new System.Drawing.Point(49, 280);
            this.Lbl_NombreAuditar.Name = "Lbl_NombreAuditar";
            this.Lbl_NombreAuditar.Size = new System.Drawing.Size(168, 21);
            this.Lbl_NombreAuditar.TabIndex = 17;
            this.Lbl_NombreAuditar.Text = "Nombre del Auditor:";
            // 
            // Lbl_Nota
            // 
            this.Lbl_Nota.AutoSize = true;
            this.Lbl_Nota.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nota.Location = new System.Drawing.Point(49, 363);
            this.Lbl_Nota.Name = "Lbl_Nota";
            this.Lbl_Nota.Size = new System.Drawing.Size(54, 21);
            this.Lbl_Nota.TabIndex = 18;
            this.Lbl_Nota.Text = "Nota:";
            // 
            // Txt_Id
            // 
            this.Txt_Id.Location = new System.Drawing.Point(251, 204);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(134, 20);
            this.Txt_Id.TabIndex = 19;
            // 
            // Cmb_Auditado
            // 
            this.Cmb_Auditado.FormattingEnabled = true;
            this.Cmb_Auditado.Location = new System.Drawing.Point(251, 244);
            this.Cmb_Auditado.Name = "Cmb_Auditado";
            this.Cmb_Auditado.Size = new System.Drawing.Size(134, 21);
            this.Cmb_Auditado.TabIndex = 20;
            // 
            // Cmb_Auditor
            // 
            this.Cmb_Auditor.FormattingEnabled = true;
            this.Cmb_Auditor.Location = new System.Drawing.Point(251, 283);
            this.Cmb_Auditor.Name = "Cmb_Auditor";
            this.Cmb_Auditor.Size = new System.Drawing.Size(134, 21);
            this.Cmb_Auditor.TabIndex = 21;
            // 
            // Cmb_Actividad
            // 
            this.Cmb_Actividad.FormattingEnabled = true;
            this.Cmb_Actividad.Location = new System.Drawing.Point(251, 323);
            this.Cmb_Actividad.Name = "Cmb_Actividad";
            this.Cmb_Actividad.Size = new System.Drawing.Size(134, 21);
            this.Cmb_Actividad.TabIndex = 22;
            // 
            // Txt_Nota
            // 
            this.Txt_Nota.Location = new System.Drawing.Point(251, 366);
            this.Txt_Nota.Name = "Txt_Nota";
            this.Txt_Nota.Size = new System.Drawing.Size(134, 20);
            this.Txt_Nota.TabIndex = 23;
            // 
            // Dgv_CaliAct
            // 
            this.Dgv_CaliAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CaliAct.Location = new System.Drawing.Point(417, 201);
            this.Dgv_CaliAct.Name = "Dgv_CaliAct";
            this.Dgv_CaliAct.Size = new System.Drawing.Size(371, 228);
            this.Dgv_CaliAct.TabIndex = 24;
            // 
            // frm_Cali_Act
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dgv_CaliAct);
            this.Controls.Add(this.Txt_Nota);
            this.Controls.Add(this.Cmb_Actividad);
            this.Controls.Add(this.Cmb_Auditor);
            this.Controls.Add(this.Cmb_Auditado);
            this.Controls.Add(this.Txt_Id);
            this.Controls.Add(this.Lbl_Nota);
            this.Controls.Add(this.Lbl_NombreAuditar);
            this.Controls.Add(this.Lbl_NombreActividad);
            this.Controls.Add(this.Lbl_NombreAuditado);
            this.Controls.Add(this.Lbl_Id);
            this.Controls.Add(this.Lbl_Buscar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Txt_Buscar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Lbl_Titulo);
            this.Name = "frm_Cali_Act";
            this.Text = "frm_Cali_Act";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CaliAct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.TextBox Txt_Buscar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label Lbl_Buscar;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.Label Lbl_NombreAuditado;
        private System.Windows.Forms.Label Lbl_NombreActividad;
        private System.Windows.Forms.Label Lbl_NombreAuditar;
        private System.Windows.Forms.Label Lbl_Nota;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.ComboBox Cmb_Auditado;
        private System.Windows.Forms.ComboBox Cmb_Auditor;
        private System.Windows.Forms.ComboBox Cmb_Actividad;
        private System.Windows.Forms.TextBox Txt_Nota;
        private System.Windows.Forms.DataGridView Dgv_CaliAct;
    }
}
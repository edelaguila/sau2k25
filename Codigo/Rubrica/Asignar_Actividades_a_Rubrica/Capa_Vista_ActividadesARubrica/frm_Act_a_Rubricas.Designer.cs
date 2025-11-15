namespace Capa_Vista_ActividadesARubrica
{
    partial class frm_Act_a_Rubricas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Act_a_Rubricas));
            this.Dgv_ActRub = new System.Windows.Forms.DataGridView();
            this.Cmb_Actividad = new System.Windows.Forms.ComboBox();
            this.Cmb_Rubrica = new System.Windows.Forms.ComboBox();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Lbl_NombreAuditar = new System.Windows.Forms.Label();
            this.Lbl_NombreActividad = new System.Windows.Forms.Label();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Txt_Buscar = new System.Windows.Forms.TextBox();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ActRub)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_ActRub
            // 
            this.Dgv_ActRub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ActRub.Location = new System.Drawing.Point(282, 137);
            this.Dgv_ActRub.Name = "Dgv_ActRub";
            this.Dgv_ActRub.Size = new System.Drawing.Size(493, 228);
            this.Dgv_ActRub.TabIndex = 44;
            // 
            // Cmb_Actividad
            // 
            this.Cmb_Actividad.FormattingEnabled = true;
            this.Cmb_Actividad.Location = new System.Drawing.Point(142, 198);
            this.Cmb_Actividad.Name = "Cmb_Actividad";
            this.Cmb_Actividad.Size = new System.Drawing.Size(134, 21);
            this.Cmb_Actividad.TabIndex = 42;
            // 
            // Cmb_Rubrica
            // 
            this.Cmb_Rubrica.FormattingEnabled = true;
            this.Cmb_Rubrica.Location = new System.Drawing.Point(142, 242);
            this.Cmb_Rubrica.Name = "Cmb_Rubrica";
            this.Cmb_Rubrica.Size = new System.Drawing.Size(134, 21);
            this.Cmb_Rubrica.TabIndex = 41;
            // 
            // Txt_Id
            // 
            this.Txt_Id.Location = new System.Drawing.Point(142, 150);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(134, 20);
            this.Txt_Id.TabIndex = 39;
            // 
            // Lbl_NombreAuditar
            // 
            this.Lbl_NombreAuditar.AutoSize = true;
            this.Lbl_NombreAuditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NombreAuditar.Location = new System.Drawing.Point(42, 242);
            this.Lbl_NombreAuditar.Name = "Lbl_NombreAuditar";
            this.Lbl_NombreAuditar.Size = new System.Drawing.Size(70, 21);
            this.Lbl_NombreAuditar.TabIndex = 37;
            this.Lbl_NombreAuditar.Text = "Rúbrica";
            // 
            // Lbl_NombreActividad
            // 
            this.Lbl_NombreActividad.AutoSize = true;
            this.Lbl_NombreActividad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NombreActividad.Location = new System.Drawing.Point(42, 198);
            this.Lbl_NombreActividad.Name = "Lbl_NombreActividad";
            this.Lbl_NombreActividad.Size = new System.Drawing.Size(89, 21);
            this.Lbl_NombreActividad.TabIndex = 36;
            this.Lbl_NombreActividad.Text = "Actividad";
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id.Location = new System.Drawing.Point(42, 150);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(30, 21);
            this.Lbl_Id.TabIndex = 34;
            this.Lbl_Id.Text = "Id:";
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Buscar.Location = new System.Drawing.Point(351, 72);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(61, 21);
            this.Lbl_Buscar.TabIndex = 33;
            this.Lbl_Buscar.Text = "Buscar";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.BackgroundImage")));
            this.Btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Location = new System.Drawing.Point(667, 72);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(45, 45);
            this.Btn_Cancelar.TabIndex = 32;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.BackgroundImage")));
            this.Btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Location = new System.Drawing.Point(616, 73);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(45, 45);
            this.Btn_Eliminar.TabIndex = 31;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.BackgroundImage")));
            this.Btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Location = new System.Drawing.Point(565, 73);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(45, 45);
            this.Btn_Buscar.TabIndex = 30;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Editar.BackgroundImage")));
            this.Btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Editar.Location = new System.Drawing.Point(142, 73);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(45, 45);
            this.Btn_Editar.TabIndex = 29;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.BackgroundImage")));
            this.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Location = new System.Drawing.Point(91, 73);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(45, 45);
            this.Btn_Guardar.TabIndex = 28;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.Location = new System.Drawing.Point(258, 96);
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(252, 20);
            this.Txt_Buscar.TabIndex = 27;
            this.Txt_Buscar.TextChanged += new System.EventHandler(this.Txt_Buscar_TextChanged);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Nuevo.BackgroundImage")));
            this.Btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nuevo.Location = new System.Drawing.Point(40, 72);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(45, 45);
            this.Btn_Nuevo.TabIndex = 26;
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(234, 33);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(311, 24);
            this.Lbl_Titulo.TabIndex = 25;
            this.Lbl_Titulo.Text = "Asignar Actividades a Rúbrica";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_Act_a_Rubricas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.Dgv_ActRub);
            this.Controls.Add(this.Cmb_Actividad);
            this.Controls.Add(this.Cmb_Rubrica);
            this.Controls.Add(this.Txt_Id);
            this.Controls.Add(this.Lbl_NombreAuditar);
            this.Controls.Add(this.Lbl_NombreActividad);
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
            this.Name = "frm_Act_a_Rubricas";
            this.Text = "frm_Act_a_Rubricas";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ActRub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_ActRub;
        private System.Windows.Forms.ComboBox Cmb_Actividad;
        private System.Windows.Forms.ComboBox Cmb_Rubrica;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Label Lbl_NombreAuditar;
        private System.Windows.Forms.Label Lbl_NombreActividad;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.Label Lbl_Buscar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.TextBox Txt_Buscar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Label Lbl_Titulo;
    }
}
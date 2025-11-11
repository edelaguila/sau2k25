
namespace Capa_Vista_AsignacionAud
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Cbo_Proyecto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cbo_Auditor = new System.Windows.Forms.ComboBox();
            this.Cbo_Auditado = new System.Windows.Forms.ComboBox();
            this.Cbo_Actividad = new System.Windows.Forms.ComboBox();
            this.Dgv_Asigandos = new System.Windows.Forms.DataGridView();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Asigandos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccion de Proyecto";
            // 
            // Cbo_Proyecto
            // 
            this.Cbo_Proyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Proyecto.FormattingEnabled = true;
            this.Cbo_Proyecto.Location = new System.Drawing.Point(219, 39);
            this.Cbo_Proyecto.Name = "Cbo_Proyecto";
            this.Cbo_Proyecto.Size = new System.Drawing.Size(121, 24);
            this.Cbo_Proyecto.TabIndex = 1;
            this.Cbo_Proyecto.SelectedIndexChanged += new System.EventHandler(this.Cbo_Proyecto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Auditor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Auditor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Auditado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(706, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Actividad";
            // 
            // Cbo_Auditor
            // 
            this.Cbo_Auditor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Auditor.Enabled = false;
            this.Cbo_Auditor.FormattingEnabled = true;
            this.Cbo_Auditor.Location = new System.Drawing.Point(148, 120);
            this.Cbo_Auditor.Name = "Cbo_Auditor";
            this.Cbo_Auditor.Size = new System.Drawing.Size(121, 24);
            this.Cbo_Auditor.TabIndex = 4;
            // 
            // Cbo_Auditado
            // 
            this.Cbo_Auditado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Auditado.Enabled = false;
            this.Cbo_Auditado.FormattingEnabled = true;
            this.Cbo_Auditado.Location = new System.Drawing.Point(466, 122);
            this.Cbo_Auditado.Name = "Cbo_Auditado";
            this.Cbo_Auditado.Size = new System.Drawing.Size(121, 24);
            this.Cbo_Auditado.TabIndex = 5;
            // 
            // Cbo_Actividad
            // 
            this.Cbo_Actividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Actividad.Enabled = false;
            this.Cbo_Actividad.FormattingEnabled = true;
            this.Cbo_Actividad.Location = new System.Drawing.Point(801, 122);
            this.Cbo_Actividad.Name = "Cbo_Actividad";
            this.Cbo_Actividad.Size = new System.Drawing.Size(121, 24);
            this.Cbo_Actividad.TabIndex = 6;
            // 
            // Dgv_Asigandos
            // 
            this.Dgv_Asigandos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Asigandos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Asigandos.Location = new System.Drawing.Point(2, 198);
            this.Dgv_Asigandos.Name = "Dgv_Asigandos";
            this.Dgv_Asigandos.RowHeadersWidth = 51;
            this.Dgv_Asigandos.RowTemplate.Height = 24;
            this.Dgv_Asigandos.Size = new System.Drawing.Size(1031, 228);
            this.Dgv_Asigandos.TabIndex = 7;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(466, 160);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(121, 32);
            this.Btn_Guardar.TabIndex = 8;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 431);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Dgv_Asigandos);
            this.Controls.Add(this.Cbo_Actividad);
            this.Controls.Add(this.Cbo_Auditado);
            this.Controls.Add(this.Cbo_Auditor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cbo_Proyecto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Asignacion Auditor a Auditado";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Asigandos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbo_Proyecto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cbo_Auditor;
        private System.Windows.Forms.ComboBox Cbo_Auditado;
        private System.Windows.Forms.ComboBox Cbo_Actividad;
        private System.Windows.Forms.DataGridView Dgv_Asigandos;
        private System.Windows.Forms.Button Btn_Guardar;
    }
}
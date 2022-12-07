namespace MiProyecto
{
    partial class MIFormulario
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
            this.grb_mantenimiento = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_botonoes_principales = new System.Windows.Forms.GroupBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.lst_mantenimiento = new System.Windows.Forms.ListBox();
            this.grb_mantenimiento.SuspendLayout();
            this.grb_botonoes_principales.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_mantenimiento
            // 
            this.grb_mantenimiento.BackColor = System.Drawing.Color.Gray;
            this.grb_mantenimiento.Controls.Add(this.btn_guardar);
            this.grb_mantenimiento.Controls.Add(this.btn_cancelar);
            this.grb_mantenimiento.Controls.Add(this.label2);
            this.grb_mantenimiento.Controls.Add(this.txt_descripcion);
            this.grb_mantenimiento.Controls.Add(this.txt_codigo);
            this.grb_mantenimiento.Controls.Add(this.label1);
            this.grb_mantenimiento.Enabled = false;
            this.grb_mantenimiento.Location = new System.Drawing.Point(27, 32);
            this.grb_mantenimiento.Name = "grb_mantenimiento";
            this.grb_mantenimiento.Size = new System.Drawing.Size(354, 160);
            this.grb_mantenimiento.TabIndex = 12;
            this.grb_mantenimiento.TabStop = false;
            this.grb_mantenimiento.Text = "Mantenimiento";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Green;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(191, 109);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 17;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(92, 109);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(62, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Descripción";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(148, 65);
            this.txt_descripcion.MaxLength = 30;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(140, 20);
            this.txt_descripcion.TabIndex = 13;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(148, 13);
            this.txt_codigo.MaxLength = 3;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(85, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Codigo";
            // 
            // grb_botonoes_principales
            // 
            this.grb_botonoes_principales.BackColor = System.Drawing.Color.Gray;
            this.grb_botonoes_principales.Controls.Add(this.btn_salir);
            this.grb_botonoes_principales.Controls.Add(this.btn_reporte);
            this.grb_botonoes_principales.Controls.Add(this.btn_eliminar);
            this.grb_botonoes_principales.Controls.Add(this.btn_actualizar);
            this.grb_botonoes_principales.Controls.Add(this.btn_nuevo);
            this.grb_botonoes_principales.Location = new System.Drawing.Point(27, 217);
            this.grb_botonoes_principales.Name = "grb_botonoes_principales";
            this.grb_botonoes_principales.Size = new System.Drawing.Size(624, 134);
            this.grb_botonoes_principales.TabIndex = 13;
            this.grb_botonoes_principales.TabStop = false;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Yellow;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.Black;
            this.btn_salir.Image = global::MiProyecto.Properties.Resources.salir;
            this.btn_salir.Location = new System.Drawing.Point(502, 29);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(100, 80);
            this.btn_salir.TabIndex = 12;
            this.btn_salir.Text = "Salir";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_salir.UseVisualStyleBackColor = false;
            // 
            // btn_reporte
            // 
            this.btn_reporte.BackColor = System.Drawing.Color.Yellow;
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporte.ForeColor = System.Drawing.Color.Black;
            this.btn_reporte.Image = global::MiProyecto.Properties.Resources.reporte_de_negocios;
            this.btn_reporte.Location = new System.Drawing.Point(375, 29);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(100, 80);
            this.btn_reporte.TabIndex = 11;
            this.btn_reporte.Text = "Reporte";
            this.btn_reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_reporte.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Yellow;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_eliminar.Image = global::MiProyecto.Properties.Resources.basura;
            this.btn_eliminar.Location = new System.Drawing.Point(254, 29);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 80);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.Yellow;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.Color.Black;
            this.btn_actualizar.Image = global::MiProyecto.Properties.Resources.actualizar;
            this.btn_actualizar.Location = new System.Drawing.Point(129, 29);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(100, 80);
            this.btn_actualizar.TabIndex = 9;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.Yellow;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.Black;
            this.btn_nuevo.Image = global::MiProyecto.Properties.Resources.nuevo;
            this.btn_nuevo.Location = new System.Drawing.Point(6, 29);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(100, 80);
            this.btn_nuevo.TabIndex = 8;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // lst_mantenimiento
            // 
            this.lst_mantenimiento.FormattingEnabled = true;
            this.lst_mantenimiento.Items.AddRange(new object[] {
            ""});
            this.lst_mantenimiento.Location = new System.Drawing.Point(402, 32);
            this.lst_mantenimiento.Name = "lst_mantenimiento";
            this.lst_mantenimiento.Size = new System.Drawing.Size(249, 160);
            this.lst_mantenimiento.TabIndex = 14;
            this.lst_mantenimiento.Click += new System.EventHandler(this.lst_mantenimiento_Click);
            // 
            // MIFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(679, 375);
            this.Controls.Add(this.lst_mantenimiento);
            this.Controls.Add(this.grb_botonoes_principales);
            this.Controls.Add(this.grb_mantenimiento);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MIFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIFormulario";
            this.Load += new System.EventHandler(this.MIFormulario_Load);
            this.grb_mantenimiento.ResumeLayout(false);
            this.grb_mantenimiento.PerformLayout();
            this.grb_botonoes_principales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grb_mantenimiento;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_botonoes_principales;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.ListBox lst_mantenimiento;
    }
}
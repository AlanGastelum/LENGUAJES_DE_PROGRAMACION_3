namespace Expediente_de_Alumno
{
    partial class frmExpediente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpediente));
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lstEstados = new System.Windows.Forms.ListBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbHorarios = new System.Windows.Forms.GroupBox();
            this.rbVespertino = new System.Windows.Forms.RadioButton();
            this.rbMatutino = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            this.gbHorarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.White;
            this.gbDatos.Controls.Add(this.lstEstados);
            this.gbDatos.Controls.Add(this.lblEstado);
            this.gbDatos.Controls.Add(this.txtDireccion);
            this.gbDatos.Controls.Add(this.txtFechaNacimiento);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lblDireccion);
            this.gbDatos.Controls.Add(this.lblFechaNacimiento);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gbDatos.Location = new System.Drawing.Point(20, 60);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDatos.Size = new System.Drawing.Size(400, 400);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del alumno";
            this.gbDatos.Enter += new System.EventHandler(this.gbDatos_Enter);
            // 
            // lstEstados
            // 
            this.lstEstados.BackColor = System.Drawing.Color.White;
            this.lstEstados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEstados.ForeColor = System.Drawing.Color.Black;
            this.lstEstados.FormattingEnabled = true;
            this.lstEstados.ItemHeight = 25;
            this.lstEstados.Items.AddRange(new object[] {
            "Aguascalientes",
            "Baja California",
            "Baja California Sur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "Ciudad de México",
            "Coahuila",
            "Colima",
            "Durango",
            "Estado de México",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "Michoacán",
            "Morelos",
            "Nayarit",
            "Nuevo León",
            "Oaxaca",
            "Puebla",
            "Querétaro",
            "Quintana Roo",
            "San Luis Potosí",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz",
            "Yucatán",
            "Zacatecas"});
            this.lstEstados.Location = new System.Drawing.Point(20, 240);
            this.lstEstados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstEstados.Name = "lstEstados";
            this.lstEstados.Size = new System.Drawing.Size(340, 104);
            this.lstEstados.TabIndex = 7;
            this.lstEstados.SelectedIndexChanged += new System.EventHandler(this.lstEstados_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.ForeColor = System.Drawing.Color.Navy;
            this.lblEstado.Location = new System.Drawing.Point(20, 215);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(71, 25);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(20, 180);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(340, 31);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.BackColor = System.Drawing.Color.White;
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimiento.ForeColor = System.Drawing.Color.Black;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(20, 120);
            this.txtFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(340, 31);
            this.txtFechaNacimiento.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(20, 60);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(340, 31);
            this.txtNombre.TabIndex = 3;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.ForeColor = System.Drawing.Color.Navy;
            this.lblDireccion.Location = new System.Drawing.Point(20, 155);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(94, 25);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.Navy;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(20, 95);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(328, 25);
            this.lblFechaNacimiento.TabIndex = 1;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento (DD/MM/AAAA):";
            this.lblFechaNacimiento.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.ForeColor = System.Drawing.Color.Navy;
            this.lblNombre.Location = new System.Drawing.Point(20, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(172, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Completo:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbHorarios
            // 
            this.gbHorarios.BackColor = System.Drawing.Color.White;
            this.gbHorarios.Controls.Add(this.rbVespertino);
            this.gbHorarios.Controls.Add(this.rbMatutino);
            this.gbHorarios.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHorarios.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gbHorarios.Location = new System.Drawing.Point(450, 60);
            this.gbHorarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbHorarios.Name = "gbHorarios";
            this.gbHorarios.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbHorarios.Size = new System.Drawing.Size(220, 150);
            this.gbHorarios.TabIndex = 8;
            this.gbHorarios.TabStop = false;
            this.gbHorarios.Text = "Horarios";
            // 
            // rbVespertino
            // 
            this.rbVespertino.AutoSize = true;
            this.rbVespertino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVespertino.ForeColor = System.Drawing.Color.Black;
            this.rbVespertino.Location = new System.Drawing.Point(25, 75);
            this.rbVespertino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbVespertino.Name = "rbVespertino";
            this.rbVespertino.Size = new System.Drawing.Size(121, 29);
            this.rbVespertino.TabIndex = 1;
            this.rbVespertino.Text = "Vespertino";
            this.rbVespertino.UseVisualStyleBackColor = true;
            // 
            // rbMatutino
            // 
            this.rbMatutino.AutoSize = true;
            this.rbMatutino.Checked = true;
            this.rbMatutino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMatutino.ForeColor = System.Drawing.Color.Black;
            this.rbMatutino.Location = new System.Drawing.Point(25, 40);
            this.rbMatutino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMatutino.Name = "rbMatutino";
            this.rbMatutino.Size = new System.Drawing.Size(109, 29);
            this.rbMatutino.TabIndex = 0;
            this.rbMatutino.TabStop = true;
            this.rbMatutino.Text = "Matutino";
            this.rbMatutino.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(679, 420);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 40);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(828, 494);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbHorarios);
            this.Controls.Add(this.gbDatos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmExpediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expediente de alumno";
            this.Load += new System.EventHandler(this.frmExpediente_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbHorarios.ResumeLayout(false);
            this.gbHorarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ListBox lstEstados;
        private System.Windows.Forms.GroupBox gbHorarios;
        private System.Windows.Forms.RadioButton rbVespertino;
        private System.Windows.Forms.RadioButton rbMatutino;
        private System.Windows.Forms.Button btnGuardar;
    }
}


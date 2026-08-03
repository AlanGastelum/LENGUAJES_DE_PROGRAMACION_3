namespace Actividad_2.Formularios
{
    partial class frmInformacionPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformacionPersonal));
            this.pnlSombra = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDatosPersonales = new System.Windows.Forms.TabPage();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabDatosClinicos = new System.Windows.Forms.TabPage();
            this.pnlAlergia = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbAlergiaSi = new System.Windows.Forms.RadioButton();
            this.rdbAlergiaNo = new System.Windows.Forms.RadioButton();
            this.cmbAlergia = new System.Windows.Forms.ComboBox();
            this.pnlEnfermedad = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbEnfermedadSi = new System.Windows.Forms.RadioButton();
            this.rdbEnfermedadNo = new System.Windows.Forms.RadioButton();
            this.cmbEnfermedad = new System.Windows.Forms.ComboBox();
            this.pnlOperacion = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbOperacionSi = new System.Windows.Forms.RadioButton();
            this.rdbOperacionNo = new System.Windows.Forms.RadioButton();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.pnlDepresion = new System.Windows.Forms.Panel();
            this.rdbDepresionNo = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.rdbDepresionSi = new System.Windows.Forms.RadioButton();
            this.pnlEjercicio = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.rdbEjercicioSi = new System.Windows.Forms.RadioButton();
            this.rdbEjercicioNo = new System.Windows.Forms.RadioButton();
            this.cmbEjercicio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInfo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDatosPersonales.SuspendLayout();
            this.tabDatosClinicos.SuspendLayout();
            this.pnlAlergia.SuspendLayout();
            this.pnlEnfermedad.SuspendLayout();
            this.pnlOperacion.SuspendLayout();
            this.pnlDepresion.SuspendLayout();
            this.pnlEjercicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSombra
            // 
            this.pnlSombra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.pnlSombra.Location = new System.Drawing.Point(115, 85);
            this.pnlSombra.Name = "pnlSombra";
            this.pnlSombra.Size = new System.Drawing.Size(760, 480);
            this.pnlSombra.TabIndex = 0;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.btnRegresar);
            this.pnlInfo.Controls.Add(this.tabControl1);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Location = new System.Drawing.Point(110, 80);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(760, 480);
            this.pnlInfo.TabIndex = 1;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(93)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(320, 433);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(140, 40);
            this.btnRegresar.TabIndex = 20;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDatosPersonales);
            this.tabControl1.Controls.Add(this.tabDatosClinicos);
            this.tabControl1.Location = new System.Drawing.Point(32, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 360);
            this.tabControl1.TabIndex = 1;
            // 
            // tabDatosPersonales
            // 
            this.tabDatosPersonales.Controls.Add(this.dtpFechaNacimiento);
            this.tabDatosPersonales.Controls.Add(this.label5);
            this.tabDatosPersonales.Controls.Add(this.txtApellidoMaterno);
            this.tabDatosPersonales.Controls.Add(this.label4);
            this.tabDatosPersonales.Controls.Add(this.txtApellidoPaterno);
            this.tabDatosPersonales.Controls.Add(this.label3);
            this.tabDatosPersonales.Controls.Add(this.txtNombre);
            this.tabDatosPersonales.Controls.Add(this.label2);
            this.tabDatosPersonales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.tabDatosPersonales.Location = new System.Drawing.Point(4, 29);
            this.tabDatosPersonales.Name = "tabDatosPersonales";
            this.tabDatosPersonales.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatosPersonales.Size = new System.Drawing.Size(692, 327);
            this.tabDatosPersonales.TabIndex = 0;
            this.tabDatosPersonales.Text = "Datos Personales";
            this.tabDatosPersonales.UseVisualStyleBackColor = true;
            this.tabDatosPersonales.Click += new System.EventHandler(this.tabDatosPersonales_Click);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpFechaNacimiento.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpFechaNacimiento.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(35, 256);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(293, 31);
            this.dtpFechaNacimiento.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.BackColor = System.Drawing.Color.White;
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.ForeColor = System.Drawing.Color.Black;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(35, 186);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(240, 31);
            this.txtApellidoMaterno.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(35, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido Materno";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.BackColor = System.Drawing.Color.White;
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.ForeColor = System.Drawing.Color.Black;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(35, 116);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(240, 31);
            this.txtApellidoPaterno.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(35, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Paterno";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(35, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 31);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(35, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // tabDatosClinicos
            // 
            this.tabDatosClinicos.Controls.Add(this.pnlAlergia);
            this.tabDatosClinicos.Controls.Add(this.pnlEnfermedad);
            this.tabDatosClinicos.Controls.Add(this.pnlOperacion);
            this.tabDatosClinicos.Controls.Add(this.pnlDepresion);
            this.tabDatosClinicos.Controls.Add(this.pnlEjercicio);
            this.tabDatosClinicos.Location = new System.Drawing.Point(4, 29);
            this.tabDatosClinicos.Name = "tabDatosClinicos";
            this.tabDatosClinicos.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatosClinicos.Size = new System.Drawing.Size(692, 327);
            this.tabDatosClinicos.TabIndex = 1;
            this.tabDatosClinicos.Text = "Datos Clínicos";
            this.tabDatosClinicos.UseVisualStyleBackColor = true;
            // 
            // pnlAlergia
            // 
            this.pnlAlergia.Controls.Add(this.label7);
            this.pnlAlergia.Controls.Add(this.rdbAlergiaSi);
            this.pnlAlergia.Controls.Add(this.rdbAlergiaNo);
            this.pnlAlergia.Controls.Add(this.cmbAlergia);
            this.pnlAlergia.Location = new System.Drawing.Point(6, 96);
            this.pnlAlergia.Name = "pnlAlergia";
            this.pnlAlergia.Size = new System.Drawing.Size(670, 45);
            this.pnlAlergia.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.label7.Location = new System.Drawing.Point(2, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "¿Tienes alergias?";
            // 
            // rdbAlergiaSi
            // 
            this.rdbAlergiaSi.AutoSize = true;
            this.rdbAlergiaSi.BackColor = System.Drawing.Color.Transparent;
            this.rdbAlergiaSi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlergiaSi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(93)))));
            this.rdbAlergiaSi.Location = new System.Drawing.Point(176, 11);
            this.rdbAlergiaSi.Name = "rdbAlergiaSi";
            this.rdbAlergiaSi.Size = new System.Drawing.Size(51, 29);
            this.rdbAlergiaSi.TabIndex = 6;
            this.rdbAlergiaSi.TabStop = true;
            this.rdbAlergiaSi.Text = "Si";
            this.rdbAlergiaSi.UseVisualStyleBackColor = false;
            this.rdbAlergiaSi.CheckedChanged += new System.EventHandler(this.rdbAlergiaSi_CheckedChanged);
            // 
            // rdbAlergiaNo
            // 
            this.rdbAlergiaNo.AutoSize = true;
            this.rdbAlergiaNo.BackColor = System.Drawing.Color.Transparent;
            this.rdbAlergiaNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlergiaNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(93)))));
            this.rdbAlergiaNo.Location = new System.Drawing.Point(236, 11);
            this.rdbAlergiaNo.Name = "rdbAlergiaNo";
            this.rdbAlergiaNo.Size = new System.Drawing.Size(61, 29);
            this.rdbAlergiaNo.TabIndex = 7;
            this.rdbAlergiaNo.TabStop = true;
            this.rdbAlergiaNo.Text = "No";
            this.rdbAlergiaNo.UseVisualStyleBackColor = false;
            this.rdbAlergiaNo.CheckedChanged += new System.EventHandler(this.rdbAlergiaNo_CheckedChanged);
            // 
            // cmbAlergia
            // 
            this.cmbAlergia.BackColor = System.Drawing.Color.White;
            this.cmbAlergia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlergia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlergia.Items.AddRange(new object[] {
            "Polvo",
            "Polen",
            "Medicamentos",
            "Alimentos"});
            this.cmbAlergia.Location = new System.Drawing.Point(304, 9);
            this.cmbAlergia.Name = "cmbAlergia";
            this.cmbAlergia.Size = new System.Drawing.Size(220, 33);
            this.cmbAlergia.TabIndex = 5;
            // 
            // pnlEnfermedad
            // 
            this.pnlEnfermedad.Controls.Add(this.label6);
            this.pnlEnfermedad.Controls.Add(this.rdbEnfermedadSi);
            this.pnlEnfermedad.Controls.Add(this.rdbEnfermedadNo);
            this.pnlEnfermedad.Controls.Add(this.cmbEnfermedad);
            this.pnlEnfermedad.Location = new System.Drawing.Point(6, 32);
            this.pnlEnfermedad.Name = "pnlEnfermedad";
            this.pnlEnfermedad.Size = new System.Drawing.Size(682, 52);
            this.pnlEnfermedad.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.label6.Location = new System.Drawing.Point(2, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "¿Padeces de alguna enfermedad?";
            // 
            // rdbEnfermedadSi
            // 
            this.rdbEnfermedadSi.AutoSize = true;
            this.rdbEnfermedadSi.BackColor = System.Drawing.Color.Transparent;
            this.rdbEnfermedadSi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEnfermedadSi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(93)))));
            this.rdbEnfermedadSi.Location = new System.Drawing.Point(324, 11);
            this.rdbEnfermedadSi.Name = "rdbEnfermedadSi";
            this.rdbEnfermedadSi.Size = new System.Drawing.Size(51, 29);
            this.rdbEnfermedadSi.TabIndex = 2;
            this.rdbEnfermedadSi.TabStop = true;
            this.rdbEnfermedadSi.Text = "Si";
            this.rdbEnfermedadSi.UseVisualStyleBackColor = false;
            this.rdbEnfermedadSi.CheckedChanged += new System.EventHandler(this.rdbEnfermedadSi_CheckedChanged);
            // 
            // rdbEnfermedadNo
            // 
            this.rdbEnfermedadNo.AutoSize = true;
            this.rdbEnfermedadNo.BackColor = System.Drawing.Color.Transparent;
            this.rdbEnfermedadNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEnfermedadNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(93)))));
            this.rdbEnfermedadNo.Location = new System.Drawing.Point(384, 11);
            this.rdbEnfermedadNo.Name = "rdbEnfermedadNo";
            this.rdbEnfermedadNo.Size = new System.Drawing.Size(61, 29);
            this.rdbEnfermedadNo.TabIndex = 3;
            this.rdbEnfermedadNo.TabStop = true;
            this.rdbEnfermedadNo.Text = "No";
            this.rdbEnfermedadNo.UseVisualStyleBackColor = false;
            this.rdbEnfermedadNo.CheckedChanged += new System.EventHandler(this.rdbEnfermedadNo_CheckedChanged);
            // 
            // cmbEnfermedad
            // 
            this.cmbEnfermedad.BackColor = System.Drawing.Color.White;
            this.cmbEnfermedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnfermedad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEnfermedad.Items.AddRange(new object[] {
            "Diabetes",
            "Hipertensión",
            "Asma",
            "Cardiopatía"});
            this.cmbEnfermedad.Location = new System.Drawing.Point(456, 10);
            this.cmbEnfermedad.Name = "cmbEnfermedad";
            this.cmbEnfermedad.Size = new System.Drawing.Size(220, 33);
            this.cmbEnfermedad.TabIndex = 0;
            // 
            // pnlOperacion
            // 
            this.pnlOperacion.Controls.Add(this.label8);
            this.pnlOperacion.Controls.Add(this.rdbOperacionSi);
            this.pnlOperacion.Controls.Add(this.rdbOperacionNo);
            this.pnlOperacion.Controls.Add(this.cmbOperacion);
            this.pnlOperacion.Location = new System.Drawing.Point(6, 152);
            this.pnlOperacion.Name = "pnlOperacion";
            this.pnlOperacion.Size = new System.Drawing.Size(670, 45);
            this.pnlOperacion.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.label8.Location = new System.Drawing.Point(2, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "¿Alguna vez te han operado?";
            // 
            // rdbOperacionSi
            // 
            this.rdbOperacionSi.AutoSize = true;
            this.rdbOperacionSi.BackColor = System.Drawing.Color.Transparent;
            this.rdbOperacionSi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOperacionSi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(93)))));
            this.rdbOperacionSi.Location = new System.Drawing.Point(286, 11);
            this.rdbOperacionSi.Name = "rdbOperacionSi";
            this.rdbOperacionSi.Size = new System.Drawing.Size(51, 29);
            this.rdbOperacionSi.TabIndex = 10;
            this.rdbOperacionSi.TabStop = true;
            this.rdbOperacionSi.Text = "Si";
            this.rdbOperacionSi.UseVisualStyleBackColor = false;
            this.rdbOperacionSi.CheckedChanged += new System.EventHandler(this.rdbOperacionSi_CheckedChanged);
            // 
            // rdbOperacionNo
            // 
            this.rdbOperacionNo.AutoSize = true;
            this.rdbOperacionNo.BackColor = System.Drawing.Color.Transparent;
            this.rdbOperacionNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOperacionNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(93)))));
            this.rdbOperacionNo.Location = new System.Drawing.Point(346, 11);
            this.rdbOperacionNo.Name = "rdbOperacionNo";
            this.rdbOperacionNo.Size = new System.Drawing.Size(61, 29);
            this.rdbOperacionNo.TabIndex = 11;
            this.rdbOperacionNo.TabStop = true;
            this.rdbOperacionNo.Text = "No";
            this.rdbOperacionNo.UseVisualStyleBackColor = false;
            this.rdbOperacionNo.CheckedChanged += new System.EventHandler(this.rdbOperacionNo_CheckedChanged);
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.BackColor = System.Drawing.Color.White;
            this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperacion.ForeColor = System.Drawing.Color.Black;
            this.cmbOperacion.Items.AddRange(new object[] {
            "Apendicitis",
            "Cesárea",
            "Rodilla",
            "Columna"});
            this.cmbOperacion.Location = new System.Drawing.Point(416, 8);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(220, 33);
            this.cmbOperacion.TabIndex = 9;
            this.cmbOperacion.SelectedIndexChanged += new System.EventHandler(this.cmbOperacion_SelectedIndexChanged);
            // 
            // pnlDepresion
            // 
            this.pnlDepresion.Controls.Add(this.rdbDepresionNo);
            this.pnlDepresion.Controls.Add(this.label10);
            this.pnlDepresion.Controls.Add(this.rdbDepresionSi);
            this.pnlDepresion.Location = new System.Drawing.Point(6, 264);
            this.pnlDepresion.Name = "pnlDepresion";
            this.pnlDepresion.Size = new System.Drawing.Size(670, 45);
            this.pnlDepresion.TabIndex = 21;
            // 
            // rdbDepresionNo
            // 
            this.rdbDepresionNo.AutoSize = true;
            this.rdbDepresionNo.BackColor = System.Drawing.Color.Transparent;
            this.rdbDepresionNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDepresionNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(93)))));
            this.rdbDepresionNo.Location = new System.Drawing.Point(296, 11);
            this.rdbDepresionNo.Name = "rdbDepresionNo";
            this.rdbDepresionNo.Size = new System.Drawing.Size(61, 29);
            this.rdbDepresionNo.TabIndex = 19;
            this.rdbDepresionNo.TabStop = true;
            this.rdbDepresionNo.Text = "No";
            this.rdbDepresionNo.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.label10.Location = new System.Drawing.Point(2, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 28);
            this.label10.TabIndex = 16;
            this.label10.Text = "¿Padeces de depresión?";
            // 
            // rdbDepresionSi
            // 
            this.rdbDepresionSi.AutoSize = true;
            this.rdbDepresionSi.BackColor = System.Drawing.Color.Transparent;
            this.rdbDepresionSi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDepresionSi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(93)))));
            this.rdbDepresionSi.Location = new System.Drawing.Point(236, 11);
            this.rdbDepresionSi.Name = "rdbDepresionSi";
            this.rdbDepresionSi.Size = new System.Drawing.Size(51, 29);
            this.rdbDepresionSi.TabIndex = 18;
            this.rdbDepresionSi.TabStop = true;
            this.rdbDepresionSi.Text = "Si";
            this.rdbDepresionSi.UseVisualStyleBackColor = false;
            // 
            // pnlEjercicio
            // 
            this.pnlEjercicio.Controls.Add(this.label9);
            this.pnlEjercicio.Controls.Add(this.rdbEjercicioSi);
            this.pnlEjercicio.Controls.Add(this.rdbEjercicioNo);
            this.pnlEjercicio.Controls.Add(this.cmbEjercicio);
            this.pnlEjercicio.Location = new System.Drawing.Point(6, 208);
            this.pnlEjercicio.Name = "pnlEjercicio";
            this.pnlEjercicio.Size = new System.Drawing.Size(670, 45);
            this.pnlEjercicio.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.label9.Location = new System.Drawing.Point(2, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 28);
            this.label9.TabIndex = 12;
            this.label9.Text = "¿Haces ejercicio?";
            // 
            // rdbEjercicioSi
            // 
            this.rdbEjercicioSi.AutoSize = true;
            this.rdbEjercicioSi.BackColor = System.Drawing.Color.Transparent;
            this.rdbEjercicioSi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEjercicioSi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(93)))));
            this.rdbEjercicioSi.Location = new System.Drawing.Point(176, 12);
            this.rdbEjercicioSi.Name = "rdbEjercicioSi";
            this.rdbEjercicioSi.Size = new System.Drawing.Size(51, 29);
            this.rdbEjercicioSi.TabIndex = 14;
            this.rdbEjercicioSi.TabStop = true;
            this.rdbEjercicioSi.Text = "Si";
            this.rdbEjercicioSi.UseVisualStyleBackColor = false;
            this.rdbEjercicioSi.CheckedChanged += new System.EventHandler(this.rdbEjercicioSi_CheckedChanged);
            // 
            // rdbEjercicioNo
            // 
            this.rdbEjercicioNo.AutoSize = true;
            this.rdbEjercicioNo.BackColor = System.Drawing.Color.Transparent;
            this.rdbEjercicioNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEjercicioNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(93)))));
            this.rdbEjercicioNo.Location = new System.Drawing.Point(236, 12);
            this.rdbEjercicioNo.Name = "rdbEjercicioNo";
            this.rdbEjercicioNo.Size = new System.Drawing.Size(61, 29);
            this.rdbEjercicioNo.TabIndex = 15;
            this.rdbEjercicioNo.TabStop = true;
            this.rdbEjercicioNo.Text = "No";
            this.rdbEjercicioNo.UseVisualStyleBackColor = false;
            this.rdbEjercicioNo.CheckedChanged += new System.EventHandler(this.rdbEjercicioNo_CheckedChanged);
            // 
            // cmbEjercicio
            // 
            this.cmbEjercicio.BackColor = System.Drawing.Color.White;
            this.cmbEjercicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEjercicio.ForeColor = System.Drawing.Color.Black;
            this.cmbEjercicio.Items.AddRange(new object[] {
            "Diario",
            "3 veces por semana",
            "Fin de semana",
            "Ocasionalmente"});
            this.cmbEjercicio.Location = new System.Drawing.Point(304, 9);
            this.cmbEjercicio.Name = "cmbEjercicio";
            this.cmbEjercicio.Size = new System.Drawing.Size(220, 33);
            this.cmbEjercicio.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(168, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Información Personal";
            // 
            // frmInformacionPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 594);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlSombra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInformacionPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información Personal";
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabDatosPersonales.ResumeLayout(false);
            this.tabDatosPersonales.PerformLayout();
            this.tabDatosClinicos.ResumeLayout(false);
            this.pnlAlergia.ResumeLayout(false);
            this.pnlAlergia.PerformLayout();
            this.pnlEnfermedad.ResumeLayout(false);
            this.pnlEnfermedad.PerformLayout();
            this.pnlOperacion.ResumeLayout(false);
            this.pnlOperacion.PerformLayout();
            this.pnlDepresion.ResumeLayout(false);
            this.pnlDepresion.PerformLayout();
            this.pnlEjercicio.ResumeLayout(false);
            this.pnlEjercicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSombra;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDatosPersonales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbEnfermedadSi;
        private System.Windows.Forms.RadioButton rdbEnfermedadNo;
        private System.Windows.Forms.ComboBox cmbEnfermedad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAlergia;
        private System.Windows.Forms.RadioButton rdbAlergiaNo;
        private System.Windows.Forms.RadioButton rdbAlergiaSi;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.RadioButton rdbOperacionNo;
        private System.Windows.Forms.RadioButton rdbOperacionSi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEjercicio;
        private System.Windows.Forms.RadioButton rdbEjercicioNo;
        private System.Windows.Forms.RadioButton rdbEjercicioSi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdbDepresionNo;
        private System.Windows.Forms.RadioButton rdbDepresionSi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TabPage tabDatosClinicos;
        private System.Windows.Forms.Panel pnlEnfermedad;
        private System.Windows.Forms.Panel pnlAlergia;
        private System.Windows.Forms.Panel pnlOperacion;
        private System.Windows.Forms.Panel pnlEjercicio;
        private System.Windows.Forms.Panel pnlDepresion;
    }
}
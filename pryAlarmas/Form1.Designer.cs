namespace pryAlarmas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDni = new Label();
            lblDireccion = new Label();
            lblEspacios = new Label();
            lblTablero = new Label();
            lblControlar = new Label();
            lblApp = new Label();
            btnSubir = new Button();
            txtDNI = new TextBox();
            txtDireccion = new TextBox();
            chkSI = new CheckBox();
            chkNO = new CheckBox();
            chkControl = new CheckBox();
            chkLLAVES = new CheckBox();
            chkApertar = new CheckBox();
            chkDenegar = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            gbRegistro = new GroupBox();
            lblNumero = new Label();
            lblFecha = new Label();
            lblDetalle = new Label();
            lblDire = new Label();
            txtNumero = new TextBox();
            panel1 = new Panel();
            gbRegistroAnual = new GroupBox();
            txtDirecc = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            gbRegistro.SuspendLayout();
            gbRegistroAnual.SuspendLayout();
            SuspendLayout();
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(9, 29);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(84, 15);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI del cliente";
            lblDni.Click += label1_Click;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(9, 73);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(145, 15);
            lblDireccion.TabIndex = 1;
            lblDireccion.Text = "Direccion de la instalacion";
            lblDireccion.Click += lblDireccion_Click;
            // 
            // lblEspacios
            // 
            lblEspacios.AutoSize = true;
            lblEspacios.Location = new Point(261, 29);
            lblEspacios.Name = "lblEspacios";
            lblEspacios.Size = new Size(112, 15);
            lblEspacios.TabIndex = 2;
            lblEspacios.Text = "Espacios a proteger ";
            // 
            // lblTablero
            // 
            lblTablero.AutoSize = true;
            lblTablero.Location = new Point(5, 129);
            lblTablero.Name = "lblTablero";
            lblTablero.Size = new Size(88, 15);
            lblTablero.TabIndex = 7;
            lblTablero.Text = "Tablero general";
            // 
            // lblControlar
            // 
            lblControlar.AutoSize = true;
            lblControlar.Location = new Point(132, 129);
            lblControlar.Name = "lblControlar";
            lblControlar.Size = new Size(83, 15);
            lblControlar.TabIndex = 8;
            lblControlar.Text = "Controlar con:";
            // 
            // lblApp
            // 
            lblApp.AutoSize = true;
            lblApp.Location = new Point(289, 129);
            lblApp.Name = "lblApp";
            lblApp.Size = new Size(132, 15);
            lblApp.TabIndex = 9;
            lblApp.Text = "Controlas desde la App:";
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(365, 116);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(102, 44);
            btnSubir.TabIndex = 11;
            btnSubir.Text = "SUBIR REGISTRO";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(27, 47);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(158, 23);
            txtDNI.TabIndex = 12;
            txtDNI.TextChanged += txtDNI_TextChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(27, 91);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(271, 23);
            txtDireccion.TabIndex = 13;
            // 
            // chkSI
            // 
            chkSI.AutoSize = true;
            chkSI.Location = new Point(15, 161);
            chkSI.Name = "chkSI";
            chkSI.Size = new Size(34, 19);
            chkSI.TabIndex = 16;
            chkSI.Text = "si";
            chkSI.UseVisualStyleBackColor = true;
            // 
            // chkNO
            // 
            chkNO.AutoSize = true;
            chkNO.Location = new Point(55, 161);
            chkNO.Name = "chkNO";
            chkNO.Size = new Size(42, 19);
            chkNO.TabIndex = 17;
            chkNO.Text = "No";
            chkNO.UseVisualStyleBackColor = true;
            // 
            // chkControl
            // 
            chkControl.AutoSize = true;
            chkControl.Location = new Point(157, 153);
            chkControl.Name = "chkControl";
            chkControl.Size = new Size(77, 19);
            chkControl.TabIndex = 18;
            chkControl.Text = "Controles";
            chkControl.UseVisualStyleBackColor = true;
            // 
            // chkLLAVES
            // 
            chkLLAVES.AutoSize = true;
            chkLLAVES.Location = new Point(157, 178);
            chkLLAVES.Name = "chkLLAVES";
            chkLLAVES.Size = new Size(58, 19);
            chkLLAVES.TabIndex = 19;
            chkLLAVES.Text = "Llaves";
            chkLLAVES.UseVisualStyleBackColor = true;
            // 
            // chkApertar
            // 
            chkApertar.AutoSize = true;
            chkApertar.Location = new Point(338, 161);
            chkApertar.Name = "chkApertar";
            chkApertar.Size = new Size(35, 19);
            chkApertar.TabIndex = 20;
            chkApertar.Text = "Si";
            chkApertar.UseVisualStyleBackColor = true;
            // 
            // chkDenegar
            // 
            chkDenegar.AutoSize = true;
            chkDenegar.Location = new Point(379, 161);
            chkDenegar.Name = "chkDenegar";
            chkDenegar.Size = new Size(42, 19);
            chkDenegar.TabIndex = 21;
            chkDenegar.Text = "No";
            chkDenegar.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(313, 47);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(82, 23);
            numericUpDown1.TabIndex = 23;
            // 
            // gbRegistro
            // 
            gbRegistro.Controls.Add(numericUpDown1);
            gbRegistro.Controls.Add(chkDenegar);
            gbRegistro.Controls.Add(chkApertar);
            gbRegistro.Controls.Add(chkLLAVES);
            gbRegistro.Controls.Add(chkControl);
            gbRegistro.Controls.Add(chkNO);
            gbRegistro.Controls.Add(chkSI);
            gbRegistro.Controls.Add(txtDireccion);
            gbRegistro.Controls.Add(txtDNI);
            gbRegistro.Controls.Add(lblApp);
            gbRegistro.Controls.Add(lblControlar);
            gbRegistro.Controls.Add(lblTablero);
            gbRegistro.Controls.Add(lblEspacios);
            gbRegistro.Controls.Add(lblDireccion);
            gbRegistro.Controls.Add(lblDni);
            gbRegistro.Location = new Point(12, 21);
            gbRegistro.Name = "gbRegistro";
            gbRegistro.Size = new Size(481, 203);
            gbRegistro.TabIndex = 24;
            gbRegistro.TabStop = false;
            gbRegistro.Text = "Registro de Instalacion";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(10, 35);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(108, 15);
            lblNumero.TabIndex = 25;
            lblNumero.Text = "Numero de cliente:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(318, 35);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(100, 15);
            lblFecha.TabIndex = 26;
            lblFecha.Text = "Fecha de servicio:";
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Location = new Point(14, 79);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(110, 15);
            lblDetalle.TabIndex = 27;
            lblDetalle.Text = "Detalles de servicio:";
            lblDetalle.Click += lblDetalle_Click;
            // 
            // lblDire
            // 
            lblDire.AutoSize = true;
            lblDire.Location = new Point(124, 35);
            lblDire.Name = "lblDire";
            lblDire.Size = new Size(125, 15);
            lblDire.TabIndex = 28;
            lblDire.Text = "Direccion del serivicio:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(20, 53);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.Location = new Point(20, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 100);
            panel1.TabIndex = 32;
            panel1.Paint += panel1_Paint;
            // 
            // gbRegistroAnual
            // 
            gbRegistroAnual.Controls.Add(panel1);
            gbRegistroAnual.Controls.Add(txtDirecc);
            gbRegistroAnual.Controls.Add(textBox2);
            gbRegistroAnual.Controls.Add(txtNumero);
            gbRegistroAnual.Controls.Add(lblDire);
            gbRegistroAnual.Controls.Add(lblDetalle);
            gbRegistroAnual.Controls.Add(lblFecha);
            gbRegistroAnual.Controls.Add(lblNumero);
            gbRegistroAnual.Controls.Add(btnSubir);
            gbRegistroAnual.Location = new Point(7, 240);
            gbRegistroAnual.Name = "gbRegistroAnual";
            gbRegistroAnual.Size = new Size(486, 207);
            gbRegistroAnual.TabIndex = 33;
            gbRegistroAnual.TabStop = false;
            gbRegistroAnual.Text = "Registro de servicio anual";
            // 
            // txtDirecc
            // 
            txtDirecc.Location = new Point(126, 53);
            txtDirecc.Name = "txtDirecc";
            txtDirecc.Size = new Size(188, 23);
            txtDirecc.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(320, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 23);
            textBox2.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 450);
            Controls.Add(gbRegistroAnual);
            Controls.Add(gbRegistro);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            gbRegistro.ResumeLayout(false);
            gbRegistro.PerformLayout();
            gbRegistroAnual.ResumeLayout(false);
            gbRegistroAnual.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDni;
        private Label lblDireccion;
        private Label lblEspacios;
        private Label lblTablero;
        private Label lblControlar;
        private Label lblApp;
        private Button btnSubir;
        private TextBox txtDNI;
        private TextBox txtDireccion;
        private CheckBox chkSI;
        private CheckBox chkNO;
        private CheckBox chkControl;
        private CheckBox chkLLAVES;
        private CheckBox chkApertar;
        private CheckBox chkDenegar;
        private NumericUpDown numericUpDown1;
        private GroupBox gbRegistro;
        private Label lblNumero;
        private Label lblFecha;
        private Label lblDetalle;
        private Label lblDire;
        private TextBox txtNumero;
        private Panel panel1;
        private GroupBox gbRegistroAnual;
        private TextBox txtDirecc;
        private TextBox textBox2;
    }
}

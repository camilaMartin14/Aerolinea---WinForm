namespace Aerolínea.Presentacion
{
    partial class Aviones
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
            txtMatricula = new TextBox();
            txtModelo = new TextBox();
            txtCapacidad = new TextBox();
            txtAutonomia = new TextBox();
            dtpMantenimiento = new DateTimePicker();
            rbtActivo = new RadioButton();
            rbtInactivo = new RadioButton();
            chkDisponible = new CheckBox();
            cmbAeropuerto = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAceptar = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(99, 27);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(312, 27);
            txtMatricula.TabIndex = 0;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(99, 79);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(312, 27);
            txtModelo.TabIndex = 1;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(99, 133);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(312, 27);
            txtCapacidad.TabIndex = 2;
            // 
            // txtAutonomia
            // 
            txtAutonomia.Location = new Point(99, 189);
            txtAutonomia.Name = "txtAutonomia";
            txtAutonomia.Size = new Size(312, 27);
            txtAutonomia.TabIndex = 3;
            // 
            // dtpMantenimiento
            // 
            dtpMantenimiento.Location = new Point(99, 240);
            dtpMantenimiento.Name = "dtpMantenimiento";
            dtpMantenimiento.Size = new Size(312, 27);
            dtpMantenimiento.TabIndex = 4;
            // 
            // rbtActivo
            // 
            rbtActivo.AutoSize = true;
            rbtActivo.Location = new Point(106, 288);
            rbtActivo.Name = "rbtActivo";
            rbtActivo.Size = new Size(72, 24);
            rbtActivo.TabIndex = 5;
            rbtActivo.TabStop = true;
            rbtActivo.Text = "Activo";
            rbtActivo.UseVisualStyleBackColor = true;
            // 
            // rbtInactivo
            // 
            rbtInactivo.AutoSize = true;
            rbtInactivo.Location = new Point(205, 288);
            rbtInactivo.Name = "rbtInactivo";
            rbtInactivo.Size = new Size(82, 24);
            rbtInactivo.TabIndex = 6;
            rbtInactivo.TabStop = true;
            rbtInactivo.Text = "Inactivo";
            rbtInactivo.UseVisualStyleBackColor = true;
            // 
            // chkDisponible
            // 
            chkDisponible.AutoSize = true;
            chkDisponible.Location = new Point(106, 328);
            chkDisponible.Name = "chkDisponible";
            chkDisponible.Size = new Size(103, 24);
            chkDisponible.TabIndex = 7;
            chkDisponible.Text = "Disponible";
            chkDisponible.UseVisualStyleBackColor = true;
            // 
            // cmbAeropuerto
            // 
            cmbAeropuerto.FormattingEnabled = true;
            cmbAeropuerto.Location = new Point(99, 367);
            cmbAeropuerto.Name = "cmbAeropuerto";
            cmbAeropuerto.Size = new Size(312, 28);
            cmbAeropuerto.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 9;
            label1.Text = "Matrícula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 10;
            label2.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 11;
            label3.Text = "Capacidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 192);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 12;
            label4.Text = "Autonomía";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 370);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 13;
            label5.Text = "Aeropuerto";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(317, 428);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 39);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 245);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 15;
            label6.Text = "Mantenim.";
            // 
            // Aviones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 498);
            Controls.Add(label6);
            Controls.Add(btnAceptar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbAeropuerto);
            Controls.Add(chkDisponible);
            Controls.Add(rbtInactivo);
            Controls.Add(rbtActivo);
            Controls.Add(dtpMantenimiento);
            Controls.Add(txtAutonomia);
            Controls.Add(txtCapacidad);
            Controls.Add(txtModelo);
            Controls.Add(txtMatricula);
            Name = "Aviones";
            Text = "Aviones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatricula;
        private TextBox txtModelo;
        private TextBox txtCapacidad;
        private TextBox txtAutonomia;
        private DateTimePicker dtpMantenimiento;
        private RadioButton rbtActivo;
        private RadioButton rbtInactivo;
        private CheckBox chkDisponible;
        private ComboBox cmbAeropuerto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAceptar;
        private Label label6;
    }
}
namespace Aerolínea.Presentacion
{
    partial class FrmDetallesVuelos
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
            label6 = new Label();
            btnAceptar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbAvion = new ComboBox();
            dtpSalida = new DateTimePicker();
            txtDuracion = new TextBox();
            txtDescripcion = new TextBox();
            txtIdVuelo = new TextBox();
            cmbOrigen = new ComboBox();
            cmbDestino = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            dtpLlegada = new DateTimePicker();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 250);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 47;
            label6.Text = "Salida";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(348, 465);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 39);
            btnAceptar.TabIndex = 46;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 346);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 45;
            label5.Text = "Origen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 197);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 44;
            label4.Text = "Duración ";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 141);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 43;
            label3.Text = "Avión";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 87);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 42;
            label2.Text = "Descripción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 35);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 41;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // cmbAvion
            // 
            cmbAvion.FormattingEnabled = true;
            cmbAvion.Location = new Point(130, 138);
            cmbAvion.Name = "cmbAvion";
            cmbAvion.Size = new Size(312, 28);
            cmbAvion.TabIndex = 40;
            // 
            // dtpSalida
            // 
            dtpSalida.Location = new Point(130, 245);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(312, 27);
            dtpSalida.TabIndex = 36;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(130, 194);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(312, 27);
            txtDuracion.TabIndex = 35;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(130, 84);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(312, 27);
            txtDescripcion.TabIndex = 33;
            // 
            // txtIdVuelo
            // 
            txtIdVuelo.Location = new Point(130, 32);
            txtIdVuelo.Name = "txtIdVuelo";
            txtIdVuelo.Size = new Size(312, 27);
            txtIdVuelo.TabIndex = 32;
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Location = new Point(130, 343);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(312, 28);
            cmbOrigen.TabIndex = 48;
            // 
            // cmbDestino
            // 
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(130, 400);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(312, 28);
            cmbDestino.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 403);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 50;
            label7.Text = "Destino";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 299);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 52;
            label8.Text = "Llegada";
            // 
            // dtpLlegada
            // 
            dtpLlegada.Location = new Point(130, 294);
            dtpLlegada.Name = "dtpLlegada";
            dtpLlegada.Size = new Size(312, 27);
            dtpLlegada.TabIndex = 51;
            // 
            // FrmDetallesVuelos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 527);
            Controls.Add(label8);
            Controls.Add(dtpLlegada);
            Controls.Add(label7);
            Controls.Add(cmbDestino);
            Controls.Add(cmbOrigen);
            Controls.Add(label6);
            Controls.Add(btnAceptar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbAvion);
            Controls.Add(dtpSalida);
            Controls.Add(txtDuracion);
            Controls.Add(txtDescripcion);
            Controls.Add(txtIdVuelo);
            Name = "FrmDetallesVuelos";
            Text = "Todo sobre los vuelos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button btnAceptar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbAvion;
        private DateTimePicker dtpSalida;
        private TextBox txtDuracion;
        private TextBox txtDescripcion;
        private TextBox txtIdVuelo;
        private ComboBox cmbOrigen;
        private ComboBox cmbDestino;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpLlegada;
    }
}
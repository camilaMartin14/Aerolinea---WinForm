namespace Aerolínea.Presentacion
{
    partial class FrmVuelos
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbOrigen = new ComboBox();
            txtAvion = new TextBox();
            btnConsultar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            dgvVuelos = new DataGridView();
            label6 = new Label();
            cmbDestino = new ComboBox();
            dtpSalida = new DateTimePicker();
            dtpLlegada = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVuelos).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 120);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 29;
            label3.Text = "Aeropuerto Origen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 67);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 28;
            label2.Text = "Avión";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 25);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 27;
            label1.Text = "ID";
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Location = new Point(167, 112);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(250, 28);
            cmbOrigen.TabIndex = 26;
            // 
            // txtAvion
            // 
            txtAvion.Location = new Point(167, 64);
            txtAvion.Name = "txtAvion";
            txtAvion.Size = new Size(250, 27);
            txtAvion.TabIndex = 25;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(680, 163);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 38);
            btnConsultar.TabIndex = 21;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(227, 449);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 38);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(127, 449);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 38);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(27, 449);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 38);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dgvVuelos
            // 
            dgvVuelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVuelos.Location = new Point(27, 207);
            dgvVuelos.Name = "dgvVuelos";
            dgvVuelos.RowHeadersWidth = 51;
            dgvVuelos.Size = new Size(747, 224);
            dgvVuelos.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 163);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 34;
            label6.Text = "Aeropuerto Destino";
            // 
            // cmbDestino
            // 
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(167, 160);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(250, 28);
            cmbDestino.TabIndex = 35;
            // 
            // dtpSalida
            // 
            dtpSalida.Location = new Point(514, 22);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(250, 27);
            dtpSalida.TabIndex = 36;
            // 
            // dtpLlegada
            // 
            dtpLlegada.Location = new Point(514, 66);
            dtpLlegada.Name = "dtpLlegada";
            dtpLlegada.Size = new Size(250, 27);
            dtpLlegada.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(434, 25);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 38;
            label4.Text = "Salida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(434, 67);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 39;
            label5.Text = "Llegada";
            // 
            // txtID
            // 
            txtID.Location = new Point(167, 22);
            txtID.Name = "txtID";
            txtID.Size = new Size(250, 27);
            txtID.TabIndex = 22;
            // 
            // Vuelos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpLlegada);
            Controls.Add(dtpSalida);
            Controls.Add(cmbDestino);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbOrigen);
            Controls.Add(txtAvion);
            Controls.Add(txtID);
            Controls.Add(btnConsultar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvVuelos);
            Name = "Vuelos";
            Text = "Vuelos";
            ((System.ComponentModel.ISupportInitialize)dgvVuelos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbOrigen;
        private TextBox txtAvion;
        private Button btnConsultar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dgvVuelos;
        private Label label6;
        private ComboBox cmbDestino;
        private DateTimePicker dtpSalida;
        private DateTimePicker dtpLlegada;
        private Label label4;
        private Label label5;
        private TextBox txtID;
    }
}
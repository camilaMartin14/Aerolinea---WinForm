namespace Aerolínea.Presentacion
{
    partial class FrmTripulantes
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
            dgvTripulantes = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnConsultar = new Button();
            btnEliminar = new Button();
            txtDNI = new TextBox();
            rbtActivo = new RadioButton();
            rbtInactivo = new RadioButton();
            txtNombre = new TextBox();
            cmbProfesion = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbIdioma = new ComboBox();
            label4 = new Label();
            txtVuelo = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTripulantes).BeginInit();
            SuspendLayout();
            // 
            // dgvTripulantes
            // 
            dgvTripulantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTripulantes.Location = new Point(24, 213);
            dgvTripulantes.Name = "dgvTripulantes";
            dgvTripulantes.RowHeadersWidth = 51;
            dgvTripulantes.Size = new Size(747, 224);
            dgvTripulantes.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(24, 455);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 38);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(124, 455);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 38);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(677, 169);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 38);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(224, 455);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 38);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(137, 25);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(250, 27);
            txtDNI.TabIndex = 5;
            // 
            // rbtActivo
            // 
            rbtActivo.AutoSize = true;
            rbtActivo.Location = new Point(521, 26);
            rbtActivo.Name = "rbtActivo";
            rbtActivo.Size = new Size(72, 24);
            rbtActivo.TabIndex = 6;
            rbtActivo.TabStop = true;
            rbtActivo.Text = "Activo";
            rbtActivo.UseVisualStyleBackColor = true;
            // 
            // rbtInactivo
            // 
            rbtInactivo.AutoSize = true;
            rbtInactivo.Location = new Point(609, 26);
            rbtInactivo.Name = "rbtInactivo";
            rbtInactivo.Size = new Size(82, 24);
            rbtInactivo.TabIndex = 7;
            rbtInactivo.TabStop = true;
            rbtInactivo.Text = "Inactivo";
            rbtInactivo.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 8;
            // 
            // cmbProfesion
            // 
            cmbProfesion.FormattingEnabled = true;
            cmbProfesion.Location = new Point(137, 123);
            cmbProfesion.Name = "cmbProfesion";
            cmbProfesion.Size = new Size(250, 28);
            cmbProfesion.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 10;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 77);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 126);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 12;
            label3.Text = "Profesión";
            // 
            // cmbIdioma
            // 
            cmbIdioma.FormattingEnabled = true;
            cmbIdioma.Location = new Point(521, 123);
            cmbIdioma.Name = "cmbIdioma";
            cmbIdioma.Size = new Size(250, 28);
            cmbIdioma.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 126);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 14;
            label4.Text = "Idioma";
            // 
            // txtVuelo
            // 
            txtVuelo.Location = new Point(521, 74);
            txtVuelo.Name = "txtVuelo";
            txtVuelo.Size = new Size(250, 27);
            txtVuelo.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 77);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 16;
            label5.Text = "Vuelo";
            // 
            // Tripulación
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(label5);
            Controls.Add(txtVuelo);
            Controls.Add(label4);
            Controls.Add(cmbIdioma);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbProfesion);
            Controls.Add(txtNombre);
            Controls.Add(rbtInactivo);
            Controls.Add(rbtActivo);
            Controls.Add(txtDNI);
            Controls.Add(btnConsultar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvTripulantes);
            Name = "Tripulación";
            Text = "Tripulación";
            ((System.ComponentModel.ISupportInitialize)dgvTripulantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTripulantes;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnConsultar;
        private Button btnEliminar;
        private TextBox txtDNI;
        private RadioButton rbtActivo;
        private RadioButton rbtInactivo;
        private TextBox txtNombre;
        private ComboBox cmbProfesion;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbIdioma;
        private Label label4;
        private TextBox txtVuelo;
        private Label label5;
    }
}
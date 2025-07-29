namespace Aeropuerto
{
    partial class FrmPrincipal
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
            menuStrip1 = new MenuStrip();
            aeropuertosToolStripMenuItem = new ToolStripMenuItem();
            avionesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            añadirToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            borrarToolStripMenuItem = new ToolStripMenuItem();
            mostrarInformaciónToolStripMenuItem = new ToolStripMenuItem();
            añadirToolStripMenuItem1 = new ToolStripMenuItem();
            activarDesactivarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aeropuertosToolStripMenuItem, avionesToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aeropuertosToolStripMenuItem
            // 
            aeropuertosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { añadirToolStripMenuItem, editarToolStripMenuItem, borrarToolStripMenuItem, mostrarInformaciónToolStripMenuItem });
            aeropuertosToolStripMenuItem.Name = "aeropuertosToolStripMenuItem";
            aeropuertosToolStripMenuItem.Size = new Size(105, 24);
            aeropuertosToolStripMenuItem.Text = "Aeropuertos";
            // 
            // avionesToolStripMenuItem
            // 
            avionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { añadirToolStripMenuItem1, activarDesactivarToolStripMenuItem, eliminarToolStripMenuItem });
            avionesToolStripMenuItem.Name = "avionesToolStripMenuItem";
            avionesToolStripMenuItem.Size = new Size(75, 24);
            avionesToolStripMenuItem.Text = "Aviones";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(19, 62);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 24);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Privado";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(123, 62);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(79, 24);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Público";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(580, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(510, 66);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(748, 291);
            dataGridView1.TabIndex = 5;
            // 
            // añadirToolStripMenuItem
            // 
            añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            añadirToolStripMenuItem.Size = new Size(227, 26);
            añadirToolStripMenuItem.Text = "Añadir";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(227, 26);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // borrarToolStripMenuItem
            // 
            borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            borrarToolStripMenuItem.Size = new Size(227, 26);
            borrarToolStripMenuItem.Text = "Eliminar";
            // 
            // mostrarInformaciónToolStripMenuItem
            // 
            mostrarInformaciónToolStripMenuItem.Name = "mostrarInformaciónToolStripMenuItem";
            mostrarInformaciónToolStripMenuItem.Size = new Size(227, 26);
            mostrarInformaciónToolStripMenuItem.Text = "Mostrar información";
            // 
            // añadirToolStripMenuItem1
            // 
            añadirToolStripMenuItem1.Name = "añadirToolStripMenuItem1";
            añadirToolStripMenuItem1.Size = new Size(224, 26);
            añadirToolStripMenuItem1.Text = "Añadir";
            // 
            // activarDesactivarToolStripMenuItem
            // 
            activarDesactivarToolStripMenuItem.Name = "activarDesactivarToolStripMenuItem";
            activarDesactivarToolStripMenuItem.Size = new Size(224, 26);
            activarDesactivarToolStripMenuItem.Text = "Editar";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(224, 26);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aeropuertosToolStripMenuItem;
        private ToolStripMenuItem avionesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private RadioButton radioButton1;
        private ToolStripMenuItem añadirToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem borrarToolStripMenuItem;
        private ToolStripMenuItem mostrarInformaciónToolStripMenuItem;
        private ToolStripMenuItem añadirToolStripMenuItem1;
        private ToolStripMenuItem activarDesactivarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
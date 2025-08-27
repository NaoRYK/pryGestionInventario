namespace pryGestionInventario
{
    partial class frmMain
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
            lblGreetings = new Label();
            btnModificar = new Button();
            btnFiltrar = new Button();
            btnReportes = new Button();
            btnStock = new Button();
            SuspendLayout();
            // 
            // lblGreetings
            // 
            lblGreetings.AutoSize = true;
            lblGreetings.Location = new Point(93, 23);
            lblGreetings.Name = "lblGreetings";
            lblGreetings.Size = new Size(171, 15);
            lblGreetings.TabIndex = 0;
            lblGreetings.Text = "Clickee una opcion para operar";
            lblGreetings.Click += label1_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(31, 99);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(146, 23);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar productos";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(214, 99);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(154, 23);
            btnFiltrar.TabIndex = 2;
            btnFiltrar.Text = "Filtrar productos";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(214, 146);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(154, 23);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "Generar reporte";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            btnStock.Location = new Point(31, 146);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(146, 23);
            btnStock.TabIndex = 4;
            btnStock.Text = "Controlar stock";
            btnStock.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 210);
            Controls.Add(btnStock);
            Controls.Add(btnReportes);
            Controls.Add(btnFiltrar);
            Controls.Add(btnModificar);
            Controls.Add(lblGreetings);
            Name = "frmMain";
            Text = "Sistema de gestion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGreetings;
        private Button btnModificar;
        private Button btnFiltrar;
        private Button btnReportes;
        private Button btnStock;
    }
}

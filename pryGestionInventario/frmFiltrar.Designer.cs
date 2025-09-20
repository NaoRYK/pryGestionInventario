namespace pryGestionInventario
{
    partial class frmFiltrar
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
            txtProductName = new TextBox();
            btnCancelar_modificar = new Button();
            lblFiltrar = new Label();
            lstFiltros = new ComboBox();
            lblFiltrarPor = new Label();
            lblFiltroCategoria = new Label();
            lstCategorias = new ComboBox();
            label1 = new Label();
            lstViewProductos = new ListView();
            btnFiltrar = new Button();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(12, 64);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Nombre o codigo";
            txtProductName.Size = new Size(195, 23);
            txtProductName.TabIndex = 0;
            // 
            // btnCancelar_modificar
            // 
            btnCancelar_modificar.Location = new Point(326, 380);
            btnCancelar_modificar.Name = "btnCancelar_modificar";
            btnCancelar_modificar.Size = new Size(75, 23);
            btnCancelar_modificar.TabIndex = 12;
            btnCancelar_modificar.Text = "Cancelar";
            btnCancelar_modificar.UseVisualStyleBackColor = true;
            btnCancelar_modificar.Click += btnCancelar_modificar_Click;
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.Font = new Font("Segoe UI", 15F);
            lblFiltrar.Location = new Point(148, 9);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(157, 28);
            lblFiltrar.TabIndex = 13;
            lblFiltrar.Text = "Filtrar Productos";
            // 
            // lstFiltros
            // 
            lstFiltros.FormattingEnabled = true;
            lstFiltros.Items.AddRange(new object[] { "Nombre", "Codigo", "Categoria" });
            lstFiltros.Location = new Point(213, 64);
            lstFiltros.Name = "lstFiltros";
            lstFiltros.Size = new Size(92, 23);
            lstFiltros.TabIndex = 14;
            // 
            // lblFiltrarPor
            // 
            lblFiltrarPor.AutoSize = true;
            lblFiltrarPor.Location = new Point(240, 46);
            lblFiltrarPor.Name = "lblFiltrarPor";
            lblFiltrarPor.Size = new Size(37, 15);
            lblFiltrarPor.TabIndex = 15;
            lblFiltrarPor.Text = "Filtro:";
            // 
            // lblFiltroCategoria
            // 
            lblFiltroCategoria.AutoSize = true;
            lblFiltroCategoria.Location = new Point(326, 46);
            lblFiltroCategoria.Name = "lblFiltroCategoria";
            lblFiltroCategoria.Size = new Size(61, 15);
            lblFiltroCategoria.TabIndex = 16;
            lblFiltroCategoria.Text = "Categoria:";
            // 
            // lstCategorias
            // 
            lstCategorias.FormattingEnabled = true;
            lstCategorias.Items.AddRange(new object[] { "Nombre", "Codigo", "Categoria" });
            lstCategorias.Location = new Point(311, 64);
            lstCategorias.Name = "lstCategorias";
            lstCategorias.Size = new Size(92, 23);
            lstCategorias.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 46);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 18;
            label1.Text = "Nombre o código";
            // 
            // lstViewProductos
            // 
            lstViewProductos.Location = new Point(12, 93);
            lstViewProductos.Name = "lstViewProductos";
            lstViewProductos.Size = new Size(391, 281);
            lstViewProductos.TabIndex = 19;
            lstViewProductos.UseCompatibleStateImageBehavior = false;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(23, 380);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 20;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // frmFiltrar
            // 
            AcceptButton = btnFiltrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar_modificar;
            ClientSize = new Size(420, 415);
            Controls.Add(btnFiltrar);
            Controls.Add(lstViewProductos);
            Controls.Add(label1);
            Controls.Add(lstCategorias);
            Controls.Add(lblFiltroCategoria);
            Controls.Add(lblFiltrarPor);
            Controls.Add(lstFiltros);
            Controls.Add(lblFiltrar);
            Controls.Add(btnCancelar_modificar);
            Controls.Add(txtProductName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmFiltrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtrar";
            Load += frmFiltrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductName;
        private Button btnCancelar_modificar;
        private Label lblFiltrar;
        private ComboBox lstFiltros;
        private Label lblFiltrarPor;
        private Label lblFiltroCategoria;
        private ComboBox lstCategorias;
        private Label label1;
        private ListView lstViewProductos;
        private Button btnFiltrar;
    }
}
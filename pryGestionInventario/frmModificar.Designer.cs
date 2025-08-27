namespace pryGestionInventario
{
    partial class frmModificar
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
            txtCargarProducto = new Label();
            txtProductName = new TextBox();
            txtProductCode = new TextBox();
            txtProductPrice = new TextBox();
            txtProductStock = new TextBox();
            lstCategorias_modificar = new ComboBox();
            txtOperaciones = new Label();
            lstProductos_modificar = new ComboBox();
            label1 = new Label();
            btnDeleteProduct = new Button();
            btnEditProduct = new Button();
            SuspendLayout();
            // 
            // txtCargarProducto
            // 
            txtCargarProducto.AutoSize = true;
            txtCargarProducto.Location = new Point(37, 34);
            txtCargarProducto.Name = "txtCargarProducto";
            txtCargarProducto.Size = new Size(94, 15);
            txtCargarProducto.TabIndex = 0;
            txtCargarProducto.Text = "Cargar producto";
            txtCargarProducto.Click += label1_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(39, 87);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Nombre del producto";
            txtProductName.Size = new Size(100, 23);
            txtProductName.TabIndex = 1;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(40, 124);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(100, 23);
            txtProductCode.TabIndex = 2;
            txtProductCode.Text = "Codigo del producto";
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(39, 165);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(104, 23);
            txtProductPrice.TabIndex = 3;
            txtProductPrice.Text = "Precio del producto";
            // 
            // txtProductStock
            // 
            txtProductStock.Location = new Point(39, 201);
            txtProductStock.Name = "txtProductStock";
            txtProductStock.PlaceholderText = "Cantidad de stock";
            txtProductStock.Size = new Size(114, 23);
            txtProductStock.TabIndex = 4;
            // 
            // lstCategorias_modificar
            // 
            lstCategorias_modificar.FormattingEnabled = true;
            lstCategorias_modificar.Location = new Point(37, 230);
            lstCategorias_modificar.Name = "lstCategorias_modificar";
            lstCategorias_modificar.Size = new Size(121, 23);
            lstCategorias_modificar.TabIndex = 5;
            // 
            // txtOperaciones
            // 
            txtOperaciones.AutoSize = true;
            txtOperaciones.Location = new Point(274, 34);
            txtOperaciones.Name = "txtOperaciones";
            txtOperaciones.Size = new Size(102, 15);
            txtOperaciones.TabIndex = 6;
            txtOperaciones.Text = "Otras operaciones";
            // 
            // lstProductos_modificar
            // 
            lstProductos_modificar.FormattingEnabled = true;
            lstProductos_modificar.Location = new Point(265, 97);
            lstProductos_modificar.Name = "lstProductos_modificar";
            lstProductos_modificar.Size = new Size(121, 23);
            lstProductos_modificar.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 67);
            label1.Name = "label1";
            label1.Size = new Size(195, 15);
            label1.TabIndex = 8;
            label1.Text = "Seleccione un producto a modificar";
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(251, 146);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(75, 23);
            btnDeleteProduct.TabIndex = 9;
            btnDeleteProduct.Text = "Eliminar producto";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(332, 146);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(75, 23);
            btnEditProduct.TabIndex = 10;
            btnEditProduct.Text = "Editar";
            btnEditProduct.UseVisualStyleBackColor = true;
            // 
            // frmModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 264);
            Controls.Add(btnEditProduct);
            Controls.Add(btnDeleteProduct);
            Controls.Add(label1);
            Controls.Add(lstProductos_modificar);
            Controls.Add(txtOperaciones);
            Controls.Add(lstCategorias_modificar);
            Controls.Add(txtProductStock);
            Controls.Add(txtProductPrice);
            Controls.Add(txtProductCode);
            Controls.Add(txtProductName);
            Controls.Add(txtCargarProducto);
            Name = "frmModificar";
            Text = "frmModificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtCargarProducto;
        private TextBox txtProductName;
        private TextBox txtProductCode;
        private TextBox txtProductPrice;
        private TextBox txtProductStock;
        private ComboBox lstCategorias_modificar;
        private Label txtOperaciones;
        private ComboBox lstProductos_modificar;
        private Label label1;
        private Button btnDeleteProduct;
        private Button btnEditProduct;
    }
}
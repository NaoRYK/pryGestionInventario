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
            lblProductInfo = new Label();
            txtProductName = new TextBox();
            txtProductCode = new TextBox();
            lstCategorias_modificar = new ComboBox();
            txtOperaciones = new Label();
            lstProductos_modificar = new ComboBox();
            label1 = new Label();
            btnDeleteProduct = new Button();
            btnEditProduct = new Button();
            btnCancelar_modificar = new Button();
            btnUploadProduct = new Button();
            numProductPrice = new NumericUpDown();
            lblPrecio = new Label();
            numStock = new NumericUpDown();
            lblStock = new Label();
            lblName = new Label();
            lblCode = new Label();
            ((System.ComponentModel.ISupportInitialize)numProductPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // lblProductInfo
            // 
            lblProductInfo.AutoSize = true;
            lblProductInfo.Location = new Point(45, 34);
            lblProductInfo.Name = "lblProductInfo";
            lblProductInfo.Size = new Size(143, 15);
            lblProductInfo.TabIndex = 0;
            lblProductInfo.Text = "Informacion del producto";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(52, 59);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Nombre del producto";
            txtProductName.Size = new Size(100, 23);
            txtProductName.TabIndex = 1;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(53, 97);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.PlaceholderText = "Codigo del producto";
            txtProductCode.Size = new Size(100, 23);
            txtProductCode.TabIndex = 2;
            // 
            // lstCategorias_modificar
            // 
            lstCategorias_modificar.FormattingEnabled = true;
            lstCategorias_modificar.Location = new Point(52, 184);
            lstCategorias_modificar.Name = "lstCategorias_modificar";
            lstCategorias_modificar.Size = new Size(136, 23);
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
            lstProductos_modificar.SelectedIndexChanged += lstProductos_modificar_SelectedIndexChanged;
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
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(332, 146);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(75, 23);
            btnEditProduct.TabIndex = 10;
            btnEditProduct.Text = "Editar";
            btnEditProduct.UseVisualStyleBackColor = true;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnCancelar_modificar
            // 
            btnCancelar_modificar.Location = new Point(370, 229);
            btnCancelar_modificar.Name = "btnCancelar_modificar";
            btnCancelar_modificar.Size = new Size(75, 23);
            btnCancelar_modificar.TabIndex = 11;
            btnCancelar_modificar.Text = "Cancelar";
            btnCancelar_modificar.UseVisualStyleBackColor = true;
            btnCancelar_modificar.Click += btnCancelar_modificar_Click;
            // 
            // btnUploadProduct
            // 
            btnUploadProduct.Location = new Point(291, 175);
            btnUploadProduct.Name = "btnUploadProduct";
            btnUploadProduct.Size = new Size(75, 23);
            btnUploadProduct.TabIndex = 12;
            btnUploadProduct.Text = "Cargar";
            btnUploadProduct.UseVisualStyleBackColor = true;
            btnUploadProduct.Click += btnUploadProduct_Click;
            // 
            // numProductPrice
            // 
            numProductPrice.DecimalPlaces = 2;
            numProductPrice.Location = new Point(52, 126);
            numProductPrice.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numProductPrice.Name = "numProductPrice";
            numProductPrice.Size = new Size(101, 23);
            numProductPrice.TabIndex = 13;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(8, 128);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 14;
            lblPrecio.Text = "Precio";
            // 
            // numStock
            // 
            numStock.Location = new Point(52, 155);
            numStock.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(101, 23);
            numStock.TabIndex = 15;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(8, 157);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 16;
            lblStock.Text = "Stock";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(-2, 62);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 15);
            lblName.TabIndex = 17;
            lblName.Text = " Nombre";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(2, 100);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(46, 15);
            lblCode.TabIndex = 18;
            lblCode.Text = "Código";
            // 
            // frmModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 264);
            Controls.Add(lblCode);
            Controls.Add(lblName);
            Controls.Add(lblStock);
            Controls.Add(numStock);
            Controls.Add(lblPrecio);
            Controls.Add(numProductPrice);
            Controls.Add(btnUploadProduct);
            Controls.Add(btnCancelar_modificar);
            Controls.Add(btnEditProduct);
            Controls.Add(btnDeleteProduct);
            Controls.Add(label1);
            Controls.Add(lstProductos_modificar);
            Controls.Add(txtOperaciones);
            Controls.Add(lstCategorias_modificar);
            Controls.Add(txtProductCode);
            Controls.Add(txtProductName);
            Controls.Add(lblProductInfo);
            Name = "frmModificar";
            Text = "Modificar";
            Load += frmModificar_Load;
            ((System.ComponentModel.ISupportInitialize)numProductPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtCargarProducto;
        private TextBox txtProductName;
        private TextBox txtProductCode;
        private ComboBox lstCategorias_modificar;
        private Label txtOperaciones;
        private ComboBox lstProductos_modificar;
        private Label label1;
        private Button btnDeleteProduct;
        private Button btnEditProduct;
        private Button btnCancelar_modificar;
        private Button btnUploadProduct;
        private NumericUpDown numProductPrice;
        private Label lblPrecio;
        private NumericUpDown numStock;
        private Label lblStock;
        private Label lblName;
        private Label lblCode;
        private Label lblProductInfo;
    }
}
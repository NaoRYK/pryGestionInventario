using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionInventario
{
    public partial class frmModificar : Form
    {
        public frmModificar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnUploadProduct_Click(object sender, EventArgs e)
        {
            CrearProducto();

        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarCategorias();
        }


        private void btnCancelar_modificar_Click(object sender, EventArgs e)
        {
            FormHelper.VolverAlMain(this);
        }

        private void CargarCategorias()
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                string sql = "SELECT Id, Nombre FROM Categorias";
                OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lstCategorias_modificar.DataSource = dt;
                lstCategorias_modificar.DisplayMember = "Nombre"; // lo que se ve
                lstCategorias_modificar.ValueMember = "Id";       // el valor real
            }
        }

        private void CargarProductos()
        {
            using (var conn = dbConnection.GetConnection())
            {

                //Abro la conexion
                conn.Open();
                string sql = "SELECT Id,Codigo, Nombre FROM Productos";

                //Hago la consulta
                OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
                //Creo la dt para mostrar los datos
                DataTable dt = new DataTable();

                da.Fill(dt);


                //Producto 0 (vacio) para que no se me mezcle despues con editar
                DataRow nuevo = dt.NewRow();
                nuevo["Id"] = 0; // 
                nuevo["Codigo"] = "";
                nuevo["Nombre"] = "-- Ningún producto seleccionado --";
                dt.Rows.InsertAt(nuevo, 0);


                if (dt.Rows.Count > 0)
                {
                    //Para que los productos salgan en el combobox
                    lstProductos_modificar.DataSource = dt;
                    //Muestra solo la columna nombre de la db
                    lstProductos_modificar.DisplayMember = "Nombre";
                    //Pero le pongo el verdadero valor el codigo
                    lstProductos_modificar.ValueMember = "Id";

                }
                else
                {
                    // si no hay productos, limpio el combobox y muestro un mensaje
                    lstProductos_modificar.DataSource = null;
                    MessageBox.Show(" No hay productos cargados en la base de datos.", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }




            }

        }

        private void CrearProducto()
        {
            // verificamos que no estén vacíos los campos 
            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(numProductPrice.Text) ||
                lstCategorias_modificar.SelectedValue == null)
            {
                MessageBox.Show("Completa todos los campos antes de crear un producto.", "Inventario");
                return;
            }

            decimal precio = numProductPrice.Value;
            int stock = (int)numStock.Value;
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();

                // query de inserción, con parámetros para mayor seguridad
                string sql = "INSERT INTO Productos (Nombre, Precio, Stock, CategoriaId, Codigo) VALUES (?, ?, ?, ?,?)";

                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    // agregamos los valores en el mismo orden que los signos de interrogación (rd: no importa el nombre pero si el ordenporque la libreria lo pone en orden ignornado el nombre)
                    cmd.Parameters.AddWithValue("@Nombre", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@Stock", stock);
                    cmd.Parameters.AddWithValue("@CategoriaId", lstCategorias_modificar.SelectedValue);
                    cmd.Parameters.AddWithValue("@Codigo", txtProductCode.Text);

                    // ejecutamos la inserción
                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show("Producto creado correctamente.", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProductos(); // recargamos el combobox de productos
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear el producto.", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void EliminarProducto()
        {

            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM Productos WHERE Id = ?";

                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {

                    cmd.Parameters.AddWithValue("@Id", lstProductos_modificar.SelectedValue);
                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show("Producto eliminado correctamente.", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProductos(); // recargamos el combobox de productos
                    }
                    else
                    {
                        MessageBox.Show("No se pudo borrar el producto.", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void EditarProducto()
        {
            if (lstProductos_modificar.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un producto para editar.", "Inventario");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProductName.Text) || lstCategorias_modificar.SelectedValue == null)
            {
                MessageBox.Show("Completa todos los campos antes de editar.", "Inventario");
                return;
            }

            int idProducto = Convert.ToInt32(lstProductos_modificar.SelectedValue);
            decimal precio = numProductPrice.Value;
            int stock = (int)numStock.Value;

            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE Productos SET Nombre = ?, Precio = ?, Stock = ?, CategoriaId = ? WHERE Id = ?";
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@Stock", stock);
                    cmd.Parameters.AddWithValue("@CategoriaId", lstCategorias_modificar.SelectedValue);
                    cmd.Parameters.AddWithValue("@Id", idProducto);

                    int filas = cmd.ExecuteNonQuery();
                    if (filas > 0)
                    {
                        MessageBox.Show("Producto actualizado correctamente.", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProductos(); // recarga el ComboBox
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el producto.", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }




        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            EliminarProducto();

        }

        private void lstProductos_modificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProductos_modificar.SelectedValue == null) return;

            int idProducto = 0;

            //obtengo valor del cmbobox, lo vuelvo string para poder intentar convertirlo a numero, lo convierto a entero, si funciona se guarda en idProducto, si no devuelve false
            bool esNumero = int.TryParse(lstProductos_modificar.SelectedValue.ToString(), out idProducto);
            if (!esNumero)
                return;

            if (idProducto == 0)
            {
                //  "ningún producto seleccionado", limpiamos campos
                txtProductName.Clear();
                txtProductCode.Clear();
                numProductPrice.Value = 0;
                numStock.Value = 0;
                lstCategorias_modificar.SelectedIndex = 0; //  categoría por defecto
                return;
            }

            //  cargamos los datos
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                string sql = "SELECT Nombre,Codigo, Precio, Stock, CategoriaId FROM Productos WHERE Id = ?";
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", idProducto);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtProductName.Text = reader["Nombre"].ToString();
                            txtProductCode.Text = reader["Codigo"].ToString();
                            numProductPrice.Value = Convert.ToDecimal(reader["Precio"]);
                            numStock.Value = Convert.ToInt32(reader["Stock"]);
                            lstCategorias_modificar.SelectedValue = reader["CategoriaId"];
                        }
                    }
                }
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            EditarProducto();
        }
    }
}

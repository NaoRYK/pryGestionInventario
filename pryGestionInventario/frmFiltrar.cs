using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pryGestionInventario
{
    public partial class frmFiltrar : Form
    {
        public frmFiltrar()
        {
            InitializeComponent();
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

                lstCategorias.DataSource = dt;
                lstCategorias.DisplayMember = "Nombre"; // lo que se ve
                lstCategorias.ValueMember = "Id";       // el valor real
            }
        }

        private void btnCancelar_modificar_Click(object sender, EventArgs e)
        {

            FormHelper.VolverAlMain(this);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            BuscarProductos();
        }
        private void ConfigurarListView()
        {
            lstViewProductos.View = View.Details;
            lstViewProductos.FullRowSelect = true;
            lstViewProductos.GridLines = true;

            // Agregamos las columnas
            lstViewProductos.Columns.Add("Id", 50);
            lstViewProductos.Columns.Add("Código", 100);
            lstViewProductos.Columns.Add("Nombre", 150);
            lstViewProductos.Columns.Add("Precio", 80);
            lstViewProductos.Columns.Add("Stock", 80);
        }


        private void BuscarProductos()
        {

            string filterType = (string)lstFiltros.SelectedItem;
            char firstChar = char.ToUpper(filterType[0]);
            string restOfString = filterType.Substring(1);
            string formatedFilterType = firstChar + restOfString;

            string sql = $"'SELECT Id,Codigo,Nombre, Precio, Stock FROM Productos WHERE {formatedFilterType} = {txtProductName.Text}'";
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();

                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());

                        //  subcolumnas
                        item.SubItems.Add(reader["Codigo"].ToString());
                        item.SubItems.Add(reader["Nombre"].ToString());
                        item.SubItems.Add(reader["Precio"].ToString());
                        item.SubItems.Add(reader["Stock"].ToString());

                        // agrego item a la lstview
                        lstViewProductos.Items.Add(item);
                    }




                
            }
        }
        private void frmFiltrar_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            ConfigurarListView();
        }
    }
}

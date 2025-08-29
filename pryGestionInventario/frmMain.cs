namespace pryGestionInventario
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModificar frmMod = new frmModificar();
            frmMod.ShowDialog();

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFiltrar frmFiltrar = new frmFiltrar();
            frmFiltrar.ShowDialog();
        }
    }
}

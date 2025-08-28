namespace pryGestionInventario
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModificar frmMod = new frmModificar();
            frmMod.ShowDialog();

        }
    }
}

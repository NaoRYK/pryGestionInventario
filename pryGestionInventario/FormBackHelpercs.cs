using System.Windows.Forms;

namespace pryGestionInventario
{
    public static class FormHelper
    {
        public static void VolverAlMain(Form currentForm)
        {
            // cierro el form actual
            currentForm.Hide();

            // muestro el formulario principal
            frmMain main = new frmMain();
            main.ShowDialog();

        }
    }
}

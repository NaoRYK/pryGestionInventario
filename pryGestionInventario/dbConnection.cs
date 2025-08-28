using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;


namespace pryGestionInventario
{
    public static class dbConnection
    {
        private static string dbPath = Path.Combine(Application.StartupPath, "db", "Inventario.accdb");
        private static string connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False;";

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connStr);
        }
    }
}

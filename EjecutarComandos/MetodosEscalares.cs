using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace EjecutarComandos
{
    public partial class MetodosEscalares : Form
    {
        public MetodosEscalares()
        {
            InitializeComponent();
        }

        private void btnContarFilas_Click(object sender, EventArgs e)
        {
            //Crear la conexion
            SqlConnection conn = new SqlConnection(@"server = (local\)\sqlexpress;
                integrated security = true; database = AdventureWorks2014");

            //crear el query escalar
            string sql = @"SELECT COUNT(*)
                            FROM production.Product";

            //crear el comando
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                //establecer la conexion
                conn.Open();
                txtEscalar.AppendText("Comando Creado, Conexion Establecida\n");
                txtEscalar.AppendText("el numero de productos en Producion.Product es:");

                //ejecutar el query escalar
                txtEscalar.AppendText(cmd.ExecuteScalar().ToString());

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalle del error");
            }
            finally
            {
                //cerrar conexion
                conn.Close();
                txtEscalar.AppendText("\n Conexion Cerrada");
            }
        }
    }
}

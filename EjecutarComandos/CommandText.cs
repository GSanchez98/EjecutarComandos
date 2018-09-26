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
    public partial class CommandText : Form
    {
        public CommandText()
        {
            InitializeComponent();
        }

        private void CommandText_Load(object sender, EventArgs e)
        {
            //Crear la conexion
            SqlConnection conn = new SqlConnection(@"server = (local\)\sqlexpress;
                integrated security = true; database = AdventureWorks2014");
            //crear el comando
            SqlCommand cmd = new SqlCommand();

            try{
                //establecer la conexion
                conn.Open();
                txtCommandText.AppendText("Conexion Establecida\n");
                txtCommandText.AppendText("Comando creado. \n");

                //Estableciendo el valor del comando
                cmd.CommandText = @"SELECT Name, ProductNumber
                                    FROM Production.product";
                txtCommandText.AppendText("Listo paa la ejecucion del query SQL: \n\t\t" + cmd.CommandText);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalle de la excepcion");
            }
            finally
            {
                //cerrar conexion
                conn.Close();
                txtCommandText.AppendText("\n Conexion Cerrada");
            }
        }
    }
}

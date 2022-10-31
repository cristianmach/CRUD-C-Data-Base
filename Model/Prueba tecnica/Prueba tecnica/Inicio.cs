using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba_tecnica.models;
using Prueba_tecnica;
using System.Net.Sockets;

namespace Prueba_tecnica
{
    public partial class Inicio : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NK9JPBB;Initial Catalog=TablaCliente;Integrated Security=True");
        public Inicio()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            Form formC = new Clientes();
            formC.Show();

            this.Hide();
        }

        /*private void Refresh()
        {
            using (TablaClienteEntities1 db = new TablaClienteEntities1())
            {
                IQueryable<client> lst =
                     from d in db.TABLA_CLIENTES
                     select new client
                     {
                         IdCliente = d.IdCliente,
                         Nombres = d.Nombres,
                         Apellidos = d.Apellidos,
                         Direccion = d.Direccion
                     };
                Nombres.DataBindings = lst.
            }
        }*/
        private void search_Click(object sender, EventArgs e)
        {
            const string V = "";
            if (IdCliente.Text != V)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM TABLA_CLIENTES WHERE IdCliente = @IdCliente", connection);
                command.Parameters.AddWithValue("@IdCliente", IdCliente.Text);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IdCliente.Text = reader["IdCliente"].ToString();
                    Nombres.Text = reader["Nombres"].ToString();
                    Apellidos.Text = reader["Apellidos"].ToString();
                    Direccion.Text = reader["Direccion"].ToString();
                }
                else
                {
                    MessageBox.Show("El Cliente con el ID " + IdCliente.Text + " no existe");
                }
                connection.Close();
            }
            else
            {
                SqlCommand command1 = new SqlCommand("SELECT * FROM TABLA_CLIENTES WHERE Nombres = @Nombres", connection);
                command1.Parameters.AddWithValue("@Nombres", Nombres.Text);
                connection.Open();
                SqlDataReader reader1 = command1.ExecuteReader();
                if (reader1.Read())
                {
                    IdCliente.Text = reader1["IdCliente"].ToString();
                    Nombres.Text = reader1["Nombres"].ToString();
                    Apellidos.Text = reader1["Apellidos"].ToString();
                    Direccion.Text = reader1["Direccion"].ToString();
                }
                else if (Nombres.Text != V)
                {
                    MessageBox.Show("El Cliente " + Nombres.Text + " no existe");
                }
                else
                {
                    MessageBox.Show("Digite el campo ID CLIENTE o el campo NOMBRES para buscar");
                }
                connection.Close();
            }
        
            /*try
            {
                connection.Open();
                MessageBox.Show("Conectado a la Base de Datos");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectarse con la Base de Datos");*/
            }/*SqlConnection conect = new SqlConnection("SELECT * FROM TABLA_CLIENTES WHERE IdCliente=@IdCliente", conect);*/

        private void refresh_Click(object sender, EventArgs e)
        {
            dataBase reset = new dataBase();
            reset.Reset(this, panel2);
        }

        private void IdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo acepta numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}

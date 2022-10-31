using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba_tecnica.models;
using Prueba_tecnica;
using System.Data.SqlClient;
using System.Data.Entity;

namespace Prueba_tecnica
{
    public partial class Clientes : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NK9JPBB;Initial Catalog=TablaCliente;Integrated Security=True");
        public Clientes()
        {
            InitializeComponent();
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            Form formI = new Inicio();
            formI.Show();

            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refresh2_Click(object sender, EventArgs e)
        {
            dataBase reset = new dataBase();
            dataBase reset2 = new dataBase();
            reset.Reset(this, panel1);
            reset2.Reset(this, panel2);
            Refresh();

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh(string Search = null)
        {
            SqlCommand command = new SqlCommand("Select * from TABLA_CLIENTES", connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string V = "";
            if (IdCliente2.Text != V)
            { 
                SqlCommand command = new SqlCommand("SELECT * FROM TABLA_CLIENTES WHERE IdCliente = @IdCliente2", connection);
                command.Parameters.AddWithValue("@IdCliente2", IdCliente2.Text);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Nombres2.Text = reader["Nombres"].ToString();
                    Apellidos2.Text = reader["Apellidos"].ToString();
                    Direccion2.Text = reader["Direccion"].ToString();
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Digite el campo ID CLIENTE para seleccionar");
            }
            /*SqlCommand command = new SqlCommand("Select * from TABLA_CLIENTES", connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dbTable = new DataTable();
            adapter.Fill(dbTable);
            dataGridView1.DataSource = dbTable;*/

        }

        private void save_Click(object sender, EventArgs e)
        {
            const string V = "";
            if (IdCliente2.Text != V)
            {
                string query1 = "UPDATE TABLA_CLIENTES SET Nombres = @Nombres2, Apellidos = @Apellidos2, Direccion = @Direccion2 WHERE IdCliente = @IdCliente2";
                connection.Open();
                SqlCommand command1 = new SqlCommand(query1, connection);
                command1.Parameters.AddWithValue("@Nombres2", Nombres2.Text);
                command1.Parameters.AddWithValue("@Apellidos2", Apellidos2.Text);
                command1.Parameters.AddWithValue("@Direccion2", Direccion2.Text);
                command1.Parameters.AddWithValue("@IdCliente2", IdCliente2.Text);
                command1.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("La información del Cliente " + Nombres2.Text + " " + Apellidos2.Text + " se Actualizo correctamente.");
            }
            else if ((Nombres2.Text != V) && (Apellidos2.Text != V))
            {
                String query = "INSERT INTO TABLA_CLIENTES(Nombres, Apellidos, Direccion) VALUES (@Nombres, @Apellidos, @Direccion)";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombres", Nombres2.Text);
                command.Parameters.AddWithValue("@Apellidos", Apellidos2.Text);
                command.Parameters.AddWithValue("@Direccion", Direccion2.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("El Cliente " + Nombres2.Text + " " + Apellidos2.Text + " se guardo correctamente.");
            }
            else
            {
                MessageBox.Show("Digite los campos Nombre, Apellidos, Dirección, para Agregar un nuevo Cliente, o digite el ID CLIENTE y de clic en SELECCIONAR para Actualizar los datos del Cliente.");
            }
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            const string V = "";
            if (IdCliente2.Text != V)
            {
                string query = "DELETE FROM TABLA_CLIENTES WHERE IdCliente = @IdCliente2";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdCliente2", IdCliente2.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("El Cliente " + Nombres2.Text + " " + Apellidos2.Text + " fue eliminado.");
            }
            else
            {
                MessageBox.Show("Digite el ID CLIENTE y de clic en SELECCIONAR para poder eliminar un Cliente.");
            }
        }

        private void IdCliente2_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdCliente2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo acepta numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}

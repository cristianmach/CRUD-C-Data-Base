using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Prueba_tecnica
{
    internal class dataBase
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NK9JPBB;Initial Catalog=TablaCliente;Integrated Security=True");

        public void Reset(Control control, Panel panel)
        {
            foreach (var i in control.Controls)
                if (i is TextBox)
                {
                    ((TextBox)i).Clear();
                }
            foreach (var j in panel.Controls)
                if (j is TextBox)
                {
                    ((TextBox)j).Clear();
                }
        }
        /*public List<client> Get()
        {
            List<client> clients1 = new List<client>();

            string query = "select IdCliente, Nombres, Apellidos, Direccion from clients";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        client nclient = new client();
                        nclient.IdCliente = reader.GetInt32(0);
                        nclient.Nombres = reader.GetString(1);
                        nclient.Apellidos = reader.GetString(2);
                        nclient.Direccion = reader.GetString(3);
                        clients1.Add(nclient);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch(Exception ex)
                {
                    throw new Exception("Hay un error en la Base de Datos"+ ex.Message);
                }
            }

            return clients1;
        }*/
    }


public class client
    {
        public int IdCliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
    }
}


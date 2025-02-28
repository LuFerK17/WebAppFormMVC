using Microsoft.Data.SqlClient; // Cambia System.Data.SqlClient por Microsoft.Data.SqlClient
using Microsoft.Extensions.Configuration;

namespace WebAppFormMVC.Models
{
    public class ContactoR
    {
        private readonly string _connectionString;

        public ContactoR(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void GuardarContacto(Contacto contacto)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Contactos (Nombre, CorreoElectronico, Mensaje) VALUES (@Nombre, @CorreoElectronico, @Mensaje)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", contacto.Nombre);
                    command.Parameters.AddWithValue("@CorreoElectronico", contacto.CorreoElectronico);
                    command.Parameters.AddWithValue("@Mensaje", contacto.Mensaje);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

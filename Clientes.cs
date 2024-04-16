using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recuperar_contrasena
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new NpgsqlConnection();

        static string servidor = "localhost";
        static string db = "login_Software";
        static string usuario = "postgres";
        static string password = "J@s1115";
        static string puerto = "5433";

        string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + password + ";" + "Database=" + db + ";";

        public void dgvCargarDatos()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(cadenaConexion))
                {
                    conn.Open();

                    string query = "SELECT id as ID,nombre_usuario as Usuario, nombre as Nombre, apellido as apellido,\r\n telefono as Telefono, dia_nacimiento as Dia, mes_nacimiento as Mes,\r\n ano_nacimiento as Año, sexo as Sexo, Pais as Pais FROM usuarios";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dgvUsuarios.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos de los usuarios: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        public void Insertar()
        {


            if ((string.IsNullOrEmpty(tbxId.Text)))
            {
                try
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection(cadenaConexion)) // Use the connection string defined earlier
                    {
                        conn.Open();

                        string query = @"
                    INSERT INTO usuarios (
                    nombre_usuario,
                    nombre,
                    apellido,
                    telefono,
                    dia_nacimiento,
                    mes_nacimiento,
                    ano_nacimiento,
                    contrasena,
                    confirmacion_contrasena,
                    sexo,
                    pais
                    )
                VALUES (@nombreUsuario, @nombre, @apellido, @telefono, @diaNacimiento, @mesNacimiento, @anoNacimiento, @contrasena, @confirmacionContrasena, @sexo, @pais);";

                        using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                        {
                            string contrasena = tbxContrasena.Text;
                            string ConfirmacionContrasena = tbxConfirmacionContrasena.Text;

                            if (!contrasena.Equals(ConfirmacionContrasena, StringComparison.OrdinalIgnoreCase))
                            {
                                MessageBox.Show("Error: La contraseña y la confirmación de contraseña no coinciden.");
                                return;
                            }

                            int diaNacimiento;
                            if (int.TryParse(tbxDiaNacimiento.Text, out diaNacimiento))
                            {
                                command.Parameters.AddWithValue("@diaNacimiento", diaNacimiento);
                            }
                            else
                            {
                                MessageBox.Show("Error: 'Dia Nacimiento' Tiene que ser un dia valido.");
                                return;
                            }

                            int mesNacimiento;
                            if (int.TryParse(tbxMesNacimiento.Text, out mesNacimiento))
                            {
                                if (mesNacimiento < 1 || mesNacimiento > 12)
                                {
                                    MessageBox.Show("Error: 'Mes Nacimiento' Tiene que ser un numero entre 1 y 12.");
                                    return;
                                }
                                command.Parameters.AddWithValue("@mesNacimiento", mesNacimiento);
                            }
                            else
                            {
                                MessageBox.Show("Error: 'Mes Nacimiento' tiene que ser un numero valido.");
                                return;
                            }

                            int anoNacimiento;
                            if (int.TryParse(tbxAnoNacimiento.Text, out anoNacimiento))
                            {
                                if (anoNacimiento < 1890)
                                {
                                    MessageBox.Show("Error: Introduzca un año mayor a 1890.");
                                    return;
                                }
                                command.Parameters.AddWithValue("@anoNacimiento", anoNacimiento);
                            }
                            else
                            {
                                MessageBox.Show("Error: 'Año Nacimiento' tiene que ser un numero valido.");
                                return;
                            }

                            command.Parameters.AddWithValue("@nombreUsuario", tbxNombreUsuario.Text);
                            command.Parameters.AddWithValue("@nombre", tbxNombre.Text);
                            command.Parameters.AddWithValue("@apellido", tbxApellido.Text);
                            command.Parameters.AddWithValue("@contrasena", tbxContrasena.Text);
                            command.Parameters.AddWithValue("@confirmacionContrasena", tbxConfirmacionContrasena.Text);
                            command.Parameters.AddWithValue("@sexo", tbxSexo.Text);
                            command.Parameters.AddWithValue("@telefono", tbxTelefono.Text);
                            command.Parameters.AddWithValue("@pais", tbxPais.Text);

                            if (!string.IsNullOrEmpty(tbxId.Text))
                            {
                                command.Parameters.AddWithValue("@Id", tbxId.Text);
                            }

                            command.ExecuteNonQuery();
                            conn.Close();
                        }
                    }

                    MessageBox.Show("Usuario guardado exitosamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el usuario: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection(cadenaConexion))
                    {
                        connection.Open();

                        string query = @"
                UPDATE usuarios
                SET
                    nombre_usuario = @nombreUsuario,
                    nombre = @nombre,
                    apellido = @apellido,
                    dia_nacimiento = @diaNacimiento,
                    mes_nacimiento = @mesNacimiento,
                    ano_nacimiento = @anoNacimiento,
                    contrasena = @contrasena,
                    sexo = @sexo,
                    telefono = @telefono,
                    pais = @pais
                WHERE id = @idUsuario;
            ";

                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            string contrasena = tbxContrasena.Text;
                            string ConfirmacionContrasena = tbxConfirmacionContrasena.Text;

                            if (!contrasena.Equals(ConfirmacionContrasena, StringComparison.OrdinalIgnoreCase))
                            {
                                MessageBox.Show("Error: La contraseña y la confirmación de contraseña no coinciden.");
                                return;
                            }

                            int diaNacimiento;
                            if (int.TryParse(tbxDiaNacimiento.Text, out diaNacimiento))
                            {
                                command.Parameters.AddWithValue("@diaNacimiento", diaNacimiento);
                            }
                            else
                            {
                                MessageBox.Show("Error: 'Dia Nacimiento' Tiene que ser un dia valido.");
                                return;
                            }

                            int mesNacimiento;
                            if (int.TryParse(tbxMesNacimiento.Text, out mesNacimiento))
                            {
                                if (mesNacimiento < 1 || mesNacimiento > 12)
                                {
                                    MessageBox.Show("Error: 'Mes Nacimiento' Tiene que ser un numero entre 1 y 12.");
                                    return;
                                }
                                command.Parameters.AddWithValue("@mesNacimiento", mesNacimiento);
                            }
                            else
                            {
                                MessageBox.Show("Error: 'Mes Nacimiento' tiene que ser un numero valido.");
                                return;
                            }

                            int anoNacimiento;
                            if (int.TryParse(tbxAnoNacimiento.Text, out anoNacimiento))
                            {
                                if (anoNacimiento < 1890)
                                {
                                    MessageBox.Show("Error: Introduzca un año mayor a 1890.");
                                    return;
                                }
                                command.Parameters.AddWithValue("@anoNacimiento", anoNacimiento);
                            }
                            else
                            {
                                MessageBox.Show("Error: 'Año Nacimiento' tiene que ser un numero valido.");
                                return;
                            }

                            // Agrega el parámetro para el ID de usuario
                            command.Parameters.AddWithValue("@idUsuario", Convert.ToInt32(tbxId.Text));

                            command.Parameters.AddWithValue("@nombreUsuario", tbxNombreUsuario.Text);
                            command.Parameters.AddWithValue("@nombre", tbxNombre.Text);
                            command.Parameters.AddWithValue("@apellido", tbxApellido.Text);
                            command.Parameters.AddWithValue("@contrasena", tbxContrasena.Text);
                            command.Parameters.AddWithValue("@confirmacionContrasena", tbxConfirmacionContrasena.Text);
                            command.Parameters.AddWithValue("@sexo", tbxSexo.Text);
                            command.Parameters.AddWithValue("@telefono", tbxTelefono.Text);
                            command.Parameters.AddWithValue("@pais", tbxPais.Text);

                            // Ejecutar el comando
                            command.ExecuteNonQuery();

                            MessageBox.Show("Usuario editado exitosamente!");
                            conn.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar el usuario: " + ex.Message);
                }


            }
            limpiar();
        }



        private void Clientes_Load(object sender, EventArgs e)
        {
            dgvCargarDatos();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Insertar();
            dgvCargarDatos();

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];

                tbxId.Text = row.Cells[0].Value?.ToString() ?? "";
                tbxPais.Text = row.Cells[9].Value?.ToString() ?? "";
                tbxNombreUsuario.Text = row.Cells[1].Value?.ToString() ?? "";
                tbxNombre.Text = row.Cells[2].Value?.ToString() ?? "";
                tbxApellido.Text = row.Cells[3].Value?.ToString() ?? "";
                tbxDiaNacimiento.Text = row.Cells[5].Value?.ToString() ?? "";
                tbxMesNacimiento.Text = row.Cells[6].Value?.ToString() ?? "";
                tbxAnoNacimiento.Text = row.Cells[7].Value?.ToString() ?? "";
                tbxContrasena.Text = "";
                tbxConfirmacionContrasena.Text = "";
                tbxSexo.Text = row.Cells[8].Value?.ToString() ?? "";
                tbxTelefono.Text = row.Cells[4].Value?.ToString() ?? "";
                tbxPais.Text = row.Cells[9].Value?.ToString() ?? "";

            }
        }
        public void limpiar()
        {
            tbxId.Clear();
            tbxPais.Clear();
            tbxTelefono.Clear();
            tbxNombreUsuario.Clear();
            tbxDiaNacimiento.Clear();
            tbxMesNacimiento.Clear();
            tbxAnoNacimiento.Clear();
            tbxApellido.Clear();
            tbxContrasena.Clear();
            tbxConfirmacionContrasena.Clear();
            tbxSexo.Clear();
            tbxNombre.Clear();
            dgvUsuarios.ClearSelection();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxId.Text))
            {
                MessageBox.Show("Introduzca un ID válido.");
                return;
            }

            int id;
            if (!int.TryParse(tbxId.Text, out id))
            {
                MessageBox.Show("Introduzca un ID válido.");
                return;
            }

            if (id != 0)
            {
                DialogResult confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        using (NpgsqlConnection conn = new NpgsqlConnection(cadenaConexion))
                        {
                            conn.Open();

                            string query = "DELETE FROM usuarios WHERE id = @id";

                            using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@id", id);
                                command.ExecuteNonQuery();
                            }

                            dgvCargarDatos();
                        }
                        MessageBox.Show("Registro eliminado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Introduzca un ID válido.");
            }
        }
    }
}

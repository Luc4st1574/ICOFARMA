using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Security.Cryptography.X509Certificates;
using System.Collections;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using(SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select u.IdUsuario,u.Documento,u.NombreCompleto,u.Correo,u.Clave,u.Estado, u.Logged, r.IdRol,r.Descripcion from Usuario u inner join Rol r on r.IdRol = u.IdRol";

                    SqlCommand cmd = new SqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();

                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Usuario usuario = new Usuario();
                            usuario.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                            usuario.Documento = Convert.ToString(dr["Documento"]);
                            usuario.NombreCompleto = Convert.ToString(dr["NombreCompleto"]);
                            usuario.Correo = Convert.ToString(dr["Correo"]);
                            usuario.Clave = Convert.ToString(dr["Clave"]);
                            usuario.Estado = Convert.ToBoolean(dr["Estado"]);
                            usuario.oRol = new Rol();
                            usuario.oRol.IdRol = Convert.ToInt32(dr["IdRol"]);
                            usuario.oRol.Descripcion = Convert.ToString(dr["Descripcion"]);
                            usuario.Logged = Convert.ToBoolean(dr["Logged"]);

                            lista.Add(usuario);
                        }
                    }   
                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                    
                }
                return lista;
            }   

            


        }

        public int Registrar(Usuario obj, out string Mensaje) 
        { 
            int idUsuarioGenerado = 0;

            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena)) 
                {

                    SqlCommand cmd = new SqlCommand("sp_REGISTRARUSUARIO", oConexion);
                    cmd.Parameters.AddWithValue("Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("Clave", obj.Clave);
                    cmd.Parameters.AddWithValue("IdRol", obj.oRol.IdRol);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                   
                    cmd.Parameters.Add("IdUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                   

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    idUsuarioGenerado = Convert.ToInt32(cmd.Parameters["IdUsuarioResultado"].Value);
                    Mensaje = Convert.ToString(cmd.Parameters["Mensaje"].Value);

                }
            }
            catch (Exception ex)
            {
                idUsuarioGenerado = 0;
                Mensaje = ex.Message;
               
            }


            return idUsuarioGenerado;
        
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            bool Respuesta = false;

            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_EDITARUSUARIO", oConexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.IdUsuario);
                    cmd.Parameters.AddWithValue("Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("Clave", obj.Clave);
                    cmd.Parameters.AddWithValue("IdRol", obj.oRol.IdRol);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = Convert.ToString(cmd.Parameters["Mensaje"].Value);

                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;

            }


            return Respuesta;

        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            bool Respuesta = false;

            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_ELIMINARUSUARIO", oConexion);
                    cmd.Parameters.AddWithValue("@IdUsuario", obj.IdUsuario);

                   
                    
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    

                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;

            }


            return Respuesta;

        }
        public void ActualizarLoggedTrue(Usuario obj)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("ActualizarLoggedTrue", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdUsuario", obj.IdUsuario);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para actualizar Logged a False
        public void ActualizarLoggedFalse(Usuario obj)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("ActualizarLoggedFalse", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdUsuario", obj.IdUsuario);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

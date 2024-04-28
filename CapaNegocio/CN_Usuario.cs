using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using System.Security.Policy;

namespace CapaNegocio
{
    public class CN_Usuario
    {

        private CD_Usuario cdUsuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            return cdUsuario.Listar();
        }

        public int Registrar(Usuario obj, out string Mensaje) 
        {
            Mensaje = "";
            if (obj.Documento == "")
            {
                Mensaje = "El campo Documento es obligatorio";
                
            }
            if (obj.NombreCompleto == "")
            {
                Mensaje = "El campo Nombre Completo es obligatorio";
               
            }
            if (obj.Correo == "")
            {
                Mensaje = "El campo Correo es obligatorio";
               
            }
            if (obj.Clave == "")
            {
                Mensaje = "El campo Clave es obligatorio";
                
            }
            if (obj.oRol.IdRol == 0)
            {
                Mensaje = "El campo Rol es obligatorio";
                
            }

            if (Mensaje != string.Empty) 
            {
                return 0;
            }
            else
            {
                return cdUsuario.Registrar(obj, out Mensaje);
            }

        }
        
        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = "";
            if (obj.Documento == "")
            {
                Mensaje = "El campo Documento es obligatorio";

            }
            if (obj.NombreCompleto == "")
            {
                Mensaje = "El campo Nombre Completo es obligatorio";

            }
            if (obj.Correo == "")
            {
                Mensaje = "El campo Correo es obligatorio";

            }
            if (obj.Clave == "")
            {
                Mensaje = "El campo Clave es obligatorio";

            }
            if (obj.oRol.IdRol == 0)
            {
                Mensaje = "El campo Rol es obligatorio";

            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return cdUsuario.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return cdUsuario.Eliminar(obj, out Mensaje);
        }

        public void loggedtrue(Usuario obj)
        {
            cdUsuario.ActualizarLoggedTrue(obj);
        }

        public void loggedfalse(Usuario obj)
        {
            cdUsuario.ActualizarLoggedFalse(obj);
        }
    }
}

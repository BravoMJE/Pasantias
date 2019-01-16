using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasantiasProyecto
{
    abstract class Usuario
    {
        private int idUsuario;
        private string nombreUsuario;
        private string contrasenia;
        private string login;
        private string cedula;
        private string telefono;
        private string correoElectronico;
        

        protected int IdUsuario { get => idUsuario; set => idUsuario = value; }
        protected string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        protected string Contrasenia { get => contrasenia; set => contrasenia = value; }
        protected string Login { get => login; set => login = value; }
        protected string Cedula { get => cedula; set => cedula = value; }
        protected string Telefono { get => telefono; set => telefono = value; }
        protected string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }

        public Usuario(int idUsuario, string nombreUsuario, string contrasenia, string login, string cedula, string telefono, string correo)
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.contrasenia = contrasenia;
            this.login = login;
            this.cedula = cedula;
            this.telefono = telefono;
            this.correoElectronico = correo;
        }

        public Usuario()
        {
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joaquin_Curotto
{
    internal class Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string contrasena;
        private string mail;

        // Constructor
        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasena, string mail)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
            this.mail = mail;
        }

        // GETTERS & SETTERS
        public int GetId()
        {
            return this.id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetApellido()
        {
            return this.apellido;
        }

        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string GetNombreUsuario()
        {
            return this.nombreUsuario;
        }

        public void SetNombreUsuario(string nombreUsuario)
        {
            this.nombreUsuario = nombreUsuario;
        }

        public string GetContrasena()
        {
            return this.contrasena;
        }

        public void SetContrasena(string contrasena)
        {
            this.contrasena = contrasena;
        }

        public string GetMail()
        {
            return this.mail;
        }

        public void SetMail(string mail)
        {
            this.mail = mail;
        }

    }
}

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
        private String nombre;
        private String apellido;
        private String nombreUsuario;
        private String contrasena;
        private String mail;

        // Constructor
        public Usuario(int id, String nombre, String apellido, String nombreUsuario, String contrasena, String mail)
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

        public String GetNombre()
        {
            return this.nombre;
        }

        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String GetApellido()
        {
            return this.apellido;
        }

        public void SetApellido(String apellido)
        {
            this.apellido = apellido;
        }

        public String GetNombreUsuario()
        {
            return this.nombreUsuario;
        }

        public void SetNombreUsuario(String nombreUsuario)
        {
            this.nombreUsuario = nombreUsuario;
        }

        public String GetContrasena()
        {
            return this.contrasena;
        }

        public void SetContrasena(String contrasena)
        {
            this.contrasena = contrasena;
        }

        public String GetMail()
        {
            return this.mail;
        }

        public void SetMail(String mail)
        {
            this.mail = mail;
        }

    }
}

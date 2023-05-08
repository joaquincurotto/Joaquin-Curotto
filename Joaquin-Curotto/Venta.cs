using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joaquin_Curotto
{
    internal class Venta
    {
        private int id;
        private string comentarios;
        private int idUsuario;

        // Constructor
        public Venta(int id, string comentarios, int idUsuario)
        {
            this.id = id;
            this.comentarios = comentarios;
            this.idUsuario = idUsuario;
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

        public string GetComentarios()
        {
            return this.comentarios;
        }

        public void SetComentarios(string comentarios)
        {
            this.comentarios = comentarios;
        }

        public int GetIdUsuario()
        {
            return this.idUsuario;
        }

        public void SetIdUsuario(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }
    }
}

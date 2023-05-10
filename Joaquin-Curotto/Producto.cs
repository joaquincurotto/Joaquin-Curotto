using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joaquin_Curotto
{
    internal class Producto
    {
        private int id;
        private string descripcion;
        private decimal costo;
        private decimal precioVenta;
        private int stock;
        private int idUsuario;

        // Constructor
        public Producto(int id, string descripcion, decimal costo, decimal precioVenta, int stock, int idUsuario)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.costo = costo;
            this.precioVenta = precioVenta;
            this.stock = stock;
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

        public string GetDescripcion()
        {
            return this.descripcion;
        }

        public void SetDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public decimal GetCosto()
        {
            return this.costo;
        }

        public void SetCosto(decimal costo)
        {
            this.costo = costo;
        }

        public decimal GetPrecioVenta()
        {
            return this.precioVenta;
        }

        public void SetPrecioVenta(decimal precioVenta)
        {
            this.precioVenta = precioVenta;
        }

        public int GetStock()
        {
            return this.stock;
        }

        public void SetStock(int stock)
        {
            this.stock = stock;
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

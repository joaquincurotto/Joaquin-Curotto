using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joaquin_Curotto
{
    internal class ProductoVendido
    {
        private int id;
        private int idProducto;
        private int stock;
        private int idVenta;

        // Constructor
        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            this.id = id;
            this.idProducto = idProducto;
            this.stock = stock;
            this.idVenta = idVenta;
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

        public int GetIdProducto()
        {
            return this.idProducto;
        }

        public void SetIdProducto(int idProducto)
        {
            this.idProducto = idProducto;
        }

        public int GetStock()
        {
            return this.stock;
        }

        public void SetStock(int stock)
        {
            this.stock = stock;
        }

        public int GetIdVenta()
        {
            return this.idVenta;
        }

        public void SetIdVenta(int idVenta)
        {
            this.idVenta = idVenta;
        }
    }
}

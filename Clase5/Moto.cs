using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5
{
    internal class Moto : Vehiculo
    {
        protected int _cantCilindradas;

        public Moto()
        {
            this._cantCilindradas = 500;
        }

        public int CantCilindradas
        {
            get { return this._cantCilindradas; }
            set { this._cantCilindradas = value; }
        }

        //Con override estoy sobreescribiendo el metodo de la clase padre
        public override Vehiculo CargarDatosObjeto()
        {
            base.CargarDatosObjeto();
            this._cantCilindradas = 1200;

            //retorno el objeto MOTO
            return this;
        }
    }
}

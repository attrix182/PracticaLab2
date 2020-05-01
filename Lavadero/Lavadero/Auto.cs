using System;
using System.Collections.Generic;
using System.Text;

namespace Lavadero
{
    class Auto : Vehiculo
    {
        private int cantidadAsientos;

        private Auto(string patente, Byte cantRuedas, EMarcas marca, int cantidadAsientos) : base(patente, cantRuedas, marca)
        {
            this.cantidadAsientos = cantidadAsientos;

        }

        public string MostrarAuto()
        {
            
        }


    }
}

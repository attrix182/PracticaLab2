using System;
using System.Collections.Generic;
using System.Text;

namespace Lavadero
{
    class Camion : Vehiculo
    {
        float tara;


        private Camion(string patente, Byte cantRuedas, EMarcas marca, float tara) : base(patente, cantRuedas, marca)
        {
            this.tara = tara;

        }

    }
}

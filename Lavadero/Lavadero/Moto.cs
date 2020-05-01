using System;
using System.Collections.Generic;
using System.Text;

namespace Lavadero
{
    class Moto : Vehiculo
    {
        float cilindrada;


        private Moto(string patente, Byte cantRuedas, EMarcas marca, float cilindrada) : base(patente, cantRuedas, marca)
        {
            this.cilindrada = cilindrada;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lavadero
{
    class Vehiculo
    {
        protected string patente;
        protected byte cantRuedas;
        protected EMarcas marca;

        public Enum GetMarca() { return this.marca; }

        protected string Mostrar()
        {
            return "a";
        }

        public Vehiculo(string patente, Byte cantRuedas, EMarcas marca)
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool igualdad = false;

            if (v1.marca == v2.marca && v1.patente == v2.patente)
            { igualdad = true; }

            return igualdad;

        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }





    }
}

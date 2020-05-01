using System;
using System.Collections.Generic;
using System.Text;

namespace Lavadero
{
    class Lavadero
    {
        private List<Vehiculo> vehiculos = new List<Vehiculo>();
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;

        private Lavadero(float precioAuto, float precioCamion, float precioMoto)
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;

        }

        private Lavadero()
        {
            new List<Vehiculo>();
        }

        public double MostrarTotalFacturado()
        {

        }

        public static bool operator ==(Lavadero l1, Vehiculo v1)
        {
        }

        public static bool operator +(Lavadero l1, Vehiculo v1)
        {
        }

        public static bool operator -(Lavadero l1, Vehiculo v1)
        {
        }

        public static int ordenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {

        }

        public static int ordenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {

        }



    }
}

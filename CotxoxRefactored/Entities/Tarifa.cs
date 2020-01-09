using System;
using System.Collections.Generic;
using System.Text;

namespace CotxoxRefactored.Entities
{
    public class Tarifa
    {
        //Attributes
        private static double costeEsperado;
        private static readonly double costeMilla = 4;
        private static readonly double costeMinuto = 2;
        private static readonly double costeMinimo = 50;
        private readonly byte porcentajeComision = 20;

        public static double CalcularCosteEsperado(Carrera carrera)
        {
            costeEsperado = carrera.GetTiempoEsperado() * costeMinuto + carrera.GetDistancia() * costeMilla;

            if (costeEsperado > costeMinimo)
                return costeEsperado;
            else
                return costeMinimo;
        }
    }
}

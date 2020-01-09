using System;
using NUnit.Framework;
using CotxoxRefactored.Entities;

namespace CotxoxTests
{
    public class TarifaTests
    {
        //Objects
        Carrera carrera;
        string tarjetaCredito = "123456";


        //Tests
        [SetUp]
        public void ConstructorTestSetUp()
        {

            //Set up
            carrera = new Carrera(tarjetaCredito);

            //Assert
            Assert.AreEqual(carrera.GetTarjeta(), tarjetaCredito);
        }
        //Tests
        [Test]
        public void CalcularCosteEsperadoMinimoTest()
        {
            //Parameters
            double distancia = 5;
            int tiempoEstimado = 2;
            double costeMinimo = 50;
            
            //Setters
            carrera.SetDistancia(distancia);
            carrera.SetTiempoEsperado(tiempoEstimado);

            //Assert
            Assert.AreEqual(Tarifa.CalcularCosteEsperado(carrera), costeMinimo);
        }

        public void CalcularCosteEsperadoTest()
        {
            //Parameters
            double distancia = 10;
            int tiempoEstimado = 10;
            double costeEsperadoCorrecto = 60; //Calculado: (tiempoEsptimado * 2) + (distancia * 4)

            //Setters
            carrera.SetDistancia(distancia);
            carrera.SetTiempoEsperado(tiempoEstimado);

            //Assert
            Assert.AreEqual(Tarifa.CalcularCosteEsperado(carrera), costeEsperadoCorrecto);
        }

    }
}
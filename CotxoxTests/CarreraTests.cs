using System;
using NUnit.Framework;
using CotxoxRefactored.Entities;
using System.Collections.Generic;

namespace CotxoxTests
{
    public class CarreraTests
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

        [Test]
        public void GetTarjetaTest()
        {            
            //Assert
            Assert.AreEqual(carrera.GetTarjeta(), tarjetaCredito);
        }

        [Test]
        public void SetOriginTest()
        {
            //Set up
            string origen = "Aeropuerto";

            //Build up
            carrera.SetOrigen(origen);

            //Assert
            Assert.AreEqual(carrera.GetOrigin(), origen);
        }

        [Test]
        public void SetDestinoTest()
        {
            //Set up
            string destino = "Palma de Mallorca";

            //Build up
            carrera.SetDestino(destino);

            //Assert
            Assert.AreEqual(carrera.GetDestino(), destino);
        }

        [Test]
        public void SetDistanciaTest()
        {
            //Set up
            double distancia = 25;

            //Build up
            carrera.SetDistancia(distancia);

            //Assert
            Assert.AreEqual(carrera.GetDistancia(), distancia);
        }

        [Test]
        public void SetTiempoEsperadoTest()
        {
            //Set up
            int tiempoEstimado = 25;

            //Build up
            carrera.SetTiempoEsperado(tiempoEstimado);

            //Assert
            Assert.AreEqual(carrera.GetTiempoEsperado(), tiempoEstimado);
        }

        [Test]
        public void GetCosteEsperadoTest()
        {
            //Set up
            int tiempoEstimado = 10;
            double distancia = 20;
            double tiempoEsperado = 100; //Calculado: (tiempoEsptimado * 2) + (distancia * 4)

            //Build up
            carrera.SetTiempoEsperado(tiempoEstimado);
            carrera.SetDistancia(distancia);

            //Assert
            Assert.AreEqual(carrera.GetCosteEsperado(), tiempoEsperado);
        }


        [Test]
        public void AsignarConductorTest()
        {
            //Set up
            List<Conductor> listaConductores = new List<Conductor>();
            listaConductores.Add(new Conductor("Samanta"));

            PoolConductores poolConductores = new PoolConductores(listaConductores);
            
            //Build up
            carrera.AsignarConductor(poolConductores);

            //Assert
            Assert.AreEqual(poolConductores.GetPoolConductores()[0].IsOcupado(), true);
        }
    }
}
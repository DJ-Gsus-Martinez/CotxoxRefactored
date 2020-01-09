using System;
using NUnit.Framework;
using CotxoxRefactored.Entities;

namespace CotxoxTests
{
    public class ConductorTests
    {
        //Objects
        Conductor conductor;
        string nombre = "Amanda";


        //Test Before
        [SetUp]
        public void ConstructorTestSetUp()
        {

            //Set up
            conductor = new Conductor(nombre);

            //Assert
            Assert.AreEqual(conductor.GetNombre(), nombre);
        }

        //Tests
        [Test]
        public void GetNombreTest()
        {
            //Parameters
            double distancia = 5;

            //Setters
            conductor.GetNombre();

            //Assert
            Assert.AreEqual(conductor.GetNombre(), nombre);
        }

        [Test]
        public void SetMatriculaTest()
        {
            //Parameters
            string matricula = "4512LKC";

            //Setters
            conductor.SetMatricula(matricula);

            //Assert
            Assert.AreEqual(conductor.GetMatricula(), matricula);
        }

        [Test]
        public void SetModeloTest()
        {
            //Parameters
            string modelo = "Honda Civic";

            //Setters
            conductor.SetModelo(modelo);

            //Assert
            Assert.AreEqual(conductor.GetModelo(), modelo);
        }


        [Test]
        public void SetValoracionTest()
        {
            //Setters
            conductor.SetValoracion(4);

            //Assert
            Assert.AreEqual(conductor.GetValoracion(), 4);
        }
    }
}
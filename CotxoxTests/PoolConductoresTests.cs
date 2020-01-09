using System;
using NUnit.Framework;
using CotxoxRefactored.Entities;
using System.Collections.Generic;

namespace CotxoxTests
{
    public class PoolConductoresTests
    {
        //Objects
        PoolConductores poolConductores;
        List<Conductor> listaConductores = new List<Conductor>();

        //Tests
        [SetUp]
        public void PoolConductoresTestSetUp()
        {
            //Set up
            listaConductores.Add(new Conductor("Ramona"));
            poolConductores = new PoolConductores(listaConductores);

            //Assert
            Assert.AreEqual(poolConductores.GetPoolConductores().Count, 1);
        }

        [Test]
        public void GetPoolConductoresTest()
        {
            //Assert
            Assert.AreEqual(poolConductores.GetPoolConductores().Count, 1);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace CotxoxRefactored.Entities
{
    public class PoolConductores
    {
        //Paramethers
        private List<Conductor> poolConductores = new List<Conductor>();

        //Constructor
        public PoolConductores(List<Conductor> listaConductores)
        {
            this.poolConductores = listaConductores;
        }

        public List<Conductor> GetPoolConductores()
        {
            return this.poolConductores;
        }

        internal Conductor AsignarConductor(PoolConductores poolConductores)
        {
            //Paramethers
            int random = 0;
            bool asignado = false;

            //Action
            while (!asignado)
            {
                random = new Random().Next(poolConductores.GetPoolConductores().Count);
                if (!poolConductores.GetPoolConductores()[random].IsOcupado())
                {
                    poolConductores.GetPoolConductores()[random].SetOcupado(true);
                    asignado = true;
                }
            }
            return poolConductores.GetPoolConductores()[random];
        }
    }
}

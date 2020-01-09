using System;
using System.Collections.Generic;
using System.Text;

namespace CotxoxRefactored.Entities
{
    public class Carrera
    {
        //Public Attributes
        private string tarjetaCredito;
        private string origen;
        private string destino;
        private double distancia;
        private int tiempoEstimado;
        private double costeTotal;
        private int propina;

        private Conductor conductor = null;

        //Constructor
        public Carrera(string tarjetaCredito)
        {
            this.tarjetaCredito = tarjetaCredito;
        }

        //Getters & Setters
        public string GetTarjeta()
        {
            return this.tarjetaCredito;
        }

        public void SetOrigen(string origen)
        {
            this.origen = origen;
        }

        public string GetOrigin()
        {
            return this.origen;
        }

        public void SetDestino(string destino)
        {
            this.destino = destino;
        }

        public string GetDestino()
        {
            return this.destino;
        }

        public double GetDistancia()
        {
            return this.distancia;
        }

        public void SetDistancia(double distancia)
        {
            this.distancia = distancia;
        }

        public void SetTiempoEsperado(int tiempoEstimado)
        {
            this.tiempoEstimado = tiempoEstimado;
        }

        public double GetTiempoEsperado()
        {
            return this.tiempoEstimado;
        }

        public double GetCosteEsperado()
        {
            return Tarifa.CalcularCosteEsperado(this);
        }

        public Conductor GetConductor()
        {
            return this.conductor;
        }

        public void SetConductor(Conductor conductor)
        {
            this.conductor = conductor;
        }

        public int GetPropina()
        {
            return this.propina;
        }
        public double GetCosteTotal()
        {
            return this.costeTotal;
        }
        //Functions
        public void AsignarConductor(PoolConductores poolConductores)
        {
            SetConductor(poolConductores.AsignarConductor(poolConductores));
        }

        public void RealizarPago(double pago)
        {
            this.costeTotal = pago;
        }

        public void RecibirPropina(int propina)
        {
            this.propina = propina;
        }

        public void LiberarConductor()
        {
            this.GetConductor().SetOcupado(false);
        }
                
    }
}

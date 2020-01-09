using System;
using System.Collections.Generic;
using CotxoxRefactored.Entities;

namespace CotxoxRefactored
{
    class CotxoxApp
    {
        static void Main(string[] args)
        {
            /**
             * Configuración del Usuario y de la Carrera
             */

            // Confiruación Usuario
            string tarjetaCredito = "4987653214";
            string origen = "Aeropuerto PMI";
            string destino = "Palma de Mallorca";
            double distancia = 25;
            int tiempoEstimado = 15;

            //Configuración Carrera
            Carrera carrera = new Carrera(tarjetaCredito);
            carrera.SetOrigen(origen);
            carrera.SetDestino(destino);
            carrera.SetDistancia(distancia);
            carrera.SetTiempoEsperado(tiempoEstimado);

            //Prints
            Console.WriteLine("\n#####" + "\t Set Pickup: \t" + "#####\n");

            Console.WriteLine("Visa: " + carrera.GetTarjeta() + "\t");
            Console.WriteLine("Origen: " + carrera.GetOrigin() + "\t");
            Console.WriteLine("Destino: " + carrera.GetDestino() + "\t");
            Console.WriteLine("Tiempo estimado: " + carrera.GetTiempoEsperado() + "\t");


            Console.WriteLine("\n#####" + "\t See your Cost: \t" + "#####\n");
            Console.WriteLine("Visa: " + carrera.GetTarjeta() + "\t");
            Console.WriteLine("Origen: " + carrera.GetOrigin() + "\t");
            Console.WriteLine("Destino: " + carrera.GetDestino() + "\t");
            Console.WriteLine("Tiempo estimado: " + carrera.GetTiempoEsperado() + "\t");
            Console.WriteLine("Coste estimado: " + carrera.GetCosteEsperado() + "\t");


            Console.WriteLine("\n#####" + "\t Get a ride: Driver \t" + "#####\n");
            /**
             * Necesitamos crear la flota de conductores de donde seleccionar uno
		     * para ofrecer el servicio.
		     * La flota es un objeto de tipo PoolConductores.
		     */

            List<Conductor> poolConductores = new List<Conductor>();
            Conductor conductor = null;
            List<string> nombres = new List<string> { "Samanta", "Ariel", "Gabriela" };

            foreach (string nombre in nombres)
            {
                conductor = new Conductor(nombre);
                poolConductores.Add(conductor);
            }

            List<string> matriculas = new List<string> { "4532DLK", "4598LKG", "6295MDN" };
            List<string> modelos = new List<string> { "Toyota Prius", "Renault Megane", "Honda Civic" };

            int index = 0;
            foreach (Conductor conductora in poolConductores)
            {
                conductora.SetMatricula(matriculas[index]);
                conductora.SetModelo(modelos[index]);
                conductora.SetValoracion(4);
                index++;
            }

            /**
             * Se crea el objeto flota de conductores del tipo PoolConductores
             */
            PoolConductores conductores = new PoolConductores(poolConductores);
            carrera.AsignarConductor(conductores);

            Console.WriteLine("Driver: " + carrera.GetConductor().GetNombre() + "\t");
            Console.WriteLine("Matricula: " + carrera.GetConductor().GetMatricula() + "\t");
            Console.WriteLine("Modelo: " + carrera.GetConductor().GetModelo() + "\t");
            Console.WriteLine("Valoración: " + carrera.GetConductor().GetValoracion() + "\t");
            Console.WriteLine("Origen: " + carrera.GetOrigin() + "\t");
            Console.WriteLine("Destino: " + carrera.GetDestino() + "\t");

            bool isOcupado = carrera.GetConductor().IsOcupado();

            if(isOcupado)
                Console.WriteLine("El conductor esta ocupado");
            else
                Console.WriteLine("El conductor esta libre");


            Console.WriteLine("\n#####" + "\t Pay % Tip \t" + "#####\n");
            /**
             * Hora del pago
		     */
            carrera.RealizarPago(carrera.GetCosteEsperado());
            carrera.RecibirPropina(1);
            carrera.LiberarConductor();

            Console.WriteLine("Driver: " + carrera.GetConductor().GetNombre() + "\t");
            Console.WriteLine("TIP: " + carrera.GetPropina() + "\t");
            Console.WriteLine("Tarjeta: " + carrera.GetTarjeta() + "\t");
            Console.WriteLine("Coste total: " + carrera.GetCosteTotal() + "\t");
            Console.WriteLine("Esta ocupado: " + carrera.GetConductor().IsOcupado() + "\t");

            Console.WriteLine("\n#####" + "\t Rate your driver \t" + "#####\n");
            carrera.GetConductor().SetValoracion(5);
            Console.WriteLine("Driver: " + carrera.GetConductor().GetNombre() + "\t");
            Console.WriteLine("Valoracion: " + carrera.GetConductor().GetValoracion() + "\t");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CotxoxRefactored.Entities
{
    public class Conductor
    {
        //Attributes
        private string nombre;
        private string modelo;
        private string matricula;
        private int valoracion;
        private bool isOcupado = false;

        //Constructor
        public Conductor(string nombre)
        {
            this.nombre = nombre;
        }

        //Getters & Setters
        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetMatricula(string matricula)
        {
            this.matricula = matricula;
        }

        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public bool IsOcupado()
        {
            return this.isOcupado;
        }

        public void SetOcupado(bool ocupado)
        {
            this.isOcupado = ocupado;
        }

        public string GetMatricula()
        {
            return this.matricula;
        }

        public string GetModelo()
        {
            return this.modelo;
        }

        public void SetValoracion(int valoracion)
        {
            this.valoracion = valoracion;
        }

        public int GetValoracion()
        {
            return this.valoracion;
        }

    }
}

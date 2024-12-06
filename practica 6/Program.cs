using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace U3_Practica_05
{
    public class Calefaccion
    {
        public void EncenderCalefaccion()
        {
            Console.WriteLine("Calefacción encendida.");
        }

        public void ApagarCalefaccion()
        {
            Console.WriteLine("Calefacción apagada.");
        }
    }

    public class Termostato
    {
        private string estado;
        private int valor;
        private Calefaccion calefaccion;

        public Termostato()
        {
            estado = "Apagado";
            valor = 72;
            calefaccion = new Calefaccion();
            Console.WriteLine($"Termostato inicializado. Estado actual: {estado}. Temperatura inicial: {valor}");
        }

        public int Temperatura
        {
            get { return valor; }
            set { valor = value; Console.WriteLine("La temperatura fijada es: " + valor); }
        }

        public void Encender()
        {
            if (estado == "Apagado")
            {
                estado = "Encendido";
                calefaccion.EncenderCalefaccion();
                Console.WriteLine("Termostato encendido.");
            }
            else
            {
                Console.WriteLine("El termostato ya está encendido.");
            }
        }

        public void Apagar()
        {
            if (estado == "Encendido")
            {
                estado = "Apagado";
                calefaccion.ApagarCalefaccion();
                Console.WriteLine("Termostato apagado.");
            }
            else
            {
                Console.WriteLine("El termostato ya está apagado.");
            }
        }
    }
}
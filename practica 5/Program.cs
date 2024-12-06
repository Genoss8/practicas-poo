using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_Practica_04
{
    internal class Termostato
    {
        static string estado;
        static int valor = 0;
        private Calefaccion calefaccion;
        static Termostato()
        {
            Console.WriteLine("Inicialisemos el termostato...");
            estado = "Apagado";
            valor = 72;
            Console.WriteLine($"Estado actual: {estado}. Temperatura inicial: {valor}");

        }
        public Termostato()
        {
            calefaccion = new Calefaccion();
        }


        public void Temperaura(int temp)
        {
            valor = temp;
            Console.WriteLine("La temperatura fijada es:" + valor);

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

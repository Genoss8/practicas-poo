using System;

namespace U3_practica_04
{
    public class Termostato
    {
        // Campos no estáticos para que cada instancia tenga su propio estado y valor
        private string estado;
        private int valor;

        // Constructor de instancia
        public Termostato()
        {
            Console.WriteLine("Iniciando el termostato...");
            estado = "Apagado";
            valor = 72;
            Console.WriteLine("Estado actual: " + estado);
            Console.WriteLine("Valor de temperatura inicial: " + valor);
        }

        // Método para fijar la temperatura
        public void FijarTemperatura(int temp)
        {
            valor = temp;
            Console.WriteLine("La temperatura fijada es: " + valor);
        }
    }

    // Programa de prueba
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia del termostato
            Termostato termostato = new Termostato();

            // Cambiar la temperatura
            termostato.FijarTemperatura(25);
        }
    }
}

using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace U3_practica_04
{
    internal class Monitor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando sistema...");

            Termostato termostato = new Termostato();
            Calefaccion calefaccion = new Calefaccion();
            
            string op = "2";
            while (op == "2")
            {
                Console.WriteLine("\nIngrese el valor de la temperatura a colocar: ");
                int t = int.Parse(Console.ReadLine());
                termostato.Temperatura(t);

                Console.WriteLine("\nDesea: 1.- Fijar calefaccion.  2.-Salir");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                     calefaccion.E_A(termostato);

                else if (opcion == 2)
                    break;
                else
                    Console.WriteLine("opcion no valida");
                    
            }
        }
    }
}

namespace U3_practica_04
{
    internal class Calefaccion
    {
        private int motor;
        public Calefaccion()
        {

        }
        public void E_A(Termostato termostato)
        {
            Console.WriteLine("ingrese 1 para encender, 0 para apagar: ");
            motor = int.Parse(Console.ReadLine());
            if (motor == 1)
                termostato.Encender();
            else if (motor == 0)
            termostato.Apagar();
            else
                Console.WriteLine("opcion no valida");    
             
        }
    }
}

namespace U3_practica_04
{
    internal class Termostato
    {
        public String estado = "apagado";
        static int valor = 0;
        public Termostato()
        {
            Console.WriteLine("Iniciando el Termostato...");
            valor = 65;
            Console.WriteLine("Temperatura incial " + valor );
        }
        public void Encender()
        {
            if (estado == "Apagado")
            {
                Console.WriteLine("La calefaccion estaba apagada");
                estado = "Encendido";
                Console.WriteLine("se ha encendido la calefaccion" );
            }
            else
            {
                Console.WriteLine("La calefaccion ya estaba encendida");
            }
        }
        public void Apagar()
        {
            if (estado == "Encendido")
            {
                Console.WriteLine("La calefaccion esta encendida");
                estado = "Apagado";
                Console.WriteLine("Se ha apagado la calefaccion");
            }
            else
            {
                Console.WriteLine("La calefaccion ya estaba apagada");
            }
        }
        public void Temperatura(int temp)
        {
            valor = temp;

            Console.WriteLine("La temperatura es: " + valor );
        }
    }   
}
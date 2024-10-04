using System;

namespace practica
{
    class Dado
    {
        public int Lanzar()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }

    class Marcador
    {
        public string NombreJugador { get; set; }
        public int Posicion { get; set; }

        public void Avanzar(int pasos)
        {
            Posicion += pasos;
        }

        public void Retroceder(int pasos)
        {
            Posicion -= pasos;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido!");

            Marcador jugador1 = new Marcador { NombreJugador = "Jugador 1", Posicion = 0 };
            Marcador jugador2 = new Marcador { NombreJugador = "Jugador 2", Posicion = 0 };

            Dado dado = new Dado();

            bool juegoTerminado = false;
            while (!juegoTerminado)
            {
                Console.WriteLine("\nTurno de " + jugador1.NombreJugador);
                int resultadoDado1 = dado.Lanzar();
                int resultadoDado2 = dado.Lanzar();
                int total = resultadoDado1 + resultadoDado2;
                Console.WriteLine("Obtuviste un: " + resultadoDado1 ,"y un " + resultadoDado2 ,"Total: " + total);

                if (total % 2 == 0)
                {
                    jugador1.Avanzar(total);
                    Console.WriteLine(jugador1.NombreJugador ,"avanza a la posición: " + jugador1.Posicion);
                }
                else
                {
                    jugador1.Retroceder(total);
                    Console.WriteLine(jugador1.NombreJugador , "retrocede a la posición: " + jugador1.Posicion);
                }

                if (jugador1.Posicion >= 100)
                {
                    Console.WriteLine(jugador1.NombreJugador ,"ha ganado!");
                    juegoTerminado = true;
                    break;
                }
            }

            {
                Console.WriteLine("\nTurno de " + jugador2.NombreJugador);
                int resultadoDado1 = dado.Lanzar();
                int resultadoDado2 = dado.Lanzar();
                int total = resultadoDado1 + resultadoDado2;
                Console.WriteLine("Obtuviste un: " + resultadoDado1 ,"y un " + resultadoDado2 ,"Total: " + total);

                if (total % 2 == 0)
                {
                    jugador2.Avanzar(total);
                    Console.WriteLine(jugador2.NombreJugador ,"avanza a la posición: " + jugador2.Posicion);
                }
                else
                {
                    jugador2.Retroceder(total);
                    Console.WriteLine(jugador2.NombreJugador , "retrocede a la posición: " + jugador2.Posicion);
                }

                if (jugador2.Posicion >= 100)
                {
                    Console.WriteLine(jugador2.NombreJugador ,"ha ganado!");
                    juegoTerminado = true;
                    
                }
            }
        }
    }
}
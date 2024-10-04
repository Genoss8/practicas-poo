using practica_1;

namespace practica_1
{
    class dado
    {
        public int lado = 0;
        private static Random aleatorio = new Random();
           public int lanzar()
           {
            lado = aleatorio.Next(1, 7);
            return lado;
           }
    }
    class tablero
    {
        private int total = 0;
        public void sumar(int puntos)
        {
            total = total + puntos;
            Console.WriteLine("la suma acumulada de puntos es:"+ total);
        }
    }
}
    internal class program
{
    static void  Main(string[] args)
    {
        dado dado1 = new dado();
        dado dado2 = new dado();
        tablero tablero = new tablero();

        string seleccion = "si";
        while (seleccion == "si")
        {
            Console.Clear();
            Console.WriteLine("lanzando el dado 1...");
            int valor1 = dado1.lanzar();
            Console.WriteLine("obtuviste: " + valor1 + " puntos del dado 1 ");

            Console.WriteLine("lanzando el dado 2...");
            int valor2 = dado2.lanzar();
            Console.WriteLine("obtuviste: " + valor2 + " puntos del dado 2 ");

            int suma = valor1 + valor2;

            tablero.sumar(suma);
            Console.WriteLine();
            Console.WriteLine("Lanzar el dado otra vez?");
            seleccion = Console.ReadLine();
        }

    }
}

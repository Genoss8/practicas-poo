using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;

namespace U3_practica_11

{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado = 4.0;
            double altura = 5.0;
            //crear instancias de las figuras base

            Circulo circ = new Circulo(2.5);
            Cilindro tubo = new Cilindro(2.5, 3.0);

            //instancias de las figuras adicionales

            Cuadrado cuadrado = new Cuadrado(lado);

             Cubo cubo = new Cubo(lado);

             //imprimir resultados base

             Console.WriteLine("Figuras base: ");
             Console.WriteLine("Area del circulo:  ", circ.Area());
             Console.WriteLine("Area del cilindro:  ", tubo.Area());

             //salida de resultados nuevos

             Console.WriteLine("\nFiguras nuevas: ");
             Console.WriteLine("Area del cuadrado: ", cuadrado.Area());
             Console.WriteLine("Area del cubo: ", cubo.Area());

             Console.WriteLine("presione cualquier tecla para finalizar");
             Console.ReadKey();
        }
    }
}

namespace U3_practica_11
{
    public abstract class Figura
    {
        public const double pi = Math.PI;
        protected double x , y ;
        private double lado;

        public Figura(double x , double y)
        {
            this.x = x;
            this.y = y;
        }

        protected Figura(double lado)
        {
            this.lado = lado;
        }

        public abstract double Area();
    }
}
namespace U3_practica_11
{
    public class Cuadrado : Figura
    {
        public Cuadrado(double lado) : base(lado)
        {}

        public override double Area()
        {
            return Math.Pow( x , 2);
        }
    }
}

namespace U3_practica_11
{
    public class Cubo : Cuadrado
    {
        public Cubo(double lado) : base(lado)
        {}

        public override double Area()
        {
            return 6 * base.Area();
        }
    }
}

namespace U3_practica_11
{
    public class Circulo
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(radio,2);
        }
    }
}

namespace U3_practica_11
{
    public class Cilindro
    {
        private double radio;
        private double altura;

        public Cilindro(double radio, double altura)
        {
            this.radio = radio;
            this.altura = altura;

        }

        public double Area()
        {
            double areaB = Math.PI * Math.Pow(radio, 2);
            double areaL = 2 * Math.PI * radio * altura;
            return 2*  areaB + areaL;
        }
    }
}
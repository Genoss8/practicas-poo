namespace practica
{
    class circulo
    {
        double radio, area;
        public void areaCirculo()
        {
            Console.WriteLine("ingrese el valor del radio");
            radio = double.Parse(Console.ReadLine());

            area = Math.PI * radio;
            Console.WriteLine("El area del circulo es: " + area);
        }
    }
    class cuadrado
    {
        double lado, area;
        public void areaCuadrado()
        {
            Console.WriteLine("ingrese el valor del lado: ");
            lado = double.Parse(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine("El area del cuadrado es: " + area);
        }
    }
    class triangulo
    {
        double baseT, altura, area;
        public void areaTriangulo()
        {
            Console.WriteLine("ingrese el valor de la base: ");
            baseT = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor de la altura : ");
            altura = double.Parse(Console.ReadLine());
            area = (baseT * altura) / 2;
            Console.WriteLine("El area del triangulo es: " + area);

        }
    }
    class figuras
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            while (opcion != 4 )
            {
                Console.WriteLine("Escoge un figura para calcular el area: ");
                Console.WriteLine("1. Circulo");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Triangulo");
                Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        circulo circulo = new circulo();
                         circulo.areaCirculo();
                         break;
                    case 2:
                        cuadrado cuadrado = new cuadrado();
                         cuadrado.areaCuadrado();
                         break;
                    case 3:
                        triangulo triangulo = new triangulo();
                         triangulo.areaTriangulo();
                         break;
                    case 4:
                        Console.WriteLine("saliendo del programa....");
                         break;
                    default:
                            Console.WriteLine("Esa figura no existe, intentelo de nuevo. ");
                            break;


                }
            }
        }
    }
}
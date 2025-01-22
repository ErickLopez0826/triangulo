using System;

class triangulo
{
    static void Main(){
        // Ciclo para que el codigo no se termine hasta que el usuario lo desee
        while (true)
        {
            Console.WriteLine("\nIngrese las longitudes de los tres lados del triangulo: ");
            Console.Write("Lado1: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lado2: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lado3: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            // Condicional para determinar si los valores que ingreso el usuario corresponden a un triangulo o no
            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1){
                // Condicionales para mostrar el tipo de triangulo segun la medida de sus lados
                string tipoTriangulo;
                if (lado1 == lado2 && lado2 == lado3)
                {
                    tipoTriangulo = "Equilatero";
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    tipoTriangulo = "Isosceles";
                }
                else
                {
                    tipoTriangulo = "Escaleno";
                }
                Console.WriteLine($"El triangulo es: {tipoTriangulo}");

                // Calculo del área del triángulo usando la fórmula de Herón
                double perimetro = (lado1 + lado2 + lado3) / 2;
                double area = Math.Sqrt(perimetro * (perimetro - lado1) * (perimetro - lado2) * (perimetro - lado3));
                Console.WriteLine($"El area del triangulo con lados {lado1}, {lado2}, {lado3} es {area:F2}");
            }
            else{
                //Salida donde te dice que los datos que ingresastes no son validos para un triangulo
                Console.WriteLine("Los lados ingresados no forman un triángulo válido. Intente nuevamente.");
            }
            // Se le pregunta al usuario si desea ingresar otro triangulo o finalizar el programa
            Console.WriteLine("¿Desea calcular otro triangulo? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta != "s")
            {
                Console.WriteLine("Programa finalizado");
                break;
            }
        }
    }
}
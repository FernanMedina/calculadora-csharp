using System;
/*Desarrolle un algoritmo que solicite al usuario ingresar dos números enteros. Una vez ingresados, 
calcular la suma, resta, multiplicación y división. Mostrar por pantalla el resultado de cada cálculo. 
Luego deberá consultar al usuario si desea salir o realizar otro cálculo*/
namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string operacion;
            int resultado = 0;

            Console.WriteLine("Ingrese un numero distinto de 0 para comenzar");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                Console.WriteLine("Que operacion desea realizar?");
                Console.WriteLine("Para suma presione 1");
                Console.WriteLine("Para resta presione 2");
                Console.WriteLine("Para multiplicacion presione 3");
                Console.WriteLine("Para division presione 4");
                operacion = Console.ReadLine();

                Console.WriteLine("Ingrese los numeros a operar");
                int n1, n2;
                Console.WriteLine("Ingrese un numero: ");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero: ");
                n2 = int.Parse(Console.ReadLine());

                switch (operacion)
                {
                    case "1":
                        Console.WriteLine("Eligio suma");
                        resultado = n1 + n2;
                        Console.WriteLine($"El resultado es: {resultado}");
                        break;
                    case "2":
                        Console.WriteLine("Eligio resta");
                        resultado = n1 - n2;
                        Console.WriteLine($"El resultado es: {resultado}");
                        break;
                    case "3":
                        Console.WriteLine("Eligio multiplicacion");
                        resultado = n1 * n2;
                        Console.WriteLine($"El resultado es: {resultado}");
                        break;
                    case "4":
                        Console.WriteLine("Eligio division");
                        resultado = n1 / n2;
                        Console.WriteLine($"El resultado es: {resultado}");
                        break;
                    default:
                        Console.WriteLine("datos incorrectos");
                        break;
                }

                Console.WriteLine("Ingrese 0 para finalizar");
                Console.WriteLine("Ingrese cualquier tecla para continuar");
                numero = int.Parse(Console.ReadLine());    
            }
            Console.WriteLine("Finalizo ejecucion");
        }
    }
}

using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
            // Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            int numero, acu = 0;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("INGRESE UN NRO: ");
                numero = int.Parse(Console.ReadLine());

                if(par(numero) == 1)
                    acu++;
            }
            Console.WriteLine("Hay " + acu + " Pares");
        }

        //FUNCION PAR
        static int par(int a){
            if(a % 2 == 0)
                return 1;
            else
                return 0;
        }
    }
}

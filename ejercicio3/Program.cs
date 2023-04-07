using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es.
            //Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero.
            //Informar el promedio teniendo en cuenta sólo los números primos.

            int NUMERO, acu = 0, cont= 0, promedio = 0;

            Console.WriteLine("INGRESE UN NUMERO: ");
            NUMERO = int.Parse(Console.ReadLine());

            while(NUMERO != 0){

                if(primo(NUMERO)){
                    acu += NUMERO;
                    cont++;
                }

                Console.WriteLine("INGRESE OTRO NUMERO: ");
                NUMERO = int.Parse(Console.ReadLine());
            }

            if(cont == 0)
                Console.WriteLine("NO HAY PRIMOS ");
            else{
                promedio = acu / cont;
                Console.WriteLine("EL PROMEDIO ES: " + promedio);

            }




        }

        static bool primo(int N){
            int cont = 0;
            for (int x = 1; x <= N; x++)
            {
                if(N % x == 0)
                    cont++;
                
            }
            if(cont == 2)
                return true;
            else
                return false;
        }
    }
}

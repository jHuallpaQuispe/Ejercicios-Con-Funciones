using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
            //Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
            int precio, cantVendida, monto;

            Console.WriteLine("INGRESE EL PRECIO: ");
            precio = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE AL CANTIDAD: ");
            cantVendida = int.Parse(Console.ReadLine());

            monto = producto(precio, cantVendida);

            Console.WriteLine("EL MONTO A PAGAR ES: " + monto);





        }

        static int producto(int a, int b){
            int resultado;

            resultado = a * b;

            return resultado;
        }
    }
}

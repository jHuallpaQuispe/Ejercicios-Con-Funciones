using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia.
            //Que analice el número y escriba variable recibida por referencia con:

            //a. 1 si el número es positivo.
            //b. -1 si el número es negativo.
            //c. 0 si el número es cero.
            int num, numRefer;

            Console.WriteLine("INGRESE UN NRO: ");
            num= int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESO OTRO POR REFERENCIA: ");
            numRefer = int.Parse(Console.ReadLine());

            positivoNegativoCero(num, ref numRefer);

            Console.WriteLine("EL ESTADO DEL VALOR "+ num +" ES: " + numRefer);
        }

        static void positivoNegativoCero(int N, ref int Refer){
            if(N == 0)
                Refer = 0;
            else if(N > 0)
                Refer = 1;
            else
                Refer = -1;
        }
    }
}

using System;

namespace Exe03
{
    class Program
    {
        static void Main(string[] args)
        {

            int cem = 0, cinquenta = 0, vinte = 0, dez = 0, cinco = 0, dois = 0, valor = 0;
            decimal numero = 8;
            double numero2 = 6;

            Console.Write("Digite o valor a ser sacado: ");
            valor = Convert.ToInt32(Console.ReadLine());

            while (valor >= 100)
            {
                valor -= 100;
                cem++;
            }
            while (valor >= 50)
            {
                valor -= 50;
                cinquenta++;
            }
            while (valor >= 20)
            {
                valor -= 20;
                vinte++;
            }
            while (valor >= 10)
            {
                valor -= 10;
                dez++;
            } while ( valor>= 5 && valor != numero && valor!= numero2)
            {
                valor -= 5;
                cinco++;
            } while (valor >= 2)
            {
                valor -= 2;
                dois++;
            }


            Console.WriteLine("Notas de 100: " + cem);
            Console.WriteLine("Notas de 50: " + cinquenta);
            Console.WriteLine("Notas de 20: " + vinte);
            Console.WriteLine("Notas de 10: " + dez);
            Console.WriteLine("Notas de 5: " + cinco);
            Console.WriteLine("Notas de 2: " + dois);

        }
    }
    
}
    
using System;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*Scrieti un program care va numara vocalele dintr-un sir de caractere citit de la tastatura.*/


            Console.WriteLine("Introduceti sirul de caractere: ");
            string sirCaractere = Console.ReadLine();

            int contorVocale = 0;

            for (int i = 0; i < sirCaractere.Length; i++)
            {

                if (sirCaractere[i] == 'a' || sirCaractere[i] == 'e' || sirCaractere[i] == 'i' ||
                   sirCaractere[i] == 'o' || sirCaractere[i] == 'u')

                {
                    contorVocale++;

                }
            }

            Console.WriteLine($"Sirul introdus are {contorVocale} vocale. ");
        }
     } 

}


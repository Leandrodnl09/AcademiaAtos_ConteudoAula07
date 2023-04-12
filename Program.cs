using System;

namespace AcademiaAtos_ConteudoAula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;



            for (; x <= 0;)
            {
                Console.WriteLine("Informe um valor positivo:");
                x = int.Parse(Console.ReadLine());
            }




            for (int i = 1; i < x; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
            }



            x = 0;
            while (x <= 0)
            {
                Console.WriteLine("Informe um valor positivo!");
                x = int.Parse(Console.ReadLine());
            }


            while (true)
            {
                Console.WriteLine("Informe um número inteiro e positivo:");
                int num = int.Parse(Console.ReadLine());



                if (num < 0)
                {
                    Console.WriteLine("Valor incorreto!");
                    continue;
                }
                else
                {
                    for (int i = 1; i < num; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine("Números inteiros pares entre 1 e 8: " + i);
                        }

                    }
                    break;
                }
            }


            [15:23] Fabrício Tonetto Londero




bool outro = true;



            while (outro)

            {

                int x = 0;



                while (x <= 0)

                {

                    Console.WriteLine("Informe um valor positivo:");

                    x = int.Parse(Console.ReadLine());

                }



                int soma = 0;

                int contagem = 0;



                for (int i = 1; i < x; i++)

                {

                    if (i % 2 == 0)

                    {

                        Console.Write(i + ", ");

                        contagem++;

                        soma += i; // soma = soma + i;

                    }

                }



                Console.WriteLine("Deseja informar outr número s/n");

                string resposta = Console.ReadLine();



                if (resposta == "s")

                {

                    outro = true;

                }

                else

                {

                    outro = false;

                }

            }








            while (true)

            {

                int x = 0;



                while (x <= 0)

                {

                    Console.WriteLine("Informe um valor positivo:");

                    x = int.Parse(Console.ReadLine());

                }



                int soma = 0;

                int contagem = 0;



                for (int i = 1; i < x; i++)

                {

                    if (i % 2 == 0)

                    {

                        Console.Write(i + ", ");

                        contagem++;

                        soma += i; // soma = soma + i;

                    }

                }



                Console.WriteLine("Deseja informar outr número s/n");

                string resposta = Console.ReadLine();



                if (resposta == "n")

                {

                    break;

                }

            }



        }
    }
}
using System;

class Diamante
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            int tamanho;

            // Solicita um número ímpar válido
            do
            {
                Console.Write("\nDigite um número ímpar para o tamanho do diamante (ou 0 para sair): ");
                tamanho = int.Parse(Console.ReadLine());

                if (tamanho == 0)
                {
                    continuar = false;
                    break;
                }

                if (tamanho % 2 == 0)
                {
                    Console.WriteLine("Número inválido! Por favor, digite um número ímpar.");
                }

            } while (tamanho % 2 == 0);

            if (!continuar) break;

            DesenharDiamante(tamanho);

            Console.WriteLine("\nDeseja desenhar outro diamante? (S/N)");
            continuar = Console.ReadLine().Trim().ToUpper() == "S";
        }
    }

    static void DesenharDiamante(int tamanho)
    {
        int meio = tamanho / 2;

        // Parte superior do diamante
        for (int linha = 0; linha <= meio; linha++)
        {
            int espacos = meio - linha;
            int xis = 2 * linha + 1;

            // Imprime espaços
            for (int i = 0; i < espacos; i++)
                Console.Write(" ");

            // Imprime Xs
            for (int i = 0; i < xis; i++)
                Console.Write("X");

            Console.WriteLine();
        }

        // Parte inferior do diamante
        for (int linha = meio - 1; linha >= 0; linha--)
        {
            int espacos = meio - linha;
            int xis = 2 * linha + 1;

            for (int i = 0; i < espacos; i++)
                Console.Write(" ");

            for (int i = 0; i < xis; i++)
                Console.Write("X");

            Console.WriteLine();
        }
    }
}}
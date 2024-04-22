// faça um programa um programa de vetor de caracteres de 10 posições e converta as vogais de minusculo para maisculo 

        char[] caracteres = new char[10];
        char[] minusculas = { 'a', 'e', 'i', 'o', 'u' };
        char[] maiusculas = { 'A', 'E', 'I', 'O', 'U' };

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º caractere: ");
            caracteres[i] = Convert.ToChar(Console.ReadLine());
        }

        // vogais minúsculas para maiúsculas
        for (int i = 0; i < 10; i++)
        {
            for (int x = 0; x < minusculas.Length; x++)
            {
                if (caracteres[i] == minusculas[x])
                {
                    caracteres[i] = maiusculas[x];
                    break;
                }
            }
        }

        // caracteres convertido
        Console.WriteLine("\nCaracteres com vogais maiúsculas e minusculas:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(caracteres[i] + " ");
        }

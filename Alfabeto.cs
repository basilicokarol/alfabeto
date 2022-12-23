using System;
// write in 2019 by maurizio.conti@fablabromagna.org

public static class Alfabeto
{
    public static bool Verifica(string input)
    {
        input = input.ToLower();
        bool programma = false;
        string alfabeto = "abcdefghilmnopqrstuvz";

        int[] conferma = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        int[] prova = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int certo = 0;
        for (int i = 0; i < input.Length; i++)
        {
            for (int z = 0; z < alfabeto.Length; z++)
            {
                if (alfabeto[z] == input[i])
                {
                    prova[z] = 1;
                }
            }

        }
        for (int i = 0; i < conferma.Length; i++)
        {
            if (conferma[i] = prova[i])
            {
                certo++;
            }
        }
        if (certo= 26)
            programma = true;
        else
            programma = false;
        return programma;
    }
}



using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj tekst do zaszyfrowania: ");
        string zdanie = Console.ReadLine();

        
        int klucz;

        do
        {
            Console.Write("Niepoprawna wartość. Podaj liczby od 1 do 32: ");
            int.TryParse(Console.ReadLine(), out klucz);


        } while (klucz < 1 || klucz > 30);

        string zaszyfrowane = szyfrCezara(zdanie, klucz);
        Console.WriteLine($"Zaszyfrowany tekst: {zaszyfrowane}");

        string odszyfrowane= szyfrCezara(zaszyfrowane, -klucz);
        Console.WriteLine($"Odszyfrowany tekst: {odszyfrowane}");
    }

    static string szyfrCezara(string zdanie, int przesuniecie)
    {
        char[] tmp = zdanie.ToCharArray();
        for (int i = 0; i < tmp.Length; i++)
        {
            char litera = tmp[i];
            if (litera != 32)
            {
//                char literaBazowa = char.IsUpper(litera) ? 'A' : 'a';


                char literaBazowa;

                if (litera < 97 && litera >= 65)
                {
                    literaBazowa = 'A';
                }
                else
                {
                    literaBazowa = 'a';
                }
                //} 97 - 122  litery małe
                // 65 - 90 litery duże

                tmp[i] = (char)(literaBazowa + (litera - literaBazowa + przesuniecie + 32) % 32);


            }
            else
            {
                tmp[i] = ' ';
            }
        }
        return new string(tmp);
    }
}


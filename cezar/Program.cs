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


        } while (klucz < 1 || klucz > 32);

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
            if (char.IsLetter(litera))
            {
                               char literaBazowa =  char.IsUpper(litera) ? 'A' : 'a';


                //char literaBazowa;

                //if (char.IsUpper(litera))
                //{
                //    literaBazowa = 'A';
                //}
                //else
                //{
                //    literaBazowa = 'a';
                //}

                             tmp[i] = (char)(literaBazowa + (litera - literaBazowa + przesuniecie + 33) % 33);

                
            }
        }
        return new string(tmp);
    }
}


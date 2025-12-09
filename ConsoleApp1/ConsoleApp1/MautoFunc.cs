namespace ConsoleApp1;
public class MautoFunc
{
    //Konstruktor
    Mauto mau = new Mauto();
    public MautoFunc()
    {
        mau = Beker();
    }

    //Adatok megadásáért felelő metódus
    public Mauto Beker() //Ellenőrzött bekérés
    {
        Mauto mau = new Mauto();
        Console.Write("Mi az autó márkája: ");
        mau.Marka = Console.ReadLine(); //Márka
        Console.WriteLine();

        Console.Write($"A(z) {mau.Marka} márkájú autó színe: ");
        mau.Szin = Console.ReadLine(); //Szín
        Console.WriteLine();

        string eldont;
        do
        {
            Console.Write("Az autó mozgásban van? (y/n)");
            eldont = Console.ReadLine(); //Mozog-e
            if (eldont != "y" && eldont != "n") //Ha hibás az adat
            {
                Console.WriteLine("Érvénytelen, kérem adja meg újra!");
                Console.WriteLine();
            }
        } while (eldont != "y" && eldont != "n");
        Console.WriteLine();

        if (eldont == "y")
            mau.MozogE = true;
        else
            mau.MozogE = false;


        bool mat = false; //Ellenőrzött bekéréshez bool
        if (mau.MozogE)
        {
            int seb;
            do
            {
                Console.Write("Mekkora az autó sebessége: ");
                mat = int.TryParse(Console.ReadLine(), out seb) && seb > 0; //Sebesség
                if (!mat) //Ha hibás az adat
                {
                    Console.WriteLine("Hibás adat!");
                }
            } while (!mat);
            mau.Sebesseg = seb;
        }
        return mau;
    }

    //Kiíró metódus
    public void Kiir() //bemenet alapján kimenet létrehozása és kiírása
    {
        if (!mau.MozogE)
        {
            Console.WriteLine($"\nA(z) {mau.Szin} színű {mau.Marka} áll a parkolóban.");
        }
        else
        {
            Console.WriteLine($"\nA(z) {mau.Szin} színű {mau.Marka} elhalad egy sebességmérő előtt.");
            Traffipax();
        }
    }

    //Sebesség ellenőrzése metódus
    public void Traffipax()
    {
        int gyorshajtas = 120;
        if (mau.Sebesseg > gyorshajtas) //Ha túl gyorsan megy
        {
            Console.WriteLine($"Sebességed: {mau.Sebesseg} km/h");
            Console.WriteLine("Ki kell fizetned a büntetést!");
        }
    }
}

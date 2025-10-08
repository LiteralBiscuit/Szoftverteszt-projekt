using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
internal class MautoFunc
{
    Mauto mau = new Mauto();
    public MautoFunc()
    {
        mau = Beker();
    }

    public Mauto Beker()
    {
        Mauto mau = new Mauto();
        Console.Write("Mi az autó márkája: ");
        mau.Marka = Console.ReadLine();
        Console.WriteLine();

        Console.Write($"A(z) {mau.Marka} márkájú autó színe: ");
        mau.Szin = Console.ReadLine();
        Console.WriteLine();
        string eldont;
        do
        {
            Console.Write("Az autó mozgásban van? (y/n)");
            eldont = Console.ReadLine();
            if (eldont != "y" && eldont != "n")
            {
                Console.WriteLine("Érvénytelen, kérem adja meg újra!");
                Console.WriteLine();
            }
        } while (eldont != "y" && eldont != "n");
        if (eldont == "y")
            mau.MozogE = true;
        else
            mau.MozogE = false;

        bool mat = false;
        if (mau.MozogE)
        {
            int seb;
            do
            {
                Console.Write("Mekkora az autó sebessége: ");
                mat = int.TryParse(Console.ReadLine(), out seb) && seb > 0;
                if (!mat)
                {
                    Console.WriteLine("Hibás adat!");
                }
            } while (!mat);
            mau.Sebesseg = seb;
        }
        return mau;
    }

    public void Kiir()
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

    public void Traffipax()
    {
        int gyorshajtas = 120;
        if (mau.Sebesseg > gyorshajtas)
        {
            Console.WriteLine($"Sebességed: {mau.Sebesseg} km/h");
            Console.WriteLine("Ki kell fizetned a büntetést!");
        }
    }
}

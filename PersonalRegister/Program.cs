using System;

namespace PersonalRegister
{
    /// <summary>
    /// Svar på frågor
    /// Uppgift 1. Vilka klasser bör ingå i programmet?
    /// Restaurang och Anstalld
    /// 
    /// Uppgift 2. Vilka attribut och metoder bör ingå i dessa klasser?
    /// Klassen Anstalld har information om ForNamn, EfterNamn och Lon
    /// 
    /// Klassen Restaurang har information om restaurangens Namn samt en lista med anställda
    /// Metoden AddAnstalld lägger till en anställd till listan med anställda
    /// 
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            program.Restaurangen();

            Console.ReadLine();
        }

        public void Restaurangen()
        {
            Console.WriteLine("Restaurangen");

            Restaurang restaurang = new Restaurang();

            restaurang.Namn = "Kalles grillbar";

            Anstalld anstalld = new Anstalld();
            anstalld.ForNamn = "Kalle";
            anstalld.EfterNamn = "Andersson";
            anstalld.Lon = 123.45;

            restaurang.AddAnstalld(anstalld);


            Anstalld anstalld1 = new Anstalld();
            anstalld1.ForNamn = "Stina";
            anstalld1.EfterNamn = "Andersson";
            anstalld1.Lon = 678.90;

            restaurang.AddAnstalld(anstalld1);

            Console.WriteLine(restaurang);
        }
    }
}
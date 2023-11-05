using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDePologne
{
    class Program
    {
        static List<Zawodnik> Zawodnicy = new List<Zawodnik>();
        struct Zawodnik
        {
            public int id, ranking;
            public string imie, nazwisko, narodowosc, plec;
            public bool zawodowiecAmator;
            public short wiek;
        }


        static void Main(string[] args)
        {
            int wybor;
            do
            {
#region "Menu"     
                Console.WriteLine("TOUR DE POLOGNE - wybierz opcję:");
                Console.WriteLine("1. Dodaj zawodnika");
                Console.WriteLine("2. Edytuj zawodnika");
                Console.WriteLine("3. Usuń zawodnika");
                Console.WriteLine("4. Wyświetl listę zawodników ");
                Console.WriteLine("5. Wyświetl dane zawodnika");
                Console.WriteLine("0. Koniec");
#endregion
                while (!int.TryParse(Console.ReadLine(), out wybor) ||
                    (wybor < 0 || wybor > 6))
                {
                    Console.WriteLine("Niepoprawna wartość!!! Wprowadź numer z przedziału od 0 do 5");
                }

                switch (wybor)
                {
                    case 0:
                        zamknijProgram();
                        break;
                    case 1:
                        dodajZawodnika();
                        break;
                    case 2:
                        edytujZawodnika(2);
                        break;
                    case 3:
                        usunZawodnika();
                        break;
                    case 4:
                        wyswietlListe();
                        break;
                    case 5:
                        wyswietlZawodnika(2);
                        break;
                    default:
                        Console.WriteLine("Dokonano niewłaściwego wyboru!");
                        break;
                }

                Console.WriteLine("Wybrano {0}. Naciśnij enter aby kontynuować.", wybor);
                Console.ReadLine();
                Console.Clear();

            } while (wybor != 0);
 
            
        }

        private static Zawodnik nowyZawodnik()
        {
            Zawodnik nowyZawodnik = new Zawodnik();
            nowyZawodnik.id = 2;
            nowyZawodnik.imie = pobierzKonsola("Podaj imę: ");
            nowyZawodnik.nazwisko = pobierzKonsola("Podaj nazwisko: ");
            nowyZawodnik.plec = pobierzKonsola("Podaj płeć(K/M): "); 
            nowyZawodnik.ranking = 10;
            nowyZawodnik.wiek = 26;
            nowyZawodnik.zawodowiecAmator = true;
            nowyZawodnik.narodowosc = pobierzKonsola("Podaj narodowość: ");

            return nowyZawodnik;
        }

        static string pobierzKonsola(string tekst)
        {
            Console.Clear();
            Console.WriteLine(tekst);
            return Console.ReadLine();
        }
        static void dodajZawodnika()
        {
            Console.Clear();
            Zawodnicy.Add(nowyZawodnik());
        }

        static void edytujZawodnika(int id) { }

        static void usunZawodnika() { }

        static void wyswietlListe()
        {
            Console.Clear();
            foreach (Zawodnik osoba in Zawodnicy)
            {
                Console.WriteLine($"ID: {osoba.id} | Nazwisko imię: {osoba.nazwisko} {osoba.imie}");
            }
        }

        static void wyswietlZawodnika(int id) { }

        static void zamknijProgram() { }
    }
}

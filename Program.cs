using System.Reflection;

namespace Mini_Filmregister;

class Program
{
    static void Main(string[] args)
    {
    // Krav:
    // Klass Film med Titel, Genre, Betyg (1–10).
    
    // Använd en List<Film> för alla filmer.
    List<Film> films = new List<Film>();
    // Skapa en meny:
    bool kör = true;
    while (kör)
    {
        Console.Clear();
        Console.WriteLine("Välkommen till att söka på filmer");
        Console.WriteLine("1. Lägg till en film");
        Console.WriteLine("2. Sök efter genre");
        Console.WriteLine("3. Visa top 3 filmer baserat på betyg");
        Console.WriteLine("4. Välj att ta bort en film");
        Console.WriteLine("5. Avsluta");

        int.TryParse(Console.ReadLine(), out int val);
        
        switch (val)
            {
                case 1:
                Console.WriteLine("Titel:");
                string titel = Console.ReadLine()!;
                Console.WriteLine("Genre:");
                string genre = Console.ReadLine()!;
                Film film = new Film();
                film.Titel = titel;
                film.Genre = genre;
                films.Add(film);
                break;
                case 2:
                Console.WriteLine("Sök efter Genre");
                string sökGenre = Console.ReadLine()!;
                foreach (Film f in films)
                {
                   if (f.Genre == sökGenre)
                        {
                            Console.WriteLine(f.Titel);
                        }
                        
                }
                break;
                case 3:
                Console.WriteLine("Visar top 3 filmerna");
                break;
                case 4:
                Console.WriteLine("Vilken film vill du ta bort?");
                string BortTagenFilm = Console.ReadLine()!;
                break;
                case 5:
                Console.WriteLine("Avslutar programmet");
                kör = false;
                break;
                
                
                default:
                Console.WriteLine("Ogiltligt val");
                break;
                
                
                

            }
        
        Console.ReadKey();
    } 
    
    
    // ➕ Lägg till film
    // 🔍 Sök efter genre
    // 📈 Visa top 3 filmer baserat på betyg
    // 🧹 Ta bort film

    // (Bonus) Implementera Dictionary<string, 
    // List<Film>> där nyckeln är genre, för snabbare sökning.

    }
}

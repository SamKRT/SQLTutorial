using SQLTutorial.Data;
using System;

namespace SQLTutorial
{
    class Program
    {
        private static string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Samuel Kraut\Documents\Test1.mdf;Integrated Security=True;Connect Timeout=30";
        
        static void Main(string[] args)
        {
            IMitarbeiterQueryService mitarbeiterService = new MitarbeiterService(_connectionString);
            bool quit = false;
            while (!quit)
            {
                Console.Write("Was wollen Sie machen:\n\n[1] Personen mit Nachname suchen\n[2] Personen Nachname aktualisieren\n[3] Mitarbeiter löschen\n[4] Mitarbeiter hinzufügen\n[5] Programm beenden\n\n>> ");
                int input = int.Parse(Console.ReadLine());

                //if (input == 1)
                //{
                //    Console.Write("\nGeben Sie jetzt den Nachname der Person ein die Sie suchen.\n>> ");
                //    string searchedLastName = Console.ReadLine();
                //    var inhalt = mitarbeiterService.SelectAllMitarbeiterByLastName(searchedLastName);
                //    foreach (var item in inhalt)
                //        Console.WriteLine(item.ToString());
                //}
                //else if (input == 2)
                //{
                //    Console.Write("\nGeben Sie jetzt den Nachname der Person ein die Sie aktualisieren möchten.\n>> ");
                //    string searchedLastName = Console.ReadLine();
                //    Console.Write("\nGeben Sie jetzt den neuen Nachname ein.\n>> ");
                //    string newLastName = Console.ReadLine();
                //    mitarbeiterService.UpdateAllMitarbeiterByLastName(searchedLastName,newLastName);
                //}
                //else if (input == 3)
                //{
                //    Console.Write("\nGeben Sie jetzt den Nachname der Person die Sie löschen möchten.\n>> ");
                //    string deleteLastName = Console.ReadLine();
                //    mitarbeiterService.DeleteAllMitarbeiterByLastName(deleteLastName);
                //}
                if(input == 4)
                {
                    Console.Write("\nVorname\n>> ");
                    string vorname = Console.ReadLine();
                    Console.Write("\nNachname\n>> ");
                    string nachname = Console.ReadLine();
                    Console.Write("\nBirthday\n>> ");
                    DateTime birthday = Convert.ToDateTime(Console.ReadLine());
                    
                    mitarbeiterService.InsertMitarbeiter(vorname,nachname,birthday);
                }
                else if (input == 5)
                    quit = true;

            }
            
        }
    }
}

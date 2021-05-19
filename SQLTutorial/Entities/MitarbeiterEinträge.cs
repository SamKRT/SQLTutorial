using System;

namespace SQLTutorial
{
    class MitarbeiterEinträge
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Birthday { get; set; }
        public string Benutzername { get; set; }
        public string BenutzerPasswort { get; set; }

        public override string ToString()
        {
            return $"{Id} {Vorname} {Nachname} {Birthday} {Benutzername} {BenutzerPasswort}";
        }
    }
}

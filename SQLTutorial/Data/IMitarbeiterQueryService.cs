using System;
using System.Collections.Generic;

namespace SQLTutorial
{
    interface IMitarbeiterQueryService
    {
        //IEnumerable<MitarbeiterEinträge> SelectAllMitarbeiterByLastName(string nachname);
        //void DeleteAllMitarbeiterByLastName(string deleteLastName);
        void InsertMitarbeiter(string vorname, string nachname, DateTime birthday);
        //void UpdateAllMitarbeiterByLastName(string nachnameAlt, string nachnameNeu);
        //IEnumerable<MitarbeiterEinträge> SelectAllMitarbeiter(string nachname);

    }
}

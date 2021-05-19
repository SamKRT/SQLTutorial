using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SQLTutorial.Data
{
    class MitarbeiterServiceWithDapper : IMitarbeiterQueryService
    {
        private readonly string connectionString;

        #region Queries
        private readonly static string SelectAllMitarbeiterQuery = "SELECT * FROM Mitarbeiter";
        private readonly static string SelectMitarbeiterByNachnameQuery = "SELECT * FROM Mitarbeiter WHERE Nachname = @LastName";
        private readonly static string UpdateMitarbeiterByNachnameQuery = "UPDATE Mitarbeiter SET Nachname = @NewLastName WHERE Nachname = @OldLastName";
        private readonly static string DeleteMitarbeiterByNachnameQuery ="DELETE FROM Mitarbeiter WHERE Nachname = @LastName";
        private readonly static string InsertMitarbeiterQuery = "INSERT INTO Mitarbeiter(Vorname, Nachname, Birthday) VALUES ('@Vorname','@Nachname','@Birthday')";
        #endregion

        #region Constructor
        public MitarbeiterServiceWithDapper(string connectionString)
        {
            this.connectionString = connectionString;
        }
        #endregion

        #region Function
        public void DeleteAllMitarbeiterByLastName(string deleteLastName)
        {
            using var connection = new SqlConnection(connectionString);
            connection.Execute(DeleteMitarbeiterByNachnameQuery, new { Lastname = deleteLastName });
        }

        public void InsertMitarbeiter(string vorname, string nachname, DateTime birthday)
        {
            using var connection = new SqlConnection(connectionString);
            connection.Execute(InsertMitarbeiterQuery, new { Vorname = vorname, Nachname = nachname, Birthday = birthday });
        }

        public IEnumerable<MitarbeiterEinträge> SelectAllMitarbeiterByLastName(string nachname)
        {
            using var connection = new SqlConnection(connectionString);
            return connection.Query<MitarbeiterEinträge>(SelectMitarbeiterByNachnameQuery, new { LastName = nachname });
        }

        public void UpdateAllMitarbeiterByLastName(string nachnameAlt, string nachnameNeu)
        {
            using var connection = new SqlConnection(connectionString);
            connection.Execute(UpdateMitarbeiterByNachnameQuery, new { NewLastName = nachnameNeu, OldLastName = nachnameAlt });
        }

        public IEnumerable<MitarbeiterEinträge> SelectAllMitarbeiter(string nachname)
        {
            using var connection = new SqlConnection(connectionString);
            return connection.Query<MitarbeiterEinträge>(SelectAllMitarbeiterQuery);
        }
        #endregion
    }
}

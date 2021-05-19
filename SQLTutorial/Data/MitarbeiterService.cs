using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SQLTutorial
{
    class MitarbeiterService : IMitarbeiterQueryService
    {
        private readonly string connectionString;
        //private readonly static string SelectAllMitarbeiterQuery = "SELECT * FROM Mitarbeiter";
        //private readonly static string SelectMitarbeiterByNachnameQuery = "SELECT * FROM Mitarbeiter WHERE Nachname = @LastName";
        //private readonly static string UpdateMitarbeiterByNachnameQuery = "UPDATE Mitarbeiter SET Nachname = @NewLastName WHERE Nachname = @OldLastName";
        //private readonly static string DeleteMitarbeiterByNachnameQuery = "DELETE FROM Mitarbeiter WHERE Nachname = @LastName";
        private readonly static string InsertMitarbeiterQuery = "INSERT INTO Mitarbeiter(Vorname, Nachname, Geburtstag) VALUES ('@Vorname','@Nachname', '@Geburtstag')";


        #region Constructor
        public MitarbeiterService(string connectionString)
        {
            this.connectionString = connectionString;
        }
        #endregion

        //#region Functions
        //public IEnumerable<MitarbeiterEinträge> SelectAllMitarbeiterByLastName(string nachname)
        //{
        //    var mitarbeiterList = new List<MitarbeiterEinträge>();

        //    using (var connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        var command = connection.CreateCommand();
        //        command.CommandText = SelectMitarbeiterByNachnameQuery;
        //        command.CommandType = System.Data.CommandType.Text;
        //        command.Parameters.AddWithValue("@LastName", nachname);
        //        var reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            mitarbeiterList.Add(new MitarbeiterEinträge
        //            {
        //                Id = int.Parse(reader["Id"].ToString()),
        //                Vorname = reader["Vorname"].ToString(),
        //                Nachname = reader["Nachname"].ToString(),
        //                Birthday = DateTime.Parse(reader["Birthday"].ToString()),
        //                Benutzername = reader["Benutzername"].ToString(),
        //                BenutzerPasswort = reader["BenutzerPasswort"].ToString()
        //            }
        //            );
        //        }
        //    }
        //    return mitarbeiterList;
        //}

        //public void DeleteAllMitarbeiterByLastName(string deleteLastName)
        //{
        //    using var connection = new SqlConnection(connectionString);
        //    connection.Open();
        //    var command = connection.CreateCommand();
        //    command.CommandText = DeleteMitarbeiterByNachnameQuery;
        //    command.CommandType = System.Data.CommandType.Text;
        //    command.Parameters.AddWithValue("@LastName", deleteLastName);
        //    var reader = command.ExecuteNonQuery();

        //}










        public void InsertMitarbeiter(string vorname, string nachname, DateTime birthday)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();
                connection.Open();
                command.CommandText = InsertMitarbeiterQuery;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.AddWithValue("@Vorname", vorname);
                command.Parameters.AddWithValue("@Nachname", nachname);
                command.Parameters.AddWithValue("@Birthday", birthday.ToString("yyyy-MM-dd HH:mm:ss"));
                //command.Parameters.AddWithValue("@Birthday", birthday);
                //command.Parameters.Add(new SqlParameter(@"Geburtstag", System.Data.SqlDbType.DateTime2) { Value = birthday });
                command.ExecuteNonQuery();
            }
        }















        //    public void UpdateAllMitarbeiterByLastName(string nachnameAlt, string nachnameNeu)
        //    {
        //        using (var connection = new SqlConnection(connectionString))
        //        {
        //            var command = connection.CreateCommand();
        //            command.CommandText = UpdateMitarbeiterByNachnameQuery;
        //            command.CommandType = System.Data.CommandType.Text;
        //            command.Parameters.AddWithValue("@NewLastName", nachnameNeu);
        //            command.Parameters.AddWithValue("@OldLastName", nachnameAlt);
        //            var reader = command.ExecuteNonQuery();
        //        }
        //    }

        //    public IEnumerable<MitarbeiterEinträge> SelectAllMitarbeiter(string nachname)
        //    {
        //        var mitarbeiterList = new List<MitarbeiterEinträge>();

        //        using (var connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();
        //            var command = connection.CreateCommand();
        //            command.CommandText = SelectAllMitarbeiterQuery;
        //            command.CommandType = System.Data.CommandType.Text;
        //            var reader = command.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                mitarbeiterList.Add(new MitarbeiterEinträge
        //                {
        //                    Id = int.Parse(reader["Id"].ToString()),
        //                    Vorname = reader["Vorname"].ToString(),
        //                    Nachname = reader["Nachname"].ToString(),
        //                    Birthday = DateTime.Parse(reader["Birthday"].ToString()),
        //                    Benutzername = reader["Benutzername"].ToString(),
        //                    BenutzerPasswort = reader["BenutzerPasswort"].ToString()
        //                }
        //                );
        //            }
        //        }
        //        return mitarbeiterList;
        //    }
        //    #endregion
        //}
    }
}

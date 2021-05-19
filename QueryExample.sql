DROP TABLE Mitarbeiter

CREATE TABLE Mitarbeiter(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Vorname NVARCHAR(50) NOT NULL,
	Nachname NVARCHAR(50) NOT NULL,
	Geburtstag DATETIME2 NOT NULL
)

SELECT * FROM Mitarbeiter

INSERT INTO Mitarbeiter (Vorname, Nachname, Geburtstag) VALUES ('Samuel','Kraut','06-16-2000')
Aprire la cartella tramite Visual Studio Code 
Avviare un nuovo terminale e scrivere il comando dotnet new console
Aggiungere il file del DB
Aggiungere la libreria necesaria, ovvero: ![image](https://user-images.githubusercontent.com/116790906/235086399-4391116a-3dd7-4f5d-887e-ed91790cf2bf.png)
Esegurire il collegamento al DB tramite il terminale scrivendo il seguente comando: dotnet add package sqlite-net-pcl: 
Aggiungere nel program.cs la libreria using SQLite
Link per il download del database: https://www.sqlitetutorial.net/wp-content/uploads/2018/03/chinook.zip

Codice cs:
SQLiteConnection cn1 = new SQLiteConnection("chinook.db") connessione DB

var tblArtist = cn1.Query<Artist>( "select * from artists" ); query artisti 

// See https://aka.ms/new-console-template for more information
using SQLite;

Console.WriteLine("Hello, DBWorld!");
SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
var tblArtist = cn1.Query<Artist>( "select * from artists" );
Console.WriteLine( $" In questa tabella ci sono {tblArtist.Count} record!");

// ----------------------
// fine del main inzio delle dichiarazioni 
public class Artist
{
    public int ArtistId{get;set;}
    public string Name{get;set;}
}

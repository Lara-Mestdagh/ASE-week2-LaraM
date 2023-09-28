// Create some songs
var song1 = new Song("Pump it", 3);
var song2 = new Song("Everybody", 3);
var song3 = new Song("Saturday Night", 2);

// Create an album with the songs
var album1 = new Album("Brol", "Angèle", "Pop", "2018", new List<Song> { song1, song2 });
var album2 = new Album("Take Me Back To Eden", "Sleep Token", "Alt", "2023", new List<Song> { song3 });

// Create a player
var player = new Player();

// Simulate playing songs
foreach (var currentsong in album1.Songs)
{
    player.PlaySong(currentsong);
}
foreach (var currentsong in album2.Songs)
{
    player.PlaySong(currentsong);
}
    
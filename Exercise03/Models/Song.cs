namespace MCT.Ex3.Models.Song;
public class Song
{
    // CONSTRUCTORS
    public Song(string title, int duration)
    {
        Title = title;
        Duration = duration;
    }

    // FUNCTIONS

    // PROPERTIES
    public string Title { get; set; }
    public int Duration { get; set; }
    
}
namespace AlienDBMvvM.Models;

public class FilmModel
{
    public string Title { get; set; }
    public string PolishTitle { get; set; }
    public int ReleaseYear { get; set; }
    public string Director { get; set; }
    public string ScreenWriter { get; set; }
    public string Genre { get; set; }
    public int Duration { get; set; }
    public double Rating { get; set; }
    public string[] MainCharacters { get; set; }
    public string Ship {get; set;}
    public string Description { get; set; }
    public string FunFact { get; set; }

}
using System;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Linq;
using System.Reflection.PortableExecutable;
using AlienDBMvvM.Models;
using Avalonia.Controls;
using ReactiveUI;

namespace AlienDBMvvM.ViewModels;

public class DetailWindowViewModel : ReactiveObject
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
    public string Ship { get; set; }
    public string Description { get; set; }
    public string FunFact { get; set; }
    
    public ReactiveCommand<Unit, Unit> ShowCharactersCommand { get; }
    public Interaction<string[], Unit> ShowCharactersWindow { get; }
    
    public DetailWindowViewModel(FilmModel data)
    {
        Title = data.Title;
        PolishTitle = data.PolishTitle;
        ReleaseYear = data.ReleaseYear;
        Director = data.Director;
        ScreenWriter = data.ScreenWriter;
        Genre = data.Genre;
        Duration = data.Duration;
        Rating = data.Rating;
        MainCharacters = data.MainCharacters;
        Ship = data.Ship;
        Description = data.Description;
        FunFact = data.FunFact;
        
        ShowCharactersWindow = new Interaction<string[], Unit>();
        
        ShowCharactersCommand = ReactiveCommand.CreateFromTask(async () =>
        {
            await ShowCharactersWindow.Handle(MainCharacters);
        });

    }
}
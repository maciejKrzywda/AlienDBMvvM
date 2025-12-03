using System;
using System.Reactive;
using AlienDBMvvM.Models;
using ReactiveUI;

namespace AlienDBMvvM.ViewModels;

public class FilmViewModel: ViewModelBase
{
    public FilmModel Model { get; }
    public string Title => Model.Title;
    public string PolishTitle => Model.PolishTitle;
    public int ReleaseYear => Model.ReleaseYear;
    public string Director => Model.Director;
    public string ScreenWriter => Model.ScreenWriter;
    public string Genre => Model.Genre;
    public int Duration => Model.Duration;
    public double Rating => Model.Rating;
    public string[] MainCharacters => Model.MainCharacters;
    public string Ship => Model.Ship;
    public string Description => Model.Description;
    public string FunFact => Model.FunFact;

    public ReactiveCommand<Unit, Unit> DeleteCommand { get; }
    
    public FilmViewModel(FilmModel model, Action<FilmViewModel> removeAction)
    {
        Model = model;
        
        DeleteCommand = ReactiveCommand.Create(() => removeAction(this));
    }

}
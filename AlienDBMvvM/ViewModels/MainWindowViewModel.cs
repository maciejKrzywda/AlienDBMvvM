using System.Collections.ObjectModel;
using AlienDBMvvM.Models;

namespace AlienDBMvvM.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<FilmModel> Films { get; } = new()
    {
        new FilmModel()
        {

        },
    };
}
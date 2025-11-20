using System;
using System.Collections.ObjectModel;
using System.Reactive;
using AlienDBMvvM.Models;
using ReactiveUI;

namespace AlienDBMvvM.ViewModels;

public class MainWindowViewModel : ViewModelBase
{

    public MainWindowViewModel()
    {
        //var canShowDetails 
        
        ShowDetailsCommand = ReactiveCommand.CreateFromTask(async () =>
        {
            Console.WriteLine("Pokaz");
        });
    }
    
    public ObservableCollection<FilmModel> Films { get; } = new()
    {
        new FilmModel() {
            Title = "Alien",
            PolishTitle = "Obcy – ósmy pasażer Nostromo",
            ReleaseYear = 1979,
            Director = "Ridley Scott",
            ScreenWriter = "Dan O’Bannon",
            Genre = "Sci-Fi / Horror",
            Duration = 117,
            Rating = 8.5,
            MainCharacters = new string[] { "Ellen Ripley", "Dallas", "Ash", "Lambert", "Kane" },
            Ship = "USCSS Nostromo",
            Description = "Załoga statku handlowego Nostromo odbiera sygnał z nieznanej planety. Po lądowaniu odkrywają obcą formę życia, która zaczyna eliminować członków załogi jeden po drugim.",
            FunFact = "Scena z „wyskakującym potworem” z klatki piersiowej aktora była niespodzianką dla obsady – ich reakcje są autentyczne."
        },

        new FilmModel() {
            Title = "Aliens",
            PolishTitle = "Obcy – decydujące starcie",
            ReleaseYear = 1986,
            Director = "James Cameron",
            ScreenWriter = "James Cameron, David Giler, Walter Hill",
            Genre = "Sci-Fi / Akcja / Horror",
            Duration = 137,
            Rating = 8.4,
            MainCharacters = new string[] { "Ellen Ripley", "Hicks", "Newt", "Bishop", "Vasquez" },
            Ship = "USS Sulaco",
            Description = "Ripley, jedyna ocalała z wcześniejszego ataku obcego, wraca z oddziałem kolonialnych marines na księżyc LV-426, by zbadać utratę kontaktu z kolonią. Wkrótce stają oko w oko z armią obcych.",
            FunFact = "James Cameron napisał scenariusz podczas lotu do Londynu, tworząc tytuł, który jest liczbą mnogą słowa „Alien” – symbolicznie zapowiadając, że tym razem potworów będzie więcej."
        },

        new FilmModel() {
            Title = "Alien³",
            PolishTitle = "Obcy³",
            ReleaseYear = 1992,
            Director = "David Fincher",
            ScreenWriter = "David Giler, Walter Hill, Larry Ferguson",
            Genre = "Sci-Fi / Horror",
            Duration = 114,
            Rating = 6.5,
            MainCharacters = new string[] { "Ellen Ripley", "Dillon", "Clemens", "Morse", "Andrews" },
            Ship = "E.E.V. z USS Sulaco (katastrofa)",
            Description = "Po katastrofie statku Sulaco Ripley trafia na więzienną planetę Fiorina 161, gdzie wkrótce pojawia się obcy. Pozbawiona broni i wsparcia, musi walczyć o życie wśród skazańców i odkrywa, że nosi w sobie embrion królowej obcych.",
            FunFact = "David Fincher zadebiutował tym filmem jako reżyser, jednak miał ograniczoną kontrolę twórczą, a produkcja była pełna konfliktów – reżyser później odciął się od tego projektu."
        },

        new FilmModel() {
            Title = "Alien: Resurrection",
            PolishTitle = "Obcy: Przebudzenie",
            ReleaseYear = 1997,
            Director = "Jean-Pierre Jeunet",
            ScreenWriter = "Joss Whedon",
            Genre = "Sci-Fi / Horror",
            Duration = 109,
            Rating = 6.2,
            MainCharacters = new string[] { "Ellen Ripley (klon)", "Call", "Johner", "Christie", "Dr. Gediman" },
            Ship = "USM Auriga",
            Description = "Dwieście lat po śmierci Ripley naukowcy klonują ją, by wydobyć królową obcych z jej ciała. Klonowana Ripley zyskuje niezwykłe zdolności i wraz z grupą kosmicznych najemników musi zapobiec katastrofie, gdy obcy wydostają się na wolność.",
            FunFact = "Postać androidki Call gra Winona Ryder, a film miał początkowo być początkiem nowej trylogii, która jednak nigdy nie powstała."
        },

        new FilmModel() {
            Title = "Prometheus",
            PolishTitle = "Prometeusz",
            ReleaseYear = 2012,
            Director = "Ridley Scott",
            ScreenWriter = "Jon Spaihts, Damon Lindelof",
            Genre = "Sci-Fi / Thriller",
            Duration = 124,
            Rating = 7.0,
            MainCharacters = new string[] { "Elizabeth Shaw", "David", "Charlie Holloway", "Meredith Vickers" },
            Ship = "USCSS Prometheus",
            Description = "Ekspedycja naukowa wyrusza na odległą planetę, by odkryć pochodzenie ludzkości. Na miejscu załoga Prometeusza odkrywa ruiny cywilizacji Inżynierów oraz coś, co nigdy nie powinno zostać obudzone.",
            FunFact = "Ridley Scott planował, aby film stanowił zarówno prequel „Obcego”, jak i samodzielną opowieść o powstaniu życia i człowieka – wiele elementów łączy się z mitologią obcych w sposób pośredni."
        },

        new FilmModel() {
            Title = "Alien: Covenant",
            PolishTitle = "Obcy: Przymierze",
            ReleaseYear = 2017,
            Director = "Ridley Scott",
            ScreenWriter = "John Logan, Dante Harper",
            Genre = "Sci-Fi / Horror",
            Duration = 122,
            Rating = 6.4,
            MainCharacters = new string[] { "Daniels", "David", "Walter", "Oram", "Tennessee" },
            Ship = "USCSS Covenant",
            Description = "Załoga statku kolonizacyjnego Covenant odkrywa nieznaną planetę, idealną do osiedlenia. Na miejscu natrafiają jednak na Davida – syntetyka ocalałego z Prometeusza – oraz nowe formy obcych stworzeń, które mogą zakończyć ludzką ekspansję w kosmosie.",
            FunFact = "Film pierwotnie miał być zatytułowany „Paradise Lost”, a reżyser planował jeszcze jedną część łączącą fabułę z oryginalnym „Obcym” z 1979 roku."
        }

    };
    
    public ReactiveCommand<Unit, Unit> ShowDetailsCommand { get; }

}
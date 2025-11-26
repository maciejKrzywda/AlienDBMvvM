using System;
using System.Collections.ObjectModel;
using System.Reactive;
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
    
    public ObservableCollection<CharacterModel> Characters { get; } = new ObservableCollection<CharacterModel>
    {
        new CharacterModel
        {
            Name = "Ellen Louise",
            Surname = "Ripley",
            Role = "Oficer porządkowy / specjalistka ds. bezpieczeństwa",
            Actor = "Sigourney Weaver",
            Spiecies = "Człowiek",
            BirthYear = 2092,
            Function = "Odpowiada za bezpieczeństwo załogi i protokoły misji handlowych.",
            Characteristics = "Zdeterminowana, inteligentna, psychicznie odporna.",
            Fate = "Ginęła w Alien³, potem sklonowana w Resurrection.",
            FunFact = "Sigourney Weaver była nominowana do Oscara za rolę w Aliens."
        },

        new CharacterModel
        {
            Name = "Arthur Koblenz",
            Surname = "Dallas",
            Role = "Kapitan statku USCSS Nostromo",
            Actor = "Tom Skerritt",
            Spiecies = "Człowiek",
            BirthYear = 2071,
            Function = "Dowódca misji, odpowiedzialny za lądowanie i bezpieczeństwo załogi.",
            Characteristics = "Opanowany, odpowiedzialny, podejmuje trudne decyzje.",
            Fate = "Zginął podczas próby schwytania obcego w kanałach Nostromo.",
            FunFact = "Scenariusz rozważał alternatywne zakończenie, w którym Dallas przeżywa."
        },

        new CharacterModel
        {
            Name = "Ash",
            Surname = "",
            Role = "Oficer naukowy Nostromo",
            Actor = "Ian Holm",
            Spiecies = "Android (Hyperdyne Systems 120-A/2)",
            BirthYear = 0,
            Function = "Analiza sygnałów i badania naukowe obiektów pozaziemskich.",
            Characteristics = "Spokojny, profesjonalny, ukrywa tajne rozkazy korporacji.",
            Fate = "Zniszczony przez załogę po ujawnieniu misji ochrony obcego.",
            FunFact = "Pierwszy android w uniwersum Alien."
        },

        new CharacterModel
        {
            Name = "Bishop",
            Surname = "",
            Role = "Oficer naukowy, android kolonialnych marines",
            Actor = "Lance Henriksen",
            Spiecies = "Android (Hyperdyne 341-B)",
            BirthYear = 0,
            Function = "Analiza danych i wsparcie operacji bojowych.",
            Characteristics = "Empatyczny, lojalny, etyczny — przeciwieństwo Asha.",
            Fate = "Ciężko uszkodzony przez królową obcych, później dezaktywowany.",
            FunFact = "Jeden z nielicznych androidów wzbudzających pełne zaufanie."
        },

        new CharacterModel
        {
            Name = "Jenette",
            Surname = "Vasquez",
            Role = "Strzelec kolonialnych marines",
            Actor = "Jenette Goldstein",
            Spiecies = "Człowiek",
            BirthYear = 2124,
            Function = "Specjalistka od broni ciężkiej i walki w ciasnych przestrzeniach.",
            Characteristics = "Odważna, twarda, zadziorna.",
            Fate = "Poświęca życie, wysadzając korytarz pełen obcych.",
            FunFact = "Wzór dla późniejszych bohaterek sci-fi."
        },

        new CharacterModel
        {
            Name = "Rebecca",
            Surname = "Jorden (Newt)",
            Role = "Jedyna ocalała z kolonii Hadley’s Hope",
            Actor = "Carrie Henn",
            Spiecies = "Człowiek",
            BirthYear = 2172,
            Function = "Dziecko ocalałe z ataku ksenomorfów, towarzyszka Ripley.",
            Characteristics = "Sprytna, cicha, odporna psychicznie.",
            Fate = "Ginęła w katastrofie statku Sulaco.",
            FunFact = "Carrie Henn po tym filmie zakończyła karierę aktorską."
        },

        new CharacterModel
        {
            Name = "Queen",
            Surname = "Alien",
            Role = "Królowa ksenomorfów",
            Actor = "Efekty praktyczne / animatronics",
            Spiecies = "Obcy (Ksenomorf Królowa)",
            BirthYear = 0,
            Function = "Składanie jaj w hierarchii obcych.",
            Characteristics = "Agresywna, inteligentna, silny instynkt macierzyński.",
            Fate = "Zniszczona w Sulaco, ponownie sklonowana w Resurrection.",
            FunFact = "Model Królowej miał ponad 4 metry wysokości."
        },

        new CharacterModel
        {
            Name = "Annalee",
            Surname = "Call",
            Role = "Członkini załogi statku Betty",
            Actor = "Winona Ryder",
            Spiecies = "Android (Auton)",
            BirthYear = 2381,
            Function = "Specjalistka od techniki i hakowania.",
            Characteristics = "Empatyczna, emocjonalna, moralna.",
            Fate = "Przeżywa i opuszcza Ziemię z Ripley 8.",
            FunFact = "Pierwszy android stworzony przez inne androidy."
        },

        new CharacterModel
        {
            Name = "Ripley",
            Surname = "8",
            Role = "Klon Ellen Ripley z DNA królowej obcych",
            Actor = "Sigourney Weaver",
            Spiecies = "Hybryda (Człowiek/Obcy)",
            BirthYear = 2381,
            Function = "Wspiera załogę Betty na USM Auriga.",
            Characteristics = "Silna, rozdarta między naturą człowieka i obcego.",
            Fate = "Przeżywa, ale nie ufa ludziom ani korporacjom.",
            FunFact = "Ma kwaśną krew i zwiększone zdolności fizyczne."
        },

        new CharacterModel
        {
            Name = "The",
            Surname = "Engineer",
            Role = "Starożytny stwórca ludzi",
            Actor = "Ian Whyte",
            Spiecies = "Inżynier",
            BirthYear = 0,
            Function = "Reprezentuje cywilizację twórców ludzi.",
            Characteristics = "Małomówny, majestatyczny, potężny.",
            Fate = "Budzi się i zabija załogę Prometeusza, później ginie.",
            FunFact = "Łączy mit stworzenia z początkiem gatunku Obcych."
        },

        new CharacterModel
        {
            Name = "Neomorph",
            Surname = "",
            Role = "Forma pośrednia Davida i ksenomorfa",
            Actor = "CGI",
            Spiecies = "Obcy (mutant)",
            BirthYear = 0,
            Function = "Eksperymentalne stworzenie Davida.",
            Characteristics = "Szybki, nieprzewidywalny, niestabilny.",
            Fate = "Zabity przez załogę Covenant.",
            FunFact = "Inspirowany koncepcją „białego drapieżcy”."
        },

        new CharacterModel
        {
            Name = "Daniels",
            Surname = "Branson",
            Role = "Oficer kolonizacyjny",
            Actor = "Katherine Waterston",
            Spiecies = "Człowiek",
            BirthYear = 2100,
            Function = "Projektuje kolonie i kieruje terraformacją.",
            Characteristics = "Pragmatyczna, odważna, zdeterminowana.",
            Fate = "Uśpiona przez Davida podszywającego się pod Waltera.",
            FunFact = "Scott planował, aby była symbolicznym nowym początkiem."
        }
    };

    
    public ReactiveCommand<Unit, Unit> CloseDetailsCommand { get; }
    
    public ReactiveCommand<Unit, Unit> ShowCharactersCommand { get; }
    public Interaction<CharacterModel, Unit> ShowCharactersWindow { get; }
    
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

        CloseDetailsCommand = ReactiveCommand.Create(() =>
        {
            Environment.Exit(0);
        });
        
        ShowCharactersWindow = new Interaction<CharacterModel, Unit>();
        
        ShowCharactersCommand = ReactiveCommand.CreateFromTask(async () =>
        {
            Console.WriteLine(":3");
        });

        



    }
}
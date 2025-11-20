using System.Collections.ObjectModel;
using AlienDBMvvM.Models;

namespace AlienDBMvvM.ViewModels;

public class CharacterViewModel : ViewModelBase
{
        public ObservableCollection<CharacterModel> Charaters { get; } = new()
    {
        new CharacterModel() {
            Name = "Ellen Louise",
            Surname = "Ripley",
            Role = "Oficer porządkowy, później specjalistka ds. bezpieczeństwa",
            Actor = "Sigourney Weaver",
            Spiecies = "Człowiek",
            BirthYear = 2092,
            Function = "Odpowiada za bezpieczeństwo załogi oraz przestrzeganie protokołów misji handlowych.",
            Characteristics = "Zdeterminowana, inteligentna, odporna psychicznie. Jej decyzje często ratują załogę. Symbol siły i walki człowieka z nieznanym.",
            Fate = "Ginęła w filmie Alien³, później sklonowana w Alien: Resurrection.",
            FunFact = "Sigourney Weaver była nominowana do Oscara za rolę w Aliens — rzadkość w kinie sci-fi."
        },

        new CharacterModel() {
            Name = "Arthur Koblenz",
            Surname = "Dallas",
            Role = "Kapitan statku handlowego USCSS Nostromo",
            Actor = "Tom Skerritt",
            Spiecies = "Człowiek",
            BirthYear = 2071,
            Function = "Dowódca misji, odpowiedzialny za decyzje dotyczące lądowania i bezpieczeństwa załogi.",
            Characteristics = "Opanowany i odpowiedzialny, stawia bezpieczeństwo załogi ponad własne emocje.",
            Fate = "Zginął podczas próby schwytania obcego w kanałach wentylacyjnych.",
            FunFact = "Rozważano alternatywne zakończenie, w którym Dallas zostaje odnaleziony żywy."
        },

        new CharacterModel() {
            Name = "Ash",
            Surname = "",
            Role = "Oficer naukowy Nostromo",
            Actor = "Ian Holm",
            Spiecies = "Android (Hyperdyne Systems 120-A/2)",
            BirthYear = 0,
            Function = "Odpowiada za analizę sygnałów i badania naukowe obiektów pozaziemskich.",
            Characteristics = "Spokojny i profesjonalny, lecz kierowany sekretnymi rozkazami korporacji.",
            Fate = "Zniszczony po ujawnieniu swojej misji.",
            FunFact = "Pierwszy android w uniwersum Alien."
        },

        new CharacterModel() {
            Name = "Bishop",
            Surname = "",
            Role = "Oficer naukowy, android kolonialnych marines",
            Actor = "Lance Henriksen",
            Spiecies = "Android (Hyperdyne 341-B)",
            BirthYear = 0,
            Function = "Analiza danych i wsparcie operacji bojowych.",
            Characteristics = "Empatyczny, etyczny, lojalny — przeciwieństwo Asha.",
            Fate = "Ciężko uszkodzony przez królową obcych, dezaktywowany.",
            FunFact = "Jeden z nielicznych androidów w kinie, który wzbudza zaufanie."
        },

        new CharacterModel() {
            Name = "Jenette",
            Surname = "Vasquez",
            Role = "Strzelec kolonialnych marines",
            Actor = "Jenette Goldstein",
            Spiecies = "Człowiek",
            BirthYear = 2124,
            Function = "Specjalistka od broni ciężkiej i walki w ciasnych przestrzeniach.",
            Characteristics = "Twarda, odważna, zadziorna; żartuje nawet w zagrożeniu.",
            Fate = "Poświęca życie, wysadzając korytarz pełen obcych.",
            FunFact = "Stała się inspiracją dla wielu bohaterek sci-fi."
        },

        new CharacterModel() {
            Name = "Rebecca",
            Surname = "Jorden (Newt)",
            Role = "Jedyna ocalała z kolonii Hadley’s Hope",
            Actor = "Carrie Henn",
            Spiecies = "Człowiek",
            BirthYear = 2172,
            Function = "Towarzyszka Ripley, dziecko, które przetrwało atak ksenomorfów.",
            Characteristics = "Sprytna, odporna psychicznie mimo wieku.",
            Fate = "Ginęła w katastrofie statku Sulaco (Alien³).",
            FunFact = "Carrie Henn nigdy więcej nie zagrała w żadnym filmie."
        },

        new CharacterModel() {
            Name = "The",
            Surname = "Queen Alien",
            Role = "Matka i królowa ksenomorfów",
            Actor = "Efekty praktyczne i animatronics",
            Spiecies = "Obcy (Ksenomorf Królowa)",
            BirthYear = 0,
            Function = "Składanie jaj, centralna rola w hierarchii obcych.",
            Characteristics = "Inteligentna, agresywna, instynkt macierzyński.",
            Fate = "Zniszczona w Aliens, ponownie klonowana w Resurrection.",
            FunFact = "Model Królowej miał ponad 4 metry wysokości."
        },

        new CharacterModel() {
            Name = "Annalee",
            Surname = "Call",
            Role = "Członkini załogi statku Betty",
            Actor = "Winona Ryder",
            Spiecies = "Android (Auton – stworzony przez androidy)",
            BirthYear = 2381,
            Function = "Specjalistka ds. techniki i hakowania systemów.",
            Characteristics = "Empatyczna, emocjonalna, bardziej moralna niż większość ludzi.",
            Fate = "Przeżywa i opuszcza Ziemię wraz z Ripley 8.",
            FunFact = "Pierwszy android stworzony przez androidy."
        },

        new CharacterModel() {
            Name = "Ripley",
            Surname = "8",
            Role = "Klon Ellen Ripley z DNA królowej obcych",
            Actor = "Sigourney Weaver",
            Spiecies = "Hybryda (Człowiek / Obcy)",
            BirthYear = 2381,
            Function = "Pomaga załodze Betty w walce na USM Auriga.",
            Characteristics = "Silna, emocjonalnie rozdarta między dwiema naturami.",
            Fate = "Przeżywa, ale nie ufa ludziom ani korporacjom.",
            FunFact = "Ma kwaśną krew i nadludzkie zdolności."
        },

        new CharacterModel() {
            Name = "The",
            Surname = "Engineer",
            Role = "Starożytna istota – stwórca ludzi",
            Actor = "Ian Whyte",
            Spiecies = "Inżynier",
            BirthYear = 0,
            Function = "Reprezentant cywilizacji twórców; nie członek załogi.",
            Characteristics = "Milczący, potężny, symbol boskiej pychy.",
            Fate = "Budzi się i morduje załogę Prometeusza, później ginie.",
            FunFact = "Łączy mit stworzenia człowieka z początkiem obcych."
        },

        new CharacterModel() {
            Name = "Neomorph",
            Surname = "",
            Role = "Forma pośrednia między stworzeniem Davida a ksenomorfem",
            Actor = "CGI / efekty komputerowe",
            Spiecies = "Obcy (mutant)",
            BirthYear = 0,
            Function = "Stworzenie eksperymentalne Davida.",
            Characteristics = "Szybki, nieprzewidywalny, niestabilny biologicznie.",
            Fate = "Zabity przez załogę Covenant.",
            FunFact = "Inspirowany koncepcją „białego drapieżcy”."
        },

        new CharacterModel() {
            Name = "Daniels",
            Surname = "Branson",
            Role = "Oficer kolonizacyjny",
            Actor = "Katherine Waterston",
            Spiecies = "Człowiek",
            BirthYear = 2100,
            Function = "Projektantka kolonii, kieruje działaniami terraformacyjnymi.",
            Characteristics = "Pragmatyczna, odważna, zdeterminowana.",
            Fate = "Uśpiona przez Davida podszywającego się pod Waltera.",
            FunFact = "Scott chciał, by Daniels była symbolicznym nowym początkiem bohaterek."
}

    };
}
using System;
using System.Reactive;
using System.Reactive.Disposables;
using AlienDBMvvM.Models;
using AlienDBMvvM.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AlienDBMvvM.Views;

public partial class DetailWindow: ReactiveWindow<DetailWindowViewModel>
{
    public DetailWindow()
    {
        InitializeComponent();

        ViewModel = new DetailWindowViewModel(new FilmModel());
        DataContext = ViewModel;
        
        this.WhenActivated((CompositeDisposable disposables) =>
        {
            ViewModel.ShowCharactersWindow.RegisterHandler(async interaction =>
                {
                    var win = new CharacterWindow()
                    {
                        DataContext = new CharacterViewModel(interaction.Input)
                    };
                
                    await win.ShowDialog(this);
                    interaction.SetOutput(Unit.Default);
                
                })
                .DisposeWith(disposables);
        });
        
    }
}
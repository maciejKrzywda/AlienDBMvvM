using System;
using System.Reactive;
using System.Reactive.Disposables;
using AlienDBMvvM.ViewModels;
using Avalonia.Controls;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AlienDBMvvM.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
        
        ViewModel = new MainWindowViewModel();
        DataContext = ViewModel;

        this.WhenActivated((CompositeDisposable disposables) =>
        {
            ViewModel.ShowDetailsWindow.RegisterHandler(async interaction =>
            {
                var win = new DetailWindow()
                {
                    DataContext = new DetailWindowViewModel(interaction.Input)
                };
                
                Console.WriteLine(interaction.Input.Title);
                
                await win.ShowDialog(this);
                interaction.SetOutput(Unit.Default);
                
            })
                .DisposeWith(disposables);
        });

    }
}
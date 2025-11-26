using AlienDBMvvM.Models;
using AlienDBMvvM.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;

namespace AlienDBMvvM.Views;

public partial class DetailWindow: ReactiveWindow<DetailWindowViewModel>
{
    public DetailWindow()
    {
        InitializeComponent();
    }
}
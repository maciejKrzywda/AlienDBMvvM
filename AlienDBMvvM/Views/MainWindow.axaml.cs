using AlienDBMvvM.ViewModels;
using Avalonia.Controls;
using Avalonia.ReactiveUI;

namespace AlienDBMvvM.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
    }
}
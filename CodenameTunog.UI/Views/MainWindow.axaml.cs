using System;
using Avalonia.Controls;
using CodenameTunog.UI.ViewModels;
using FluentAvalonia.UI.Controls;

namespace CodenameTunog.UI.Views;

public partial class MainWindow : Window
{
    private MainViewModel ViewModel => (MainViewModel)DataContext!;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void LeftNav_SelectionChanged(object? sender, FANavigationViewSelectionChangedEventArgs e)
    {
        if (e.IsSettingsSelected)
        {
            ViewModel.CurrentPage = ViewModel.Pages["settings"];
            return;
        }

        if (e.SelectedItem is FANavigationViewItem item && item.Tag is string tag && ViewModel.Pages.TryGetValue(tag, out ViewModelBase? vm))
        {
            ViewModel.CurrentPage = vm;
        }
    }
}

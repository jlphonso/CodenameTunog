using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CodenameTunog.UI.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial ViewModelBase CurrentPage { get; set; }

    public Dictionary<string, ViewModelBase> Pages = new() {
        ["home"] = new HomeViewModel(),
        ["settings"] = new SettingsViewModel(),
    };

    public MainViewModel()
    {
        CurrentPage = Pages["home"];
    }
}

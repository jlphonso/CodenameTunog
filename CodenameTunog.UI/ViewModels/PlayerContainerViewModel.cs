using Avalonia.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CodenameTunog.UI.ViewModels;

public partial class PlayerContainerViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial Bitmap? MusicCover { get; set; }

    [ObservableProperty]
    public partial string? MusicTitle { get; set; }

    [ObservableProperty]
    public partial string? MusicArtist { get; set; }

}
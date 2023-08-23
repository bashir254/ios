using youkoso.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace youkoso.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;

    [ObservableProperty]
    string title;

    public bool IsNotBusy => !IsBusy;

    public static INavigation Navigation => Application.Current.MainPage.Navigation;

    public IAsyncRelayCommand RefreshCommand { get; set; }
    public RelayCommand   LoadMoreCommand { get; set; }
    public RelayCommand DelayLoadMoreCommand { get; set; }
    public IAsyncRelayCommand<string> FilterDataCommand { get; set; }
    public IAsyncRelayCommand<object> OpenAllCommand { get; set; }
    public RelayCommand SetThemeCommand { get; set; }
    public RelayCommand SetNumTutorialsCommand { get; set; }
    public IAsyncRelayCommand PlayPauseCommand { get; set; }
    public IAsyncRelayCommand StopCommand { get; set; }
    public IAsyncRelayCommand RewindCommand { get; set; }
    public IAsyncRelayCommand FastForwardCommand { get; set; }
    public IAsyncRelayCommand OpenInternalCommand { get; set; }
    public IAsyncRelayCommand OpenYoutubeCommand { get; set; }
    public IAsyncRelayCommand<string> searchCommand { get; set; }
    public IAsyncRelayCommand searchVocalCommand { get; set; }

    public BaseViewModel()
    {
    }

    //[RelayCommand]
    //async Task Back()
    //{
    //    //await Shell.Current.GoToAsync("..");
    //    await Shell.Current.GoToAsync(nameof(FormatMultiPage));
//  return true;
   //}

    protected Page CurrentPage => Application.Current.MainPage;
    protected Task DisplayAlert(string title, string message, string cancel) =>
        CurrentPage.DisplayAlert(title, message, cancel);

    public static Task OpenBrowserAsync(string url) =>
        Browser.OpenAsync(url, new BrowserLaunchOptions
        {
            LaunchMode = BrowserLaunchMode.SystemPreferred,
            TitleMode = BrowserTitleMode.Show,
            PreferredControlColor = Colors.White,
            PreferredToolbarColor = (Color)Application.Current.Resources["PrimaryColor"]
        });

}
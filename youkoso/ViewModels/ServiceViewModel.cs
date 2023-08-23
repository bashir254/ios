using youkoso.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.IO;
using System.ComponentModel;

namespace youkoso.ViewModels;

public partial class ServiceViewModel : BaseViewModel
{

public ServiceViewModel()
{
}

    [ObservableProperty]
    ObservableCollection<string> items;

    [RelayCommand]
    async Task School()
    {
    await Shell.Current.GoToAsync("SchoolPage");
        }

    [RelayCommand]
    async Task Lessons()
    {
    await Shell.Current.GoToAsync("LessonPage");
        }

    [RelayCommand]
    async Task Translate()
    {
    await Shell.Current.GoToAsync("TranslatePage");
        }

    [RelayCommand]
    async Task Cv()
    {
    await Shell.Current.GoToAsync("CvPage");
        }

    [RelayCommand]
    async Task Tour()
    {
    await Shell.Current.GoToAsync("TourPage");
        }

    [RelayCommand]
    async Task Source()
    {
    await Shell.Current.GoToAsync("SourcePage");
        }

}
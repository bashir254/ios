using youkoso.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.IO;
using System.ComponentModel;

 using System.Net;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace youkoso.ViewModels;

public partial class WeeklyViewModel : BaseViewModel
    {
    [ObservableProperty]
    string text;

        public WeeklyViewModel()
        {
}

    [RelayCommand]
    async Task Lesson1()
    {
WebViewModel.tutorialUrl = WeeklyPage.week111;
    await Shell.Current.GoToAsync("WebPage");
        }

    [RelayCommand]
    async Task Lesson2()
    {
WebViewModel.tutorialUrl = WeeklyPage.week222;
    await Shell.Current.GoToAsync("WebPage");
        }

    [RelayCommand]
    async Task Lesson3()
    {
WebViewModel.tutorialUrl = WeeklyPage.week333;
    await Shell.Current.GoToAsync("WebPage");
        }

    [RelayCommand]
    async Task Lesson4()
    {
WebViewModel.tutorialUrl = WeeklyPage.week444;
    await Shell.Current.GoToAsync("WebPage");
        }

}
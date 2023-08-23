using youkoso.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.IO;
using System.ComponentModel;

namespace youkoso.ViewModels;

public partial class WordsViewModel : BaseViewModel
{

public WordsViewModel()
{
}

    [RelayCommand]
    async Task Btn1()
    {
            NetworkAccess current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
    await Shell.Current.GoToAsync("GreetingPage");
} else {
                await App.Current.MainPage.DisplayAlert("تنبيه", "لا يوجد اتصال بالأنترنيت, المرجو إعادة المحاولة", "OK");
            }
        }

    [RelayCommand]
    async Task Btn2()
    {
            NetworkAccess current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
    await Shell.Current.GoToAsync("TimePage");
} else {
                await App.Current.MainPage.DisplayAlert("تنبيه", "لا يوجد اتصال بالأنترنيت, المرجو إعادة المحاولة", "OK");
            }
        }

    [RelayCommand]
    async Task Btn3()
    {
            NetworkAccess current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
    await Shell.Current.GoToAsync("FamilyPage");
} else {
                await App.Current.MainPage.DisplayAlert("تنبيه", "لا يوجد اتصال بالأنترنيت, المرجو إعادة المحاولة", "OK");
            }
        }

    [RelayCommand]
    async Task Btn4()
    {
            NetworkAccess current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
    await Shell.Current.GoToAsync("NamesPage");
} else {
                await App.Current.MainPage.DisplayAlert("تنبيه", "لا يوجد اتصال بالأنترنيت, المرجو إعادة المحاولة", "OK");
            }
        }

    [RelayCommand]
    async Task Btn5()
    {
            NetworkAccess current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
    await Shell.Current.GoToAsync("BodyPage");
} else {
                await App.Current.MainPage.DisplayAlert("تنبيه", "لا يوجد اتصال بالأنترنيت, المرجو إعادة المحاولة", "OK");
            }
        }

}
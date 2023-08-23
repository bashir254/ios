using youkoso.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.IO;
using System.ComponentModel;

namespace youkoso.ViewModels;

public partial class CharacterViewModel :BaseViewModel
{

public CharacterViewModel()
{
}

    [RelayCommand]
    async Task Letter()
    {
            NetworkAccess current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
WebViewModel.tutorialUrl = "https://codeuniverse.net/japanese/characters/letter1.html";
    await Shell.Current.GoToAsync("WebPage");
} else {
                await App.Current.MainPage.DisplayAlert("تنبيه", "لا يوجد اتصال بالأنترنيت, المرجو إعادة المحاولة", "OK");
            }
        }

    [RelayCommand]
    async Task Hiragana()
    {
    await Shell.Current.GoToAsync("HiraganaPage");
        }

    [RelayCommand]
    async Task Katakana()
    {
    await Shell.Current.GoToAsync("KatakanaPage");
        }

}
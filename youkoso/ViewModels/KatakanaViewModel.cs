using youkoso.Models;
using youkoso.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.IO;
using System.ComponentModel;

namespace youkoso.ViewModels;

public partial class KatakanaViewModel : BaseViewModel
{
        public ObservableCollection<Items> Items { get; set; }

public KatakanaViewModel()
{
}

    [RelayCommand]
    async Task Btn1()
    {
            NetworkAccess current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
    await Shell.Current.GoToAsync("Katakana1Page");
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
    await Shell.Current.GoToAsync("Katakana2Page");
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
    await Shell.Current.GoToAsync("Katakana3Page");
} else {
                await App.Current.MainPage.DisplayAlert("تنبيه", "لا يوجد اتصال بالأنترنيت, المرجو إعادة المحاولة", "OK");
            }
        }

}
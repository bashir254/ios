using youkoso.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.IO;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;

namespace youkoso.ViewModels;

public partial class MoreViewModel : BaseViewModel
{

public MoreViewModel()
{
}

    [RelayCommand]
    async Task MyAccount()
    {
    await Shell.Current.GoToAsync("MemberPage");
        }

    [RelayCommand]
    async Task Help()
    {
            NetworkAccess current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
    await Shell.Current.GoToAsync("EmailSupportPage");
}            else
            {
                await App.Current.MainPage.DisplayAlert("تنبيه", "لا يوجد اتصال بالأنترنيت, المرجو إعادة المحاولة", "OK");
            }
        }

    [RelayCommand]
    async Task Btn5()
    {
            NetworkAccess current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
WebViewModel.tutorialUrl = "https://codeuniverse.net/japanese/services/mham2.html";
    await Shell.Current.GoToAsync("WebPage");
} else {
                await App.Current.MainPage.DisplayAlert("تنبيه", "لا يوجد اتصال بالأنترنيت, المرجو إعادة المحاولة", "OK");
            }
        }

}
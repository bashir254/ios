using youkoso.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.IO;
using System.ComponentModel;

namespace youkoso.ViewModels;

public partial class MemberViewModel : BaseViewModel
{

public MemberViewModel()
{
//App.Current.MainPage.DisplayAlert("", Settings.Login.ToString(), "OK");    
}

    [RelayCommand]
    async Task Btn1()
    {
    await Shell.Current.GoToAsync("SignIn");
        }

    [RelayCommand]
    async Task Btn2()
    {
Settings.Login = 0;
    await Shell.Current.GoToAsync("MemberPage");
        }

    [RelayCommand]
    async Task Btn3()
    {
    await Shell.Current.GoToAsync("SignUp");
        }

}
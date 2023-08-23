using youkoso.Models;
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

public partial class SignUpViewModel : BaseViewModel
{
        public ObservableCollection<Items> Items { get; set; }

    [ObservableProperty]
    string text;
    [ObservableProperty]
    string text2;
    [ObservableProperty]
    string text3;
    [ObservableProperty]
    string text4;

public SignUpViewModel()
{
}

    [RelayCommand]
    async Task Btn1()
    {
            NetworkAccess current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
var hc = new HttpClient();
var dic = new Dictionary<string, string>();
dic["name"] = Text;
dic["mail"] = Text2;
dic["pass"] = Text3;
dic["tel"] = Text4;
var cont = new FormUrlEncodedContent(dic);
var url = "https://codeuniverse.net/japanese/registration/registration/signup_app.php";
var req = await hc.PostAsync(url, cont);
var html = await req.Content.ReadAsStringAsync();
if (html.Contains("خطأ"))
{
await App.Current.MainPage.DisplayAlert("", html, "OK");    
return;
}
await App.Current.MainPage.DisplayAlert("", html, "OK");    
}            else
            {
                await App.Current.MainPage.DisplayAlert("تنبيه", "لا يوجد اتصال بالأنترنيت, المرجو إعادة المحاولة", "OK");
            }
//                await Navigation.PushModalAsync(new MorePage());
        }

}
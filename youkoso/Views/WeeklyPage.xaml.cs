using youkoso.Models;
using youkoso.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices.Sensors;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;

 using System.Net;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace youkoso.Views;

public partial class WeeklyPage : ContentPage
{
public static string week111 = "";
public static string week222 = "";
public static string week333 = "";
public static string week444 = "";
public ObservableCollection<Items> _customers = new ObservableCollection<Items>();

    public WeeklyPage()
	{
            NetworkAccess current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
read_db();
} else {
//                await 
App.Current.MainPage.DisplayAlert("تنبيه", "لا يوجد اتصال بالأنترنيت, المرجو إعادة المحاولة", "OK");
            }
		InitializeComponent();
            BindingContext = new WeeklyViewModel();
    }

public async void read_db()
{
var hc = new HttpClient();
var dic = new Dictionary<string, string>();
var cont = new FormUrlEncodedContent(dic);
var url = "https://codeuniverse.net/japanese/registration/registration/weekly_lesson.php";
var req = await hc.PostAsync(url, cont);
var html = await req.Content.ReadAsStringAsync();
if (html.Contains("null"))
{
await App.Current.MainPage.DisplayAlert("خطأ, ", "عنوان البريد الإلكتروني أو كلمة المرور التي تم إدخالها غير صحيحة, الرجاء إعادة المحاولة مرة أخرى", "OK");    
return;
}

            Dat[] jsonData = new Dat[1];
            jsonData = JsonConvert.DeserializeObject<Dat[]>(html);

            foreach(Dat item in jsonData)
            {
if (item.week12.Contains("no"))
{
lesson1.IsVisible = false;
} else {
week111 = item.week1;
lesson1.Text = item.week12;
}
if (item.week22.Contains("no"))
{
lesson2.IsVisible = false;
} else {
week222 = item.week2;
lesson2.Text = item.week22;
}
if (item.week32.Contains("no"))
{
lesson3.IsVisible = false;
} else {
week333 = item.week3;
lesson3.Text = item.week32;
}
if (item.week42.Contains("no"))
{
lesson4.IsVisible = false;
} else {
week444 = item.week4;
lesson4.Text = item.week42;
}

            }
}

}

public class Dat {
    public string week1 { get; set; }
    public string week12 { get; set; }
    public string week2 { get; set; }
    public string week22 { get; set; }
    public string week3 { get; set; }
    public string week32 { get; set; }
    public string week4 { get; set; }
    public string week42 { get; set; }
}
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

public partial class SignInViewModel : BaseViewModel
{
string fname = System.IO.Path.Combine(FileSystem.Current.AppDataDirectory, "sudan.txt");

    [ObservableProperty]
    string text;
    [ObservableProperty]
    string text2;

public SignInViewModel()
{
//write_txt("أنا أسمي محمد بشير", fname);
}

    [RelayCommand]
    async Task Btn1()
    {
            NetworkAccess current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
read_db();
}            else
            {
                await App.Current.MainPage.DisplayAlert("تنبيه", "لا يوجد اتصال بالأنترنيت, المرجو إعادة المحاولة", "OK");
            }
        }

public async void read_db()
{
var hc = new HttpClient();
var dic = new Dictionary<string, string>();
dic["email"] = Text;
dic["pass"] = Text2;
var cont = new FormUrlEncodedContent(dic);
var url = "https://codeuniverse.net/japanese/registration/registration/login_app.php";
var req = await hc.PostAsync(url, cont);
var html = await req.Content.ReadAsStringAsync();
if (html.Contains("null"))
{
await App.Current.MainPage.DisplayAlert("خطأ, ", "عنوان البريد الإلكتروني أو كلمة المرور التي تم إدخالها غير صحيحة, الرجاء إعادة المحاولة مرة أخرى", "OK");    
return;
}
//return;

            Dat[] jsonData = new Dat[1];
            jsonData = JsonConvert.DeserializeObject<Dat[]>(html);

            foreach(Dat item in jsonData)
            {
Settings.Name = item.name;
//string code = item.code.ToString();
//await App.Current.MainPage.DisplayAlert(item.name, "", "OK");    
//await App.Current.MainPage.DisplayAlert(item.mail, "", "OK");    
//await App.Current.MainPage.DisplayAlert(item.time, "", "OK");    
//await App.Current.MainPage.DisplayAlert(item.tel, "", "OK");    
Settings.Login = 1;
            }
    await Shell.Current.GoToAsync("MemberPage");
}

public async void read_txt(string fname)
{
using FileStream fs = File.OpenRead(fname);
using var sr = new StreamReader(fs);

string line;

while ((line = sr.ReadLine()) != null)
{
await App.Current.MainPage.DisplayAlert("", line, "OK");    
//    Console.WriteLine(line);
}
}

public void write_txt(string text, string fname)
{
using FileStream fs = File.Create(fname);
using var sr = new StreamWriter(fs);

sr.WriteLine(text);

}

public async void WriteTextToFile(string text, string targetFileName)
{
    string targetFile = System.IO.Path.Combine(FileSystem.Current.AppDataDirectory, targetFileName + ".txt");
    using FileStream outputStream = System.IO.File.OpenWrite(targetFile);
    using StreamWriter streamWriter = new StreamWriter(outputStream);
    await streamWriter.WriteAsync(text);
}

}

public class Dat {
    public string code { get; set; }
    public string name { get; set; }
    public string mail { get; set; }
    public string pass { get; set; }
    public string tel { get; set; }
    public string time { get; set; }
}
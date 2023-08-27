using youkoso.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.IO;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;

namespace youkoso.ViewModels;

public partial class SchoolViewModel : BaseViewModel
{
    [ObservableProperty]
    string text;

public SchoolViewModel()
{
}

    [RelayCommand]
    async Task Lessons()
    {
            NetworkAccess current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
WebViewModel.tutorialUrl = "https://codeuniverse.net/japanese/services/school.html";
    await Shell.Current.GoToAsync("WebPage");
} else {
                await App.Current.MainPage.DisplayAlert("تنبيه", "لا يوجد اتصال بالأنترنيت, المرجو إعادة المحاولة", "OK");
            }
        }

    [RelayCommand]
    async Task Send()
    {
if (string.IsNullOrEmpty(Text))
{   
await App.Current.MainPage.DisplayAlert("رسالة خطأ ", "قبل إرسال الطلب يجب كتابة محتوى الرسالة بالتفاصيل", "OK");    
return;
}
            NetworkAccess current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
    try
    {
if (Microsoft.Maui.ApplicationModel.Communication.Email.Default.IsComposeSupported)
{

    string subject = "طلب المساعدة للدراسة باليابان";
    string body = text;
    string[] recipients = new[] { "bashir633@gmail.com" };

    var message = new EmailMessage
    {
        Subject = subject,
        Body = body,
        BodyFormat = EmailBodyFormat.PlainText,
        To = new List<string>(recipients)
    };
    await Microsoft.Maui.ApplicationModel.Communication.Email.Default.ComposeAsync(message);
}
                await App.Current.MainPage.DisplayAlert("نجاح ", " تم إرسال طلبك بنجاح, وسوف نقوم بالرد عليك في أقرب فرصة ممكنة, على وسيلة التواصل التي تم تحديدها", "OK");
    }
    catch (Exception)
    {
                await App.Current.MainPage.DisplayAlert("رسالة خطأ ", "لم يتم إرسال الطلبك, فنرجو منك إعادة المحاولة مرة أخرى", "OK");
return;
    }

    await Shell.Current.GoToAsync("..");
}            else
            {
                await App.Current.MainPage.DisplayAlert("تنبيه", "لا يوجد اتصال بالأنترنيت, المرجو إعادة المحاولة", "OK");
            }
        }

}
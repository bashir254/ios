using youkoso.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.IO;
using System.ComponentModel;
using Microsoft.Maui.ApplicationModel.Communication;

namespace youkoso.ViewModels
{
    public class Email
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<string> Recipients { get; set; }
    }

    public partial class EmailSupportViewModel : BaseViewModel
    {
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;
public new bool IsNotBusy { get; set; }
    public bool IsNotBusy => !IsBusy;
        public ObservableCollection<string> SubjectsList { get; }
    [ObservableProperty]
        string emailSubject;
    [ObservableProperty]
        string emailBody;

        public EmailSupportViewModel()
        {
            IsBusy = false;
            SubjectsList = new ObservableCollection<string> { "طلب استشارة برمجية", "طلب تطوير برامج ومواقع", "اقتراحات حول التطبيق", "مشاكل حول التطبيق", "غير ذلك" };
        }

        [RelayCommand]
        void PrepareEmail()
        {
            foreach (var subject in SubjectsList)
            {
                if (emailSubject == "غير ذلك")
                {
                    IsBusy = true;
                }
                else if (emailSubject == subject && emailSubject != "غير ذلك")
                {
                    IsBusy = false;
                }
            }
        }

        [RelayCommand]
        async Task SendEmail(Email email)
        {
if (string.IsNullOrEmpty(emailBody))
{   
App.Current.MainPage.DisplayAlert("رسالة خطأ ", "قبل إرسال الطلب يجب كتابة محتوى الرسالة بالتفاصيل", "OK");    
return;
}
            NetworkAccess current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
    try
    {
if (Microsoft.Maui.ApplicationModel.Communication.Email.Default.IsComposeSupported)
{

    string subject = emailSubject;
    string body = emailBody;
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
}
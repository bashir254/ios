using youkoso.Models;
using youkoso.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.IO;
using System.ComponentModel;
using Microsoft.Maui.Controls;
using System.Diagnostics;

namespace youkoso.ViewModels;

public partial class SearchViewModel : BaseViewModel
{
ObservableCollection<Items> Items1 { get; set; }

    [ObservableProperty]
    string text;
    [ObservableProperty]
    string text2;

    public SearchViewModel()
    {
            Items1 = new ObservableCollection<Items>();
    }

    [RelayCommand]
    async Task Btn1()
    {
if (string.IsNullOrEmpty(Text))
{   
App.Current.MainPage.DisplayAlert("رسالة خطأ ", "يجب كتابة كلمة البحث أولا", "OK");    
return;
}
Items1.Clear();
int indexer = 5000;
Text2 = "";
for (int i = 0; i <= DictionaryViewModel.kana.Count - 1; ++i)
{
if (DictionaryViewModel.kana[i].ToString().Contains(Text))
{
Text2 += DictionaryViewModel.kana[i].ToString() + "\n" + DictionaryViewModel.kanji[i].ToString() + "\n" + DictionaryViewModel.arabic[i].ToString() + "			";
indexer = i;
Items1.Add(new Items { Id = i, Name = DictionaryViewModel.kana[i].ToString(), Url = "https://codeuniverse.net/japanese/words/body/s" });
Items1.Add(new Items { Id = i, Name = DictionaryViewModel.kanji[i].ToString(), Url = "https://codeuniverse.net/japanese/words/body/s" });
Items1.Add(new Items { Id = i, Name = DictionaryViewModel.arabic[i].ToString(), Url = "https://codeuniverse.net/japanese/words/body/s" });
}
}

if (indexer == 5000)
{
for (int i = 0; i <= DictionaryViewModel.kanji.Count - 1; ++i)
{
if (DictionaryViewModel.kanji[i].ToString().Contains(Text))
{
Text2 += DictionaryViewModel.kana[i].ToString() + "\n" + DictionaryViewModel.kanji[i].ToString() + "\n" + DictionaryViewModel.arabic[i].ToString() + "			";
indexer = i;
Items1.Add(new Items { Id = i, Name = DictionaryViewModel.kana[i].ToString(), Url = "https://codeuniverse.net/japanese/words/body/s" });
Items1.Add(new Items { Id = i, Name = DictionaryViewModel.kanji[i].ToString(), Url = "https://codeuniverse.net/japanese/words/body/s" });
Items1.Add(new Items { Id = i, Name = DictionaryViewModel.arabic[i].ToString(), Url = "https://codeuniverse.net/japanese/words/body/s" });
}
}
}

if (indexer == 5000)
{
for (int i = 0; i <= DictionaryViewModel.arabic.Count - 1; ++i)
{
if (DictionaryViewModel.arabic[i].ToString().Contains(Text))
{
Text2 += DictionaryViewModel.kana[i].ToString() + "\n" + DictionaryViewModel.kanji[i].ToString() + "\n" + DictionaryViewModel.arabic[i].ToString() + "\n";
Items1.Add(new Items { Id = i, Name = DictionaryViewModel.kana[i].ToString(), Url = "https://codeuniverse.net/japanese/words/body/s" });
Items1.Add(new Items { Id = i, Name = DictionaryViewModel.kanji[i].ToString(), Url = "https://codeuniverse.net/japanese/words/body/s" });
Items1.Add(new Items { Id = i, Name = DictionaryViewModel.arabic[i].ToString(), Url = "https://codeuniverse.net/japanese/words/body/s" });
}
}
}

if (indexer == 5000)
{
//App.Current.MainPage.DisplayAlert("غير موجود ", " لم يتم العثور على كلمة البحث " + Text, "OK");    
}

        if (Items1.Count > 0)
        {
        }
        else
        {
App.Current.MainPage.DisplayAlert("غير موجود ", " لم يتم العثور على كلمة البحث " + Text, "OK");    
        }
    }

}
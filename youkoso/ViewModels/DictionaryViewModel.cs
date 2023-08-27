using youkoso.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.IO;
using System.ComponentModel;

namespace youkoso.ViewModels;

public partial class DictionaryViewModel : BaseViewModel
    {
public static List<string> kana = new List<string>();
public static List<string> kanji = new List<string>();
public static List<string> arabic = new List<string>();
public static int word_no = Settings.Dic_no;
    [ObservableProperty]
    string word1;
    [ObservableProperty]
    string word2;

        public DictionaryViewModel()
        {
read_dic();
Word1= kana[word_no].ToString() + "\r\n" + kanji[word_no].ToString();
Word2= arabic[word_no].ToString();
}

public void read_dic()
{
String[] l = dic2.dictionary.Split("\r\n");
kana.Clear();
kanji.Clear();
arabic.Clear();
for (int i = 0; i <= l.Length - 1; i++)
{
String[] l2 = l[i].ToString().Split('	');
kana.Add(l2[0].ToString());
kanji.Add(l2[1].ToString());
arabic.Add(l2[2].ToString());
}
}

    [RelayCommand]
    async Task Search()
    {
    await Shell.Current.GoToAsync("SearchPage");
}

    [RelayCommand]
public Task GoBack()
    {
if (word_no != 0)
word_no = (word_no - 1);
Word1= kana[word_no].ToString() + "\r\n" + kanji[word_no].ToString();
Word2= arabic[word_no].ToString();
Settings.Dic_no = word_no;
    return Task.CompletedTask;
        }

    [RelayCommand]
public Task GoNext()
    {
if (word_no <= (kana.Count - 2))
{
word_no = (word_no + 1);
Word1= kana[word_no].ToString() + "\r\n" + kanji[word_no].ToString();
Word2= arabic[word_no].ToString();
//App.Current.MainPage.DisplayAlert("", Word2, "OK");    
Settings.Dic_no = word_no;
}
    return Task.CompletedTask;
        }

}
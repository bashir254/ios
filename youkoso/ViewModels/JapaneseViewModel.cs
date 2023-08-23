using youkoso.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.IO;
using System.ComponentModel;
using System.Diagnostics;

namespace youkoso.ViewModels;

public partial class JapaneseViewModel : BaseViewModel
{

public JapaneseViewModel()
{
}

    [RelayCommand]
    async Task Character()
    {
    await Shell.Current.GoToAsync("CharacterPage");
        }

    [RelayCommand]
    async Task Number()
    {
    await Shell.Current.GoToAsync("NumberPage");
        }

    [RelayCommand]
    async Task Words()
    {
    await Shell.Current.GoToAsync("WordsPage");
        }

    [RelayCommand]
    async Task Weekly()
    {
    await Shell.Current.GoToAsync("WeeklyPage");
        }

    [RelayCommand]
    async Task Dic()
    {
    await Shell.Current.GoToAsync("DictionaryPage");
        }

}
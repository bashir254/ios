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

public partial class Katakana2ViewModel : BaseViewModel
{
        public ObservableCollection<Items> TutorialsList1 { get; set; }
Items selectedTutorial;
        public Items SelectedTutorial
        {
            get { return selectedTutorial; }
            set { SetProperty(ref selectedTutorial, value); }
        }

public Katakana2ViewModel()
{
read_characters();
}

        public async void read_characters()
        {
TutorialsList1 = new ObservableCollection<Items>();
TutorialsList1.Clear();
for (int i = 0; i <= 49; i=i+2)
{
TutorialsList1.Add(new Items { Id = int.Parse(App.no[i]), Name = App.k2[i].ToString()+"."+App.k2[(i+1)].ToString(), Url = "https://codeuniverse.net/japanese/characters/s2/s" + App.no[i].ToString() + ".mp3" });
            }
        }

}
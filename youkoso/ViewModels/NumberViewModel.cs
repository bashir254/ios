using youkoso.Models;
 using youkoso.Views;
//using youkoso.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.IO;
using System.ComponentModel;

namespace youkoso.ViewModels;

public partial class NumberViewModel : BaseViewModel
{
        public ObservableCollection<Items> TutorialsList1 { get; set; }
Items selectedTutorial;
        public Items SelectedTutorial
        {
            get { return selectedTutorial; }
            set { SetProperty(ref selectedTutorial, value); }
        }

public NumberViewModel()
{
read_characters();
}

        public void read_characters()
        {
TutorialsList1 = new ObservableCollection<Items>();
TutorialsList1.Clear();
for (int i = 0; i <= App.number.Count - 12; i=i+2)
{
TutorialsList1.Add(new Items { Id = int.Parse(App.no[i]), Name = App.number[i].ToString()+"."+App.number[(i+1)].ToString(), Url = "https://codeuniverse.net/japanese/number/s1/s" + App.no[i].ToString() + ".mp3" });
            }
        }

}
using youkoso.Models;
using youkoso.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices.Sensors;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;

namespace youkoso.Views;

public partial class Katakana1Page : ContentPage
{

    public Katakana1Page()
	{
		InitializeComponent();
            BindingContext = new Katakana1ViewModel();
    }

        void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
//App.Current.MainPage.DisplayAlert("", "videoUrl", "OK");
            if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
            {
                var item = e.CurrentSelection[0] as Items;
string url = item.Url;
amedia.Source = new Uri(url);
amedia.Play();
}
}

}
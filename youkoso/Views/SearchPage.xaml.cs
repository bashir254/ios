using youkoso.Models;
using youkoso.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices.Sensors;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;

namespace youkoso.Views;

public partial class SearchPage : ContentPage
{

    public SearchPage()
	{
		InitializeComponent();
            BindingContext = new SearchViewModel();
    }

}
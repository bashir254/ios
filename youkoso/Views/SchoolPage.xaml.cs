using youkoso.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices.Sensors;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;

namespace youkoso.Views;

public partial class SchoolPage : ContentPage
{

	public SchoolPage()
	{
		InitializeComponent();
            BindingContext = new SchoolViewModel();
	}

}
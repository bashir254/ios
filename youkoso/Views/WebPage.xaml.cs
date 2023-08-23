using youkoso.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices.Sensors;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;

namespace youkoso.Views;

public partial class WebPage : ContentPage
{

    public WebPage()
	{
		InitializeComponent();
            BindingContext = new WebViewModel();
webBrowser.Reload();
        webBrowser.Source = WebViewModel.tutorialUrl;
    }

    protected override bool OnBackButtonPressed()
    {
        if (webBrowser .CanGoBack)
        {
            webBrowser .GoBack();
            return true;
        }
        else
        {
        return base.OnBackButtonPressed();
        }
    }

}
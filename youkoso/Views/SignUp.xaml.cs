using youkoso.Models;
using youkoso.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices.Sensors;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;

namespace youkoso.Views;

public partial class SignUp : ContentPage
{
public ObservableCollection<Items> _customers = new ObservableCollection<Items>();

    public SignUp()
	{
		InitializeComponent();
            BindingContext = new SignUpViewModel();
    }

}
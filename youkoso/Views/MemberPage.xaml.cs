using youkoso.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices.Sensors;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;

namespace youkoso.Views;

public partial class MemberPage : ContentPage
{

    public MemberPage()
	{
		InitializeComponent();
            BindingContext = new MemberViewModel();
if (Settings.Login == 0)
{
btn2.IsVisible = false;
}else {
name1.Text = "مرحبا بك عزيزي " + Settings.Name;
btn1.IsVisible = false;
btn3.IsVisible = false;
}
    }

}
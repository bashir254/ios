using youkoso.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices.Sensors;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace youkoso.Views;

public partial class JapanesePage : ContentPage
{
//        public string INTERSTITIALID = DeviceInfo.Platform == DevicePlatform.iOS ? "ca-app-pub-3940256099942544/1033173712" : "ca-app-pub-3940256099942544/1033173712";
//        public string REWARDEDID = DeviceInfo.Platform == DevicePlatform.iOS ? "ca-app-pub-3940256099942544/5224354917" : "ca-app-pub-3940256099942544/5224354917";
//        public string REWARDINTERSTITIALID = DeviceInfo.Platform == DevicePlatform.iOS ? "ca-app-pub-3940256099942544/5354046379" : "ca-app-pub-3940256099942544/5354046379";

	public JapanesePage()
	{
		InitializeComponent();
            BindingContext = new JapaneseViewModel();
	}

}
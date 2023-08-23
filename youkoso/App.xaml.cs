using System.IO;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices.Sensors;
using youkoso.Views;
using youkoso;

namespace youkoso;

public partial class App : Application
{
public static List<string> h1 = new List<string>();
public static List<string> h2 = new List<string>();
public static List<string> h3 = new List<string>();
public static List<string> k1 = new List<string>();
public static List<string> k2 = new List<string>();
public static List<string> k3 = new List<string>();
public static List<string> no = new List<string>();
public static List<string> number = new List<string>();
public static List<string> time = new List<string>();
public static List<string> greeting = new List<string>();
public static List<string> names = new List<string>();
public static List<string> family = new List<string>();
public static List<string> body = new List<string>();

public static string dir = "";
public static string fname = "";

    public App()
	{
		InitializeComponent();
        requestPermission().ConfigureAwait(false);
dir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        MainPage = new AppShell();
write_db2();
	}

void write_db2()
{
String[] l = dbData.db_data.Split("\r\n");
number.Clear();
for (int i = 0; i <= l.Length - 1; i++)
{
String[] l2 = l[i].ToString().Split('	');
h1.Add(l2[0].ToString());
k1.Add(l2[1].ToString());
h2.Add(l2[2].ToString());
k2.Add(l2[3].ToString());
h3.Add(l2[4].ToString());
k3.Add(l2[5].ToString());
no.Add(l2[6].ToString());
number.Add(l2[7].ToString());
time.Add(l2[8].ToString());
greeting.Add(l2[9].ToString());
names.Add(l2[10].ToString());
family.Add(l2[11].ToString());
body.Add(l2[12].ToString());
}
}

    async Task requestPermission()
    {
        var status = await Permissions.RequestAsync<Permissions.NetworkState>();
        status = await Permissions.RequestAsync<Permissions.Media>();
//        status = await Permissions.RequestAsync<Permissions.Microphone>();
        status = await Permissions.RequestAsync<Permissions.StorageWrite>();
        status = await Permissions.RequestAsync<Permissions.StorageRead>();
    }

}
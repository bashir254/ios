using youkoso.Models;
using youkoso.Views;
//using youkoso.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.IO;
using System.ComponentModel;

namespace youkoso.Models;

    public class Items
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string time { get; set; } = string.Empty;
        public override string ToString()
        {
return Name;
        }

}

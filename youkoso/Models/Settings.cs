namespace youkoso;

    public class Settings
    {
        const int dic_no = 0;
        public static int Dic_no
        {
            get => Preferences.Get(nameof(Dic_no), dic_no);
            set => Preferences.Set(nameof(Dic_no), value);
        }
        const int login = 0;
        public static int Login
        {
            get => Preferences.Get(nameof(Login), login);
            set => Preferences.Set(nameof(Login), value);
        }
        const string name = "";
        public static string Name
        {
            get => Preferences.Get(nameof(Name), name);
            set => Preferences.Set(nameof(Name), value);
        }

}
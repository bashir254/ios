using youkoso.Models;
using youkoso.Views;

namespace youkoso;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(CharacterPage), typeof(CharacterPage));
        Routing.RegisterRoute(nameof(Hiragana1Page), typeof(Hiragana1Page));
        Routing.RegisterRoute(nameof(Hiragana2Page), typeof(Hiragana2Page));
        Routing.RegisterRoute(nameof(Hiragana3Page), typeof(Hiragana3Page));
        Routing.RegisterRoute(nameof(HiraganaPage), typeof(HiraganaPage));
        Routing.RegisterRoute(nameof(Katakana1Page), typeof(Katakana1Page));
        Routing.RegisterRoute(nameof(Katakana2Page), typeof(Katakana2Page));
        Routing.RegisterRoute(nameof(Katakana3Page), typeof(Katakana3Page));
        Routing.RegisterRoute(nameof(KatakanaPage), typeof(KatakanaPage));
        Routing.RegisterRoute(nameof(WebPage), typeof(WebPage));
        Routing.RegisterRoute(nameof(WordsPage), typeof(WordsPage));
        Routing.RegisterRoute(nameof(BodyPage), typeof(BodyPage));
        Routing.RegisterRoute(nameof(DictionaryPage), typeof(DictionaryPage));
        Routing.RegisterRoute(nameof(SearchPage), typeof(SearchPage));
        Routing.RegisterRoute(nameof(FamilyPage), typeof(FamilyPage));
        Routing.RegisterRoute(nameof(GreetingPage), typeof(GreetingPage));
        Routing.RegisterRoute(nameof(NamesPage), typeof(NamesPage));
        Routing.RegisterRoute(nameof(NumberPage), typeof(NumberPage));
        Routing.RegisterRoute(nameof(TimePage), typeof(TimePage));
        Routing.RegisterRoute(nameof(WeeklyPage), typeof(WeeklyPage));

        Routing.RegisterRoute(nameof(SchoolPage), typeof(SchoolPage));
        Routing.RegisterRoute(nameof(TranslatePage), typeof(TranslatePage));
        Routing.RegisterRoute(nameof(CvPage), typeof(CvPage));
        Routing.RegisterRoute(nameof(LessonPage), typeof(LessonPage));
        Routing.RegisterRoute(nameof(TourPage), typeof(TourPage));
        Routing.RegisterRoute(nameof(SourcePage), typeof(SourcePage));

        Routing.RegisterRoute(nameof(SignIn), typeof(SignIn));
        Routing.RegisterRoute(nameof(SignUp), typeof(SignUp));
        Routing.RegisterRoute(nameof(MemberPage), typeof(MemberPage));
        Routing.RegisterRoute(nameof(EmailSupportPage), typeof(EmailSupportPage));

    }
}
using MAUI_TRP.Views;

namespace MAUI_TRP;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new RegistrationPage());
	}
}

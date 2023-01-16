namespace MAUI_TRP.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private void OnCreateAccountClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new RegistrationPage());
	}
}

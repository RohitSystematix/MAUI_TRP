namespace MAUI_TRP.Views;

public partial class RegistrationPage : ContentPage
{
	public RegistrationPage()
	{
		InitializeComponent();
	}

	private void Entry_Focused(object sender, FocusEventArgs e)
	{
        // Decete whethe in iOS platform
        if (DeviceInfo.Platform == DevicePlatform.iOS)
        {
            //iphoneX and above
            if (Height > 800)
            {
                if (Height - SendUI.Y - SendUI.Height < 333)
                {
                    SendUI.TranslateTo(0, -313, 50);

                }
            }
            //lower screen size of iOS
            else
            {
                if (Height - SendUI.Y - SendUI.Height < 258)
                {
                    SendUI.TranslateTo(0, -258, 50);
                }
            }
        }
    }

	private void Entry_Unfocused(object sender, FocusEventArgs e)
	{
        if (DeviceInfo.Current.Platform == DevicePlatform.iOS)
        {
            SendUI.TranslateTo(0, 0, 50);
        }
    }
}
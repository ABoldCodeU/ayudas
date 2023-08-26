namespace AxitHome.Views.Pages.ProfilePages;

public partial class OTPVerificationPage : ContentPage
{
	public OTPVerificationPage()
	{
		InitializeComponent();
	}

    private async void Button_Back(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
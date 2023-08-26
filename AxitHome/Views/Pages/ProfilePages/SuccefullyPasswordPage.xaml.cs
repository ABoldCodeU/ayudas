namespace AxitHome.Views.Pages.ProfilePages;

public partial class SuccefullyPasswordPage : ContentPage
{
	public SuccefullyPasswordPage()
	{
		InitializeComponent();
	}

    private async void Button_Back(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
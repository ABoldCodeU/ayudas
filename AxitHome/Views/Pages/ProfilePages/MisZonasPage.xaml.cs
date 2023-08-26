namespace AxitHome.Views.Pages.ProfilePages;

public partial class MisZonasPage : ContentPage
{
	public MisZonasPage()
	{
		InitializeComponent();
	}

    private async void Button_Back(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
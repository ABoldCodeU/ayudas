namespace AxitHome.Views.Pages.ProfilePages;

public partial class CambiarContraseaPage : ContentPage
{
	public CambiarContraseaPage()
	{
		InitializeComponent();
	}

    private async void Button_Back(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
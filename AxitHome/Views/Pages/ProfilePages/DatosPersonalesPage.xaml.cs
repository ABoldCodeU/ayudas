namespace AxitHome.Views.Pages.ProfilePages;

public partial class DatosPersonalesPage : ContentPage
{
	public DatosPersonalesPage()
	{
		InitializeComponent();
	}

    private async void Button_Back(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
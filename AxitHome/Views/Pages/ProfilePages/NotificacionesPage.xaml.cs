namespace AxitHome.Views.Pages.ProfilePages;

public partial class NotificacionesPage : ContentPage
{
	public NotificacionesPage()
	{
		InitializeComponent();
	}

    private async void Button_Back(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
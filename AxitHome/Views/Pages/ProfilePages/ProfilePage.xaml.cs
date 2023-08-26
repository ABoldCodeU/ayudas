namespace AxitHome.Views.Pages.ProfilePages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}

    private async void TapDatosPersonales(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new DatosPersonalesPage());
    }

    private async void TapMiszonas(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new MisZonasPage());
    }

    private async void TapCuentasAsociadas(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new CuentasAsociadasPage());
    }

    private async void TapNotificaciones(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new NotificacionesPage());
    }

    private async void TapCambiarContrasea(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SuccefullyPasswordPage());
    }

    private async void TapAcercade(object sender, TappedEventArgs e)
    {

    }

    private async void TapCerrarSesion(object sender, TappedEventArgs e)
    {

    }
}
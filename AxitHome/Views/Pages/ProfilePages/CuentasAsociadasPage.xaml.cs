namespace AxitHome.Views.Pages.ProfilePages;

public partial class CuentasAsociadasPage : ContentPage
{
	public CuentasAsociadasPage()
	{
		InitializeComponent();
	}

    private async void Button_Back(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
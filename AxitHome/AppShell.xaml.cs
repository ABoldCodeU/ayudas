using AxitHome.Views.Pages;
using AxitHome.Views.Pages.ProfilePages;
using AxitHome.Views.Pages.StaffRecord;

namespace AxitHome;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		RegisterRoutes();
	}

    private void RegisterRoutes()
    {
        //Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(CreateAccountPage), typeof(CreateAccountPage));
        Routing.RegisterRoute(nameof(ReservacionesListPage), typeof(ReservacionesListPage));
        Routing.RegisterRoute(nameof(ReservacionPage), typeof(ReservacionPage));

        //New pages
        Routing.RegisterRoute("ProfilePage", typeof(ProfilePage));
    }
}

using AxitHome.ViewModels.Base;
using AxitHome.Views.Pages;
using System.Windows.Input;

namespace AxitHome.ViewModels;

public class ReservacionesListViewModel : BaseViewModel
{

    #region Commnad
    public ICommand RegistrarCommand { get; set; }
    public ICommand GoBackCommand { get; private set; }

    #endregion

    #region Constructor
    public ReservacionesListViewModel()
    {
        RegistrarCommand = new Command(async () => await Registrar());
        GoBackCommand = new Command(GoBack);
    }

    #endregion

    #region Private Methods
    private async Task Registrar()
    {
        GoBackCommand = new Command(GoBack);
        await Shell.Current.GoToAsync(nameof(ReservacionPage));
    }

    private void GoBack()
    {
        if (Shell.Current.Navigation.NavigationStack.Count > 1)
        {
            Shell.Current.Navigation.PopAsync();
        }
        else
        {
            Shell.Current.GoToAsync("//Inicio");
        }
    }
    #endregion
}
using AxitHome.ViewModels;

namespace AxitHome.Views.Pages;

public partial class ReservacionesListPage : ContentPage
{
    private readonly ReservacionesListViewModel _viewModel;
    public ReservacionesListPage(ReservacionesListViewModel ReservacionesLtsViewModel)
	{
		InitializeComponent();
        BindingContext = _viewModel = ReservacionesLtsViewModel;
    }
}
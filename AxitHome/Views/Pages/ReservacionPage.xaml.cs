using AxitHome.ViewModels;

namespace AxitHome.Views.Pages;

public partial class ReservacionPage : ContentPage
{
    private readonly ReservacionesListViewModel _viewModel;
    public ReservacionPage(ReservacionesListViewModel ReservacionesLtsViewModel)
	{
        InitializeComponent();
        BindingContext = _viewModel = ReservacionesLtsViewModel;
    }
}
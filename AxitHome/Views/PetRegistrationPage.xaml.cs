using Microsoft.Maui.Controls;
using System;

namespace AxitHome.Views.Pages
{
    public partial class PetRegistrationPage : ContentPage
    {
        public PetRegistrationPage()
        {
            InitializeComponent();
            BackButton.Clicked += OnBackButtonClicked;

        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MascotasRegistradasPage");
        }





    }
}




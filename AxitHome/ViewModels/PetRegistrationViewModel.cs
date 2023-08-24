using System;
using System.Windows.Input;
using AxitHome.ViewModels.Base;
using Microsoft.Maui.Controls;

namespace AxitHome.ViewModels
{
    public class PetRegistrationViewModel : BaseViewModel
    {
        

        public ICommand GoBackCommand { get; private set; }

        public PetRegistrationViewModel()
        {
            GoBackCommand = new Command(GoBack);
        }

        private async void GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }

    }
}

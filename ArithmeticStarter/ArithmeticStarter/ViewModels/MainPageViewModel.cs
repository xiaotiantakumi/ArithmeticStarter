using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArithmeticStarter.Views;

namespace ArithmeticStarter.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand NavigateSingleDigitAddCommand { get; set; }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "トップページ";
            NavigateSingleDigitAddCommand = new DelegateCommand(PageSingleDigitAddShow);
        }

        private void PageSingleDigitAddShow()
        {
            NavigationService.NavigateAsync("SingleDigitAdd");
        }
    }
}

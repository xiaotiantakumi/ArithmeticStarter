using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Prism.Services.Dialogs.Xaml;

namespace ArithmeticStarter.ViewModels
{
    public class SingleDigitAddViewModel : ViewModelBase
    {
        public int _correctCount;
        public int CorrectCount
        {
            get => _correctCount;
            set
            {
                SetProperty(ref _correctCount, value);
            }
        }
        public int _left;
        public int Left
        {
            get => _left;
            set
            {
                SetProperty(ref _left, value);
            }
        }
        public int _right;
        public int Right
        {
            get => _right;
            set
            {
                SetProperty(ref _right, value);
            }
        }
        private int? _result;
        private Random _random;

        public int? Result
        {
            get => _result;
            set
            {
                SetProperty(ref _result, value);
                Check();
            }
        }

        public SingleDigitAddViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _random = new Random();
            this.SetItems();
            Title = "たしざん";
        }

        private void SetItems()
        {
            Left = _random.Next(1, 10);
            Right = _random.Next(1, 10);
        }

        private void Check()
        {
            if (Left + Right == Result)
            {
                this.SetItems();
                this.Result = null;
                this.CorrectCount++;
            }
        }
    }
}

using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace ArithmeticStarter.ViewModels
{
    public class SingleDigitAddViewModel : ViewModelBase
    {
        public int Left { get; set; }
        public int Right { get; set; }
        public SingleDigitAddViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            var random = new Random();
            Left = random.Next(0, 10);
            Right = random.Next(0, 10);
            List<int> test = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                test.Add(random.Next(0,10));
            }
            Title = "たしざん";
        }
    }
}

using System;
using System.Windows.Input;
using StackOverflow.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace StackOverflow.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await AppShell.Current.GoToAsync(nameof(MyModalPage)));
        }

        public ICommand OpenWebCommand { get; }
    }
}

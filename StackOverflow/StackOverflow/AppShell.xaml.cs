using System;
using System.Collections.Generic;
using StackOverflow.ViewModels;
using StackOverflow.Views;
using Xamarin.Forms;

namespace StackOverflow
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MyModalPage), typeof(MyModalPage));
        }
    }
}


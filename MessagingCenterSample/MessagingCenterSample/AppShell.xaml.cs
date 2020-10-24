using System;
using System.Collections.Generic;
using MessagingCenterSample.ViewModels;
using MessagingCenterSample.Views;
using Xamarin.Forms;

namespace MessagingCenterSample
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}

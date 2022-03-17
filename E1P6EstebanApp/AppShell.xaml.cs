using E1P6EstebanApp.ViewModels;
using E1P6EstebanApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace E1P6EstebanApp
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Vehicle_Register.Models;
using Vehicle_Register.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vehicle_Register.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}
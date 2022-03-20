using System;
using System.ComponentModel;
using AwesomeControl;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ios_renderer.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            L1.Text = L2.Text = $"Should be {nameof(Color.HotPink)}";
        }
    }
}
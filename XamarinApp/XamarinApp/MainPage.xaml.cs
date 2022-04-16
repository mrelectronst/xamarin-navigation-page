using System;
using Xamarin.Forms;

namespace XamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            slider.Value = 0.5;
        }

        void Handle_Slider(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            label.Text = String.Format("Value : {0}", e.NewValue);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NextPage());
        }
    }
}

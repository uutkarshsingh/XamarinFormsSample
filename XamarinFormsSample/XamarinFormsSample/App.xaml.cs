using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinFormsSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

			Button btn = new Button
			{
				Text = "PREss the Button"
			}
			;
				MainPage = new ContentPage
			{
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label{
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "Hand Coded Xaamrin Forms Main Page"
						} ,
						btn
					}
				}
			};		
		


		}

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

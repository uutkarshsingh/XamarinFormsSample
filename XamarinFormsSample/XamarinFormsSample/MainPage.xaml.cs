using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

		public void  btn_Clicked_Now(object sender, EventArgs ea)
		{
				System.Diagnostics.Debug.WriteLine("BUTTON CLICKED RIGHT NOW....");
		}
    }
}

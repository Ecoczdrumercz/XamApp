using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace testTest
{
	public partial class MainPage : MasterDetailPage
	{
        int a = 0;
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page1());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            a++;
        }
    }
}

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
        public int CookieCount { get; set; }
        Label label;
		public MainPage()
		{
            CookieCount = 0;
			InitializeComponent();

		}
        
        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync()
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            CookieCount++ ;
            myLabel.Text = CookieCount.ToString();
        }
    }
}

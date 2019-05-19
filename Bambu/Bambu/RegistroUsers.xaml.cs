using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bambu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegistroUsers : ContentPage
	{
		public RegistroUsers ()
		{
			InitializeComponent ();
		}
        private void Btn_Registrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new DatosGenerales());
        }
    }
}
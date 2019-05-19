using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Bambu.Clases;

namespace Bambu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Opciones : ContentPage
	{
       
		public Opciones ()
		{
			InitializeComponent ();
            MostrarDatos();
		}
        private async void MostrarDatos()
        {
            try
            {
                DatosGManager manager = new DatosGManager();
                var res = await manager.getDatos();

                if (res != null)
                {
                   base.BindingContext = this;
                }
            }
            catch (Exception e1)
            {
                Console.Write("Error", e1);
            }
        }
    }
}
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
	public partial class Alertas : ContentPage
	{
		public Alertas ()
		{
			InitializeComponent ();
            listar();
        }

        private async void listar()
        {
            try
            {
                AlarmaManager manager = new AlarmaManager();
                var res = await manager.getAlertas();

                if (res != null)
                {
                    
                    lstAlertas.ItemsSource = res;
                }
            }
            catch (Exception e1)
            {
                Console.Write("Error", e1);
            }
        }      
        /*
        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            try
            {
                UserManager manager = new UserManager();
                var res = await manager.getUsuarios();

                if (res != null)
                {
                    lstUsuarios.ItemsSource = res;
                }
            }
            catch (Exception e1)
            {
                Console.Write("Error", e1);
            }
        }*/
    }
}
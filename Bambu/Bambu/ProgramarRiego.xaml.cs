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
	public partial class ProgramarRiego : ContentPage
	{
		public ProgramarRiego ()
		{
			InitializeComponent ();
            Listar();
            InsertarAlarma();
		}

        private async void Listar()
        {
            try
            {
                ProgramacionManager manager = new ProgramacionManager();
                var res = await manager.getProgramacion();

                if (res != null)
                {
                    lstProgramacion.ItemsSource = res;
                }
            }
            catch (Exception e1)
            {
                Console.Write("Error", e1);
            }
        }

        private async void InsertarAlarma()
        {
            try
            {
                ProgramarRiego ProgRiego = new ProgramarRiego();
                //var datos = await ProgRiego

            }
            catch (Exception e2)
            {
                Console.Write("Error", e2);
            }
        }
    }
}
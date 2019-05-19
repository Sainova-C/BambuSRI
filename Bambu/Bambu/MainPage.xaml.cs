using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using Bambu.Clases;

namespace Bambu
{
    public partial class MainPage : ContentPage
    {
        
        Usuario usuarios = new Usuario();
        UserManager Manager = new UserManager();
        //public string Descripcion { get; set; }        

        public MainPage()
        {
            InitializeComponent();
           // btnlogin.Clicked += BtnLogin_Clicked;
            //Descripcion = "Esta es una descricpion";
            //base.BindingContext = this;
        }

        private async void Btn_login_Clicked(object sender, EventArgs e)
        {
            try
            { 
            var res = await Manager.getUsuarios();
                if (res != null)
                {   
                    await Navigation.PushModalAsync(new DatosGenerales());
                    Carga.IsEnabled = true;
                    Carga.IsRunning = true;
                    Carga.IsVisible = true;
                }
                else
                {
                    await DisplayAlert("Aviso","No hay conexion a internet.","Ok");
                    Carga.IsEnabled = true;
                    Carga.IsRunning = true;
                    Carga.IsVisible = true;
                }  
            }
            catch (Exception Ex)
            {
                Console.Write(Ex);
                await DisplayAlert("Aviso", "No hay conexion a internet.", "Ok");
            }
        }

        private void Btn_registrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new RegistroUsers());
        }

        //private void BtnLogin_Clicked(object sender, EventArgs e)
        //{
        //    ((MainPage)this.Parent).PushAsync(new navegacion());
        //}


    }
}

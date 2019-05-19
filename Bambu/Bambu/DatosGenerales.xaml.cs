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
    public partial class DatosGenerales : TabbedPage
    {
        public DatosGenerales ()
        {
            InitializeComponent();
            Children.Add(new Opciones());
            Children.Add(new Alertas());
            Children.Add(new ProgramarRiego());
        }
    }
}
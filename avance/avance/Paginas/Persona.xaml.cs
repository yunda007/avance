using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

using avance.ViewModel;


namespace avance.Paginas
{
    public partial class Persona : ContentPage
    {
        public Persona()
        {
            InitializeComponent();
            this.BindingContext = new PersonaViewModel();
            btnver.Clicked += Btnver_Clicked;
        }

        private void Btnver_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Listado());
        }
    }
}

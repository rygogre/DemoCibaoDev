using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoCibaoDev
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PersonPage : ContentPage
	{
		public PersonPage ()
		{
			InitializeComponent ();

            //Instaciamos el ViewModel para obtener los datos a mostrar.
            ViewModels.PersonVM personVM = new ViewModels.PersonVM();
            BindingContext = personVM;

            personListView.ItemTapped += PersonListView_ItemTapped;
        }

        private void PersonListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new PersonDetailPage(e.Item)); //Pasamos el item seleccionado al detalle.
                                                                
        }
    }
}
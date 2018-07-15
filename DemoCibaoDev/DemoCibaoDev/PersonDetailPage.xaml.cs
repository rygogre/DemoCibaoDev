using DemoCibaoDev.Models;
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
	public partial class PersonDetailPage : ContentPage
	{
		public PersonDetailPage (object person)
		{
			InitializeComponent ();

            //No utilizamos un ViewModel para ver la diferencia
            //cuando escribimos codigos en la misma vista..
            if (person != null)
            {
                var personDetail = (Person)person;

                imagePerson.Source = personDetail.ImageName;
                nombreCompletoLabel.Text = personDetail.NombreCompleto;
                phoneLabel.Text = personDetail.Phone;
                emailLabel.Text = personDetail.Email;
            }
        }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppWebinar.Views
{
    public partial class Login : ContentPage
    {

        public Models.Pessoa PessoaMVVM { get; set; }
        public Login()
        {

            PessoaMVVM = new Models.Pessoa();

            InitializeComponent();

            this.BindingContext = PessoaMVVM;
        }


        public void btnClickLogin(object sende, EventArgs e)
        {
            PessoaMVVM.Nome = "Alunos";
            this.Navigation.PushModalAsync(new NavigationPage(new Dashboard(PessoaMVVM)));
        }
    }
}

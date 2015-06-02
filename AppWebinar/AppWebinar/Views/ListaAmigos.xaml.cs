using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppWebinar.Views
{
    public partial class ListaAmigos : ContentPage
    {
        public List<Models.Pessoa> lstAmigos { get; set; }
        public ListaAmigos()
        {
            lstAmigos = new List<Models.Pessoa>();
            lstAmigos.Add(new Models.Pessoa() { Nome = "Albert", Cidade = "Belo Horizonte" });
            lstAmigos.Add(new Models.Pessoa() { Nome = "Rafael", Cidade = "Belo Horizonte" });
            lstAmigos.Add(new Models.Pessoa() { Nome = "Micaella", Cidade = "Belo Horizonte" });
            lstAmigos.Add(new Models.Pessoa() { Nome = "Leonardo", Cidade = "Belo Horizonte" });
            lstAmigos.Add(new Models.Pessoa() { Nome = "Rodrigo Celebrone", Cidade = "Diadema/ SP" });//: Diadema/ SP

            InitializeComponent();

            this.BindingContext = lstAmigos;
        }
    }
}

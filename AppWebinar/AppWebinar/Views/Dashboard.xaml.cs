using AppWebinar.Models;
using AppWebinar.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AppWebinar
{
    public partial class Dashboard : ContentPage
    {
        public Pessoa PessoaMVVM { get; set; }
        public Dashboard()
        {
            PessoaMVVM = new Pessoa();
            InitializeComponent();
            this.BindingContext = PessoaMVVM;
            CriarBotoes();
        }

        public Dashboard(Pessoa pessoaMVVM)
        {
            PessoaMVVM = pessoaMVVM;
            InitializeComponent();

            this.BindingContext = PessoaMVVM;
            CriarBotoes();
        }

        public void CriarBotoes()
        {

            ToolbarItems.Add(new ToolbarItem("Listar", "icon.png", () =>
            {
                Navigation.PushModalAsync(new NavigationPage(new ListaAmigos()));
            }));

        }
    }
}


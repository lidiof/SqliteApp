using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SqliteApp.Views;

namespace SqliteApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Adicionar());

        }

        private void btnListar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Listar());
        }

        private void btnAlterar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnDeletar_Clicked(object sender, EventArgs e)
        {

        }
    }
}

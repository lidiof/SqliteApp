using SqliteApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SqliteApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Adicionar : ContentPage
    {
        
        public Adicionar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Clicked(object sender, EventArgs e)
        {
            string nome = lblNome.Text;
            string endereco = lblEndereco.Text;
            //DisplayAlert("!!"+nome, " " + endereco, "ok");
            try{
                SaveButtonClicked(nome,endereco);
                
            }
            catch (Exception x)
            {
                DisplayAlert("erro!!", "Erro no API " + x, "ok");
            }
            
        }
        private async void SaveButtonClicked(string nome, string endereco)
        {
            
            Company company = new Company() {
                Nome = nome,
                Endereco = endereco
        };
            await App.Sqlitedata.SaveCompanyAsync(company);
            //await Navigation.PopAsync();
        }

        private void btnVoltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
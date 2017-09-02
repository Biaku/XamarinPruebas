using Pruebas.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pruebas.ViewModels
{
    public class MainViewModel: INotifyPropertyChanged
    {
        private string texto = "Elige algo";
        public string Texto
        {
            set
            {
                if (texto != value)
                {
                    texto = value;
                    PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("Texto"));
                }
            }
            get
            {
                return texto;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand IrControles { get; }
        public ICommand IrListView { get; }

        public MainViewModel()
        {
            IrControles = new Command(NavegarMain);
            IrListView = new Command(NavegarList);
        }

        private async void NavegarMain()
        {            
            await App.Current.MainPage.Navigation.PushAsync(new ControlesView());
        }
        private async void NavegarList()
        {
            await App.Current.MainPage.Navigation.PushAsync(new ListaView());
        }
    }
}

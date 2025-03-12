using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SumaAppMvvm.ViewModels
{
    public partial class SumaAppViewModel : ObservableObject
    {
        [ObservableProperty]
        private double? numero1;
        [ObservableProperty]
        private double? numero2;
        [ObservableProperty]
        private double resultado;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void Calcular()
        {

            if (Numero1 == default(double) || Numero2 == default(double))
            {
                Alerta("Advertencia", "Los campos numericos no pueden ir vacios");
            }
            try
            {
                Resultado = (double)(Numero1 + Numero2);
            }
            catch (Exception ex)
            {
                Alerta("Advertencia", "Los campos numericos no pueden ir vacios"); 
            }
        }
        [RelayCommand]
        private void Limpiar()
        {
            Numero1 = 0;
            Numero2 = 0;
            Resultado = 0;
            

        }
    }

}




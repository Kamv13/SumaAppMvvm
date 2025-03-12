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
        private string numero1;
        [ObservableProperty]
        private string numero2;
        [ObservableProperty]
        private double resultado;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void Calcular()
        {

            if (Numero1 == null || Numero2 == null)
            {
                Alerta("Advertencia", "Los campos numericos no pueden ir vacios");
            }
            try
            {
                 Resultado = Math.round(Convert.ToDouble(Numero1) + Convert.ToDouble(Numero2),2);
            }
            catch (Exception ex)
            {
                Alerta("Advertencia", "Los campos numericos no pueden ir vacios"); 
            }
        }
        [RelayCommand]
        private void Limpiar()
        {
            Numero1 = string.Empty;
            Numero2 = string.Empty;
            Resultado = 0;
            

        }
    }

}




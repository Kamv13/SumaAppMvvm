

using System.Linq.Expressions;
using SumaAppMvvm.ViewModels;
namespace SumaAppMvvm.Views;

public partial class SumaAppView : ContentPage
{ 
   SumaAppViewModel viewModel = new SumaAppViewModel();

public SumaAppView() {
        InitializeComponent();

    viewModel = new SumaAppViewModel();
    this.BindingContext = viewModel;
}
 
}
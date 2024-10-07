using MauiDemo.Models;

namespace MauiDemo.Pages;

public partial class MauiCollectionControls : ContentPage
{
	public MauiCollectionControls()
	{
		InitializeComponent();
		BindingContext = new FotoViewModel();
	}

    private void AlertaCinto_OnChanged(object sender, ToggledEventArgs e)
    {
		DisplayAlert("Alerta Cinto Segurança",
			"Você selecionou/deselecionou este acessório", "OK");
    }
}
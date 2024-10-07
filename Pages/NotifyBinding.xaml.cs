using MauiDemo.Models;

namespace MauiDemo.Pages;

public partial class NotifyBinding : ContentPage
{
	Produto produto = new Produto();

	public NotifyBinding()
	{
		InitializeComponent();
		produto = new Produto
		{
			Nome = "IPhone 5",
			Preco = 1000.00m,
			Stock = 5
		};

		BindingContext = produto;
	}

    private async void btnAtualiza_Clicked(object sender, EventArgs e)
    {
		produto.Nome = "Galaxy Samsung 10";
		produto.Preco = 1080.00m;
		produto.Stock = 3;

		await DisplayAlert("Produto Atualizado",
			$"{produto.Nome} - {produto.Preco} - {produto.Stock}",
			"OK");
    }
}
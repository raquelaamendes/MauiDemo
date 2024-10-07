namespace MauiDemo.Pages;

public partial class MauiEditControls : ContentPage
{
	public MauiEditControls()
	{
		InitializeComponent();
        this.BindingContext = this;
        this.IsBusy = false;
        BtnLogin.Clicked += BtnLogin_Clicked;
	}

    private async void BtnLogin_Clicked(object sender, EventArgs e)
    {
        this.IsBusy = true;

        //login code
        await Task.Delay(8000);
        Application.Current.MainPage = new NavigationPage(new MainPage());
    }

    //private async void entry1_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //    string textoAntigo = e.OldTextValue;
    //    string novoTexto = e.NewTextValue;
    //    string meuTexto = entry1.Text;

    //    await DisplayAlert("Entry1 - TextChanged", $"{textoAntigo}" +
    //        $" - {novoTexto} - {meuTexto}", "OK");
    //}

    //private async void entry1_Completed(object sender, EventArgs e)
    //{
    //    string texto = ((Entry)sender).Text;
    //    await DisplayAlert("Entry1 - Completed", texto, "OK");
    //}

    //private async void Button_Clicked(object sender, EventArgs e)
    //{
    //    await progressBar.ProgressTo(0.90, 2000, Easing.Linear);
    //}
}
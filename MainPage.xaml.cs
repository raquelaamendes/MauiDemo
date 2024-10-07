using System.Text.Json;

namespace MauiDemo
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;
        Pessoa pessoa;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadMauiAsset();
        }

        async Task LoadMauiAsset()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("demo.json");
            using var reader = new StreamReader(stream);

            var contents = reader.ReadToEnd();

            var pessoa = JsonSerializer.Deserialize<Pessoa>(contents);

            BindingContext = pessoa;
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //}
    }

    public class Pessoa
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public int Idade { get; set; }

        public string Foto { get; set; }
    }

}

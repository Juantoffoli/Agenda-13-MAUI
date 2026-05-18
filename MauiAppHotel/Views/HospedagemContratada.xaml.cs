using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

[QueryProperty(nameof(Hospedagem), "hospedagem")]
public partial class HospedagemContratada : ContentPage
{
    public Hospedagem Hospedagem
    {
        set => BindingContext = value;
    }

    public HospedagemContratada()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(".."); // Voltar para a tela anterior
    }
}

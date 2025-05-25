namespace MauiAppHotel.Views;

public partial class FotosHotel : ContentPage
{
    public FotosHotel()
    {
        InitializeComponent();
    }

    private void OnVoltarClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}
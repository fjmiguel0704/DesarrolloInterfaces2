namespace Solarizados.Views;

public partial class PanelCitas : ContentPage
{
	public PanelCitas()
	{
		InitializeComponent();
	}

	async void volverLogin(object sender, EventArgs args) {
		Navigation.PushAsync(new Login());
	}

    async void detallesCitas(object sender, EventArgs args){
		Navigation.PushAsync(new DetallesCitas());
    }
}
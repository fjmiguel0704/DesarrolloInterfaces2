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
}
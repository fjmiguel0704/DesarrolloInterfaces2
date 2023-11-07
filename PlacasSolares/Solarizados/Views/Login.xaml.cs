using Solarizados.Views;

namespace Solarizados
{
    public partial class Login : ContentPage
    {

        public Login()
        {
            InitializeComponent();            
        }

        async void iniciarSesion(object sender, EventArgs args) {
            if (String.IsNullOrEmpty(nombreUsuario.Text) || String.IsNullOrEmpty(contraseñaUsuario.Text)) {
                errorCampo.Text = "Los campos no pueden estar vacíos";
                errorCampo.IsVisible = true;
            } else {
                errorCampo.IsVisible = false;
                await Navigation.PushAsync(new PanelCitas());
            }
        }
    }
}
namespace Diferencias
{
    /// <summary>
    /// Fernando te hago el comentario aquí arriba para decirte que no me ha dado tiempo a comentar nada. He estado hasta última hora con el programa
    /// </summary>
    public partial class MainPage : ContentPage
    {
        int contErrores = 0;
        int contAciertos = 0;
        Boolean volverJugar = false;
        public MainPage()
        {
            InitializeComponent();            
        }

        private void TapGestureRecognizer_Image(object sender, TappedEventArgs e)
        {
            Casa.IsVisible = true;
            contErrores += 1;
            contadorErrores.Text = "LLevas " + contErrores + " errores";
            if (contErrores == 3) { 
                txtTitulo.IsVisible = false;
                txtInstrucciones.IsVisible = false;
                contadorErrores.IsVisible = false;
                image1.IsVisible = false;
                image2.IsVisible = false;
                perdido.IsVisible = true;
                txtJugarNuevo.IsVisible = true;
                noVolverJugar.IsVisible = true;
                siVolverJugar.IsVisible = true;
                Casa.Opacity = 0;
                Casa2.Opacity = 0;
                Comedero.Opacity = 0;
                Comedero2.Opacity = 0;
                Perro.Opacity = 0;
                Perro2.Opacity = 0;
            }
        }

        private void TapGestureRecognizer_Image2(object sender, TappedEventArgs e)
        {
            contErrores += 1;
            contadorErrores.Text = "LLevas " + contErrores + " errores";
            if (contErrores == 3){
                txtTitulo.IsVisible = false;
                txtInstrucciones.IsVisible = false;
                contadorErrores.IsVisible = false;
                image1.IsVisible = false;
                image2.IsVisible = false;
                perdido.IsVisible = true;
                txtJugarNuevo.IsVisible = true;
                noVolverJugar.IsVisible = true;
                siVolverJugar.IsVisible=true;
                Casa.Opacity = 0;
                Casa2.Opacity = 0;
                Comedero.Opacity = 0;
                Comedero2.Opacity = 0;
                Perro.Opacity = 0;
                Perro2.Opacity = 0;
            }
        }

        async void diferenciaCasa(object sender, EventArgs args)
        {
            Casa.Opacity = 1;
            Casa2.Opacity = 1;
            contAciertos += 1;
            if (contAciertos == 3) { 
                ganado.IsVisible = true;
                txtTitulo.IsVisible = false;
                txtInstrucciones.IsVisible = false;
                contadorErrores.IsVisible = false;
                image1.IsVisible = false;
                image2.IsVisible = false;
                txtJugarNuevo.IsVisible = true;
                noVolverJugar.IsVisible = true;
                siVolverJugar.IsVisible = true;
                Casa.Opacity = 0;
                Casa2.Opacity = 0;
                Comedero.Opacity = 0;
                Comedero2.Opacity = 0;
                Perro.Opacity = 0;
                Perro2.Opacity = 0;
            }
        }

        async void diferenciaCasa2(object sender, EventArgs args)
        {
            Casa2.Opacity = 1;
            Casa.Opacity = 1;
            contAciertos += 1;
            if (contAciertos == 3)
            {
                ganado.IsVisible = true;
                txtTitulo.IsVisible = false;
                txtInstrucciones.IsVisible = false;
                contadorErrores.IsVisible = false;
                image1.IsVisible = false;
                image2.IsVisible = false;                
                txtJugarNuevo.IsVisible = true;
                noVolverJugar.IsVisible = true;
                siVolverJugar.IsVisible = true;
                Casa.Opacity = 0;
                Casa2.Opacity = 0;
                Comedero.Opacity = 0;
                Comedero2.Opacity = 0;
                Perro.Opacity = 0;
                Perro2.Opacity = 0;
            }
            
        }

        async void diferenciaComedero(object sender, EventArgs args)
        {
            Comedero.Opacity = 1;
            Comedero2.Opacity = 1;
            contAciertos += 1;
            if (contAciertos == 3)
            {
                ganado.IsVisible = true;
                txtTitulo.IsVisible = false;
                txtInstrucciones.IsVisible = false;
                contadorErrores.IsVisible = false;
                image1.IsVisible = false;
                image2.IsVisible = false;
                txtJugarNuevo.IsVisible = true;
                noVolverJugar.IsVisible = true;
                siVolverJugar.IsVisible = true;
                Casa.Opacity = 0;
                Casa2.Opacity = 0;
                Comedero.Opacity = 0;
                Comedero2.Opacity = 0;
                Perro.Opacity = 0;
                Perro2.Opacity = 0;
            }
        }

        async void diferenciaComedero2(object sender, EventArgs args)
        {
            Comedero2.Opacity = 1;
            Comedero.Opacity = 1;
            contAciertos += 1;
            if (contAciertos == 3)
            {
                ganado.IsVisible = true;
                txtTitulo.IsVisible = false;
                txtInstrucciones.IsVisible = false;
                contadorErrores.IsVisible = false;
                image1.IsVisible = false;
                image2.IsVisible = false;
                txtJugarNuevo.IsVisible = true;
                noVolverJugar.IsVisible = true;
                siVolverJugar.IsVisible = true;
                Casa.Opacity = 0;
                Casa2.Opacity = 0;
                Comedero.Opacity = 0;
                Comedero2.Opacity = 0;
                Perro.Opacity = 0;
                Perro2.Opacity = 0;
            }
        }

        async void diferenciaPerro(object sender, EventArgs args)
        {
            Perro.Opacity = 1;
            Perro2.Opacity = 1;
            contAciertos += 1;
            if (contAciertos == 3)
            {
                ganado.IsVisible = true;
                txtTitulo.IsVisible = false;
                txtInstrucciones.IsVisible = false;
                contadorErrores.IsVisible = false;
                image1.IsVisible = false;
                image2.IsVisible = false;
                txtJugarNuevo.IsVisible = true;
                noVolverJugar.IsVisible = true;
                siVolverJugar.IsVisible = true;
                Casa.Opacity = 0;
                Casa2.Opacity = 0;
                Comedero.Opacity = 0;
                Comedero2.Opacity = 0;
                Perro.Opacity = 0;
                Perro2.Opacity = 0;
            }
        }

        async void diferenciaPerro2(object sender, EventArgs args)
        {
            Perro2.Opacity = 1;
            Perro.Opacity = 1;
            contAciertos += 1;
            if (contAciertos == 3)
            {
                ganado.IsVisible = true;
                txtTitulo.IsVisible = false;
                txtInstrucciones.IsVisible = false;
                contadorErrores.IsVisible = false;
                image1.IsVisible = false;
                image2.IsVisible = false;
                txtJugarNuevo.IsVisible = true;
                noVolverJugar.IsVisible = true;
                siVolverJugar.IsVisible = true;
                Casa.Opacity = 0;
                Casa2.Opacity = 0;
                Comedero.Opacity = 0;
                Comedero2.Opacity = 0;
                Perro.Opacity = 0;
                Perro2.Opacity = 0;
            }
        }

        async void Jugar(object sender, EventArgs args)
        {
            ganado.IsVisible = false;
            perdido.IsVisible = false;
            txtTitulo.IsVisible = true;
            txtInstrucciones.IsVisible = true;
            contadorErrores.IsVisible = true;
            image1.IsVisible = true;
            image2.IsVisible = true;
            txtJugarNuevo.IsVisible = false;
            noVolverJugar.IsVisible = false;
            siVolverJugar.IsVisible = false;
            contAciertos = 0;
            contErrores = 0;
        }

        async void NoJugar(object sender, EventArgs args)
        {
            Application.Current.Quit();
        }

    }
}
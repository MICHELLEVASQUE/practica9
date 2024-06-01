using StackLayout.XAMARIN06;

namespace StackLayout.XAMARIN_05;

public partial class Xamarin05 : ContentPage
{
	public Xamarin05()
	{
		InitializeComponent();
        /// <summary>
        /// aqui nos da automaticamente los dos botones que hemos colocado en xaml,
        /// un boton nos ayuda a que cuando demos click nos aparezca un texto que diga presioname de nuevo
        /// esto para que cambie de textos y el otro es para dirigirnos a una pagina nueva por el 
        /// pushAsync y el nombre de nuestra nueva pagina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        (sender as Button).Text = "Presioname de nuevo";
        
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Xamarin06());

    }
}
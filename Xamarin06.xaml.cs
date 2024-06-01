using StackLayout.Ejercicio1_complementario;

namespace StackLayout.XAMARIN06;

public partial class Xamarin06 : ContentPage
{
	public Xamarin06()
	{
		InitializeComponent();
        /// <summary>
        /// un evento permite que cuando ingresemos un dato a un entry este lo guarda en esa cadena
        /// el otro evento permite que cuando cambiemos el contenido del control nos mandara a ese evento y el boton para 
        /// al dar click mandarnos a otra pagina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        string pasado = e.OldTextValue;
        string nuevo = e.NewTextValue;
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Ejercicio1());
    }
}
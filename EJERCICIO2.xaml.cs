using StackLayout.Ejercicio3_complementario;

namespace StackLayout.Ejercicio2_complementario;

public partial class EJERCICIO2 : ContentPage
{
	public EJERCICIO2()
	{
		InitializeComponent();
        //<summary>
        // el primer evento esta dirigido para obtener el resultado de la expresión  por medio de las variables y se muestra el
        // resultado, X (A), Y (B) y la expresión se convierte junto con las própiedades que le otorgamos por medio
        // de un Math.Pow para hacer mas facil el proceso de la operación
        //Un segundo evento que nos lleva al siguiente ejercicio que seria el EJERCICIO03
        // </summary>
        // <param name="sender"></param>
        // <param name="e"></param>
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        double resultado, X, Y;
        X = Convert.ToDouble(entry1.Text);
        Y= Convert.ToDouble(entry2.Text);
        resultado = Math.Pow(X + Y, 2) / 2;
        entryr.Text = resultado.ToString();

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EJERCICIO3());
    }
}
using Microsoft.Maui.Controls.Compatibility.Platform;
using StackLayout.Ejercicio2_complementario;

namespace StackLayout.Ejercicio1_complementario;

public partial class Ejercicio1 : ContentPage
{
	public Ejercicio1()
	{
		InitializeComponent();
        //<summary>
        // el primer evento es para dirigirnos a otra pagina
        // el segundo evento colocamos las formular para que nos haga el ejercicio de invertir numeros
        // declare las variables a utilizar, de ahi las converti y las coloque segun el numero de entry 
        // que declare en lo anterior por ejemplo si le coloque el A y quiero ese el entry1 y asi sucesivamente,
        // en el resultado lo que hice fue colocar las letras de ultimo al primero y sumando , para que al darle click
        // me aparezca el ultimo numero y el signo mas para que vayan a la par y el entryr solo es para que nos muestre el
        // resultado.
        // </summary>
        // <param name="sender"></param>
        // <param name="e"></param>
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		String resultado, datoa, datob, datoc,datod;
		datoa = Convert.ToString(entry1.Text);
        datob = Convert.ToString(entry2.Text);
        datoc = Convert.ToString(entry3.Text);
        datod = Convert.ToString(entry4.Text);
        resultado = datod+ datoc+ datob+ datoa;
        entryr.Text = resultado.ToString();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EJERCICIO2());
    }
}
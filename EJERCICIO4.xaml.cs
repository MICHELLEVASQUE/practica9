using StackLayout.Ejercicio5_complementario;

namespace StackLayout.Ejercicio4_complementario;

public partial class EJERCICIO4 : ContentPage
{
	public EJERCICIO4()
	{
		InitializeComponent();
        //<summary>
        // el primer evento es para realizar y calcular las operaciones al cuadrado y al cubo por medio de las declaraciones
        // de las siguientes variables numero que sera el numero que ingreso el usuario int cuadrado que seri para el calculo del numero al cuadrado
        // y int cubo para hacer el calculo de numero al cubo y esto se mostrara por medio de un entrycuadrado y el entrycubo que muestra
        // los resultados en pantalla si el numero es negativo le lanzara un label que tiene que ingresar un numero positivo 
        // </summary>
        // <param name="sender"></param>
        // <param name="e"></param>

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (int.TryParse(entry1.Text, out int numero) && numero >= 0)
        {
            int cuadrado = numero * numero;
            int cubo = numero * numero * numero;
            entrycuadrado.Text = cuadrado.ToString();
            entrycubo.Text = cubo.ToString();
        }
        else
        {
            resultadoLabel.Text = "Ingrese un número entero positivo válido.";
            
        }
        


       

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Ejercicio5());
    }
}
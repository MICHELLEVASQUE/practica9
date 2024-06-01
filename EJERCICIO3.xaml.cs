using StackLayout.Ejercicio4_complementario;

namespace StackLayout.Ejercicio3_complementario;

public partial class EJERCICIO3 : ContentPage
{
	public EJERCICIO3()
	{
		InitializeComponent();
        //<summary>
        // el primer evento es para realizar y calcular el resultado de las 5 calificaciones ingresadas
        // para eso creamos 6 variables de tipo double una de resultado que se encargara de hacer la operacion 
        // y de la A a la E que se encargan de guardar los datos ingresados por el usuario 
        // tenemos el segundo evento que nos permite ingresar a la siguiente pagina que en este caso seria nuestro
        //siguiente EJERCICIO04
        // </summary>
        // <param name="sender"></param>
        // <param name="e"></param>
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        double resultado, A,B,C,D,E;
        A = Convert.ToDouble(entry1.Text);
        B = Convert.ToDouble(entry2.Text);
        C = Convert.ToDouble(entry3.Text);
        D = Convert.ToDouble(entry4.Text);
        E = Convert.ToDouble(entry5.Text);
        resultado = (A+B+C+D+E)/5;
        entryr.Text = resultado.ToString();

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EJERCICIO4());
    }
}
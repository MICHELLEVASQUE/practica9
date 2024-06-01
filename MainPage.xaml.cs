using StackLayout.XAMARIN_05;

namespace StackLayout
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
            /// <summary>
            /// solamente en este evento nos dirige a otra pagina
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>


        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Xamarin05());
        }
    }

}

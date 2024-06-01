using StackLayout.Ejercicio1_complementario;
using StackLayout.Ejercicio2_complementario;
using StackLayout.Ejercicio3_complementario;
using StackLayout.Ejercicio4_complementario;
using StackLayout.Ejercicio5_complementario;
using StackLayout.XAMARIN_05;
using StackLayout.XAMARIN06;

namespace StackLayout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            
        }
        
    }
}

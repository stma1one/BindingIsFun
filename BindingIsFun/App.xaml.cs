namespace BindingIsFun
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();//Binding between controls
            //MainPage=new PokemonDetailsPage();//Binding to an object
        }
    }
}

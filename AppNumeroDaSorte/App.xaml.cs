namespace AppNumeroDaSorte;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//A MainPage é na verdade um CurrentPage (Pagina atual)
		MainPage = new MainPage();
	}
}

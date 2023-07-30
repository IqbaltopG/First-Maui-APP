using FirstApp.ViewModel;

namespace FirstApp;

public partial class MainPage : ContentPage
{
	

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
	
		
		
		}


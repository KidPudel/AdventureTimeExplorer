namespace AdventureTimeExplorer;

public partial class MainPage : ContentPage
{
	public MainPage(CharacterViewModel characterViewModel)
	{
		InitializeComponent();
		BindingContext = characterViewModel;
	}
}


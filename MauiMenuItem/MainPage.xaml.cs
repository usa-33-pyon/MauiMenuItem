namespace MauiMenuItem;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
		var nextPage = new NavigationPage(new NewPage1());
		Navigation.PushModalAsync(nextPage);
	}
}



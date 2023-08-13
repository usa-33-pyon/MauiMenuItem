namespace MauiMenuItem;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();

        var list = new List<Item>();
        list = Enumerable.Range(1, 5)
                .Select(i => new Item { DisplayName = "item" + i })
                .ToList();
        listView.ItemsSource = list;
    }

    void OnMenuItemClicked(System.Object sender, System.EventArgs e)
    {
		DisplayAlert(null, "Alert Message", "OK");
    }

    void OnCloseButtonClicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}

public class Item
{
    public string DisplayName { get; set; }
}
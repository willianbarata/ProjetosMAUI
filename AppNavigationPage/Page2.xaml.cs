namespace AppNavigationPage;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Page3());
	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	
	}
}
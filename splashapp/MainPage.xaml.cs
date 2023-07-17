namespace splashapp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.blazorWebView = new Controls.Extended.CustomBlazorWebView();
    }
}


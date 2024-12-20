
using MobileApp.ViewModel;

namespace MobileApp.View;

public partial class HomePage : ContentPage
{
    public HomePageViewModel HomePageViewModel;
	public HomePage()
	{
		InitializeComponent();
        HomePageViewModel = BindingContext as HomePageViewModel;

    }


    void ZoomIn(object? sender, EventArgs e)
    {
        Camera.ZoomFactor += 1.0f;
    }

    void ZoomOut(object? sender, EventArgs e)
    {
        Camera.ZoomFactor -= 1.0f;
    }
}
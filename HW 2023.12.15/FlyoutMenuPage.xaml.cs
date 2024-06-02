public partial class FlyoutMenuPage : ContentView
{
    public FlyoutMenuPage()
    {
        InitializeComponent();
        BindingContext = new FlyoutMenuViewModel();
    }
}

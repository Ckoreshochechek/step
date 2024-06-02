public class FlyoutMenuViewModel
{
    public ObservableCollection<FlyoutItem> FlyoutItems { get; set; }

    public FlyoutMenuViewModel()
    {
        FlyoutItems = new ObservableCollection<FlyoutItem>();
        FlyoutItems.Add(new FlyoutItem { Title = "Contacts", Icon = "contacts.png" });
        FlyoutItems.Add(new FlyoutItem { Title = "Chats", Icon = "chats.png" });
        FlyoutItems.Add(new FlyoutItem { Title = "Settings", Icon = "settings.png" });
    }
}

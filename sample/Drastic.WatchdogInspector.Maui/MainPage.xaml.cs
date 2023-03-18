using System.Collections.ObjectModel;

namespace Drastic.WatchdogInspector.Maui;

public partial class MainPage : ContentPage
{
    private System.Timers.Timer timer;

    public MainPage()
    {
        InitializeComponent();
        this.timer = new System.Timers.Timer(1000);
        this.timer.Elapsed += Timer_Elapsed;
        this.timer.Enabled = true;
        this.BindingContext = this;
    }

    private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
        this.Items.Add(new TestClass() { Time = e.SignalTime });
    }

    public ObservableCollection<TestClass> Items { get; } = new ObservableCollection<TestClass>();
}

public class TestClass
{
    public string ImageUrl => "https://plchldr.co/i/250x250";

    public string Text => "Hello!";

    public DateTime Time { get; set; }
}
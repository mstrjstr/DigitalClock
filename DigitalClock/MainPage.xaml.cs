using System.Timers;

namespace DigitalClock;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        var timer = new System.Timers.Timer(1000);
        timer.Elapsed += new ElapsedEventHandler(DigitalClock);
        timer.Start();
    }

    public void DigitalClock(object Source, ElapsedEventArgs e)
    {
        var graphicsView = this.ClockGraphicsView;
        graphicsView.Invalidate();
    }
}


